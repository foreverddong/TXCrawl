using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXCrawl;
using System.Threading;
using System.Xml.Serialization;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace TXCrawlWinformUI
{
    public partial class MainForm : Form
    {
        public System.Windows.Forms.Timer timer = null;
        public Thread ticketThread;
        public MainForm()
        {
            LogHelper.logForm = this;
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(this.NextRepeat);
            timer.Interval = 60000;
            InitializeComponent();
        }


        private void removeQueryButton_Click(object sender, EventArgs e)
        {
            LogHelper.Log(LogType.NOTICE, $"Removed query {queryBox.SelectedItem} form query list.");
            this.queryBox.Items.RemoveAt(this.queryBox.SelectedIndex);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LogHelper.Log(LogType.NOTICE, "Starting TXCrawl WinForms GUI....");
            LogHelper.Log(LogType.NOTICE, "This is a very early test version, visit https://github.com/foreverddong/TXCrawl to submit issues.");
            this.SetRunning(false);
        }

        private void logClearButton_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";

        }

        private void newQueryButton_Click(object sender, EventArgs e)
        {
            QueryForm qf = new QueryForm(this);
            
            qf.viewing = false;
            qf.addticket = this.AddTicket;
            qf.Show();
        }

        public void AddTicket(SingleLineManager query)
        {
            this.queryBox.Items.Add(query);
            LogHelper.Log(LogType.NOTICE, $"Added query {query.ToString()} to query list.");
        }

        private void queryBox_DoubleClick(object sender, EventArgs e)
        {
            SingleLineManager selectedQuery = this.queryBox.SelectedItem as SingleLineManager;
            QueryForm qf = new QueryForm(this);
            qf.viewing = true;
            qf.query = selectedQuery;
            qf.Show();
        }

        public void GetTicketFromQuery(object qr)
        {
            var query = (SingleLineManager)qr;
            LogHelper.Log(LogType.NOTICE, $"Running query for {query}...");
            query.QueryTickets(query.GenerateURL());
            var tickets = new List<DirectTicket>(query.ticketsToday);
            query.ticketsToday.Clear();
            LogHelper.Log(LogType.NOTICE, $"Found {tickets.Count} direct-flight tickets.");
            foreach (DirectTicket ti in tickets)
            {
                this.foundTicketBox.Invoke((MethodInvoker) delegate { this.foundTicketBox.Items.Add(ti);});
            }
            
        }

        private void execOnceButton_Click(object sender, EventArgs e)
        {
            LogHelper.Log(LogType.NOTICE, $"Started Executing {this.queryBox.Items.Count} queries...");
            this.SetRunning(true);
            this.queryProgressBar.Value = 10;
            ticketThread = new Thread(this.GetTicketsSync);
            ticketThread.Start();

        }

        public void GetTicketsSync()
        {
            foreach (SingleLineManager sm in this.queryBox.Items)
            {
                try
                {
                    this.GetTicketFromQuery(sm);
                }
                catch (Exception ex) {
                    LogHelper.Log(LogType.ERROR, $"Encountered Error when executing query {sm}");
                    LogHelper.Log(LogType.ERROR, $"Exception Info: {ex.Message}");
                    sm.CloseAllOpenDrivers();
                }
            }
        }

        private void foundTicketBox_DoubleClick(object sender, EventArgs e)
        {
            ViewTicketForm tf = new ViewTicketForm(this.foundTicketBox.SelectedItem as DirectTicket);
            tf.Show();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            this.timer.Stop();
            ticketThread.Abort();
            this.StopAll();
        }

        public void StopAll()
        {
            foreach (SingleLineManager m in this.queryBox.Items)
            {
                m.CloseAllOpenDrivers();
            }
            LogHelper.Log(LogType.WARNING, "Aborted all running queries.");
            this.queryProgressBar.Value = 0;
            this.SetRunning(false);
        }

        private void querySaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "TXCrawl XML File|*.xml";
            sv.Title = "Save Queries To...";
            sv.ShowDialog();
            if (sv.FileName != "")
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<SingleLineManager>));
                using (StreamWriter sw = new StreamWriter(sv.FileName))
                {
                    List<SingleLineManager> savingQuery = queryBox.Items.Cast<SingleLineManager>().ToList();
                    xs.Serialize(sw, savingQuery);
                }
                LogHelper.Log(LogType.NOTICE, $"Saved {this.queryBox.Items.Count} queries to local file {sv.FileName}");
            }
            else 
            {
                LogHelper.Log(LogType.WARNING, $"Filename {sv.FileName} is invalid, no file is saved at this time.");
            }
            

        }

        private void queryLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "TXCrawl XML File|*.xml";
            op.Title = "Load Queries From...";
            op.ShowDialog();
            if (op.FileName != "")
            {
                if (!File.Exists(op.FileName))
                {
                    LogHelper.Log(LogType.ERROR, $"error loading file {op.FileName}, check if it exists.");
                    return;
                }
                XmlSerializer xs = new XmlSerializer(typeof(List<SingleLineManager>));
                using (StreamReader sr = new StreamReader(op.FileName))
                {
                    List<SingleLineManager> loaded = null;
                    try
                    {
                        loaded = xs.Deserialize(sr) as List<SingleLineManager>;
                    }
                    catch (Exception ex) {
                        LogHelper.Log(LogType.ERROR, $"Error loading file {op.FileName}, it might have been corrupted.");
                        LogHelper.Log(LogType.ERROR, $"Exception info: {ex.Message}");
                        return;
                    }
                    //loaded should be good at this point
                    foreach (SingleLineManager sm in loaded)
                    {
                        sm.ticketsToday = new List<DirectTicket>();
                        sm.openDrivers = new List<ChromeDriver>();
                        sm.logData += (string data) => { LogHelper.Log(LogType.NOTICE, data); };
                        sm.Increment += this.IncSubProgress;
                        sm.headless = true;
                        this.queryBox.Items.Add(sm);
                    }
                    LogHelper.Log(LogType.NOTICE, $"Successfully loaded {loaded.Count} items into your current queries");
                }
            }
        }

        private void execRepeatButton_Click(object sender, EventArgs e)
        {
            this.execOnceButton.PerformClick();
            this.timer.Interval = (int)this.intervalPicker.Value * 60000;
            this.timer.Start();
        }

        private void ticketSaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Tickets XML File|*.xml";
            sv.Title = "Save Tickets To...";
            sv.ShowDialog();
            if (sv.FileName != "")
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<DirectTicket>));
                using (StreamWriter sw = new StreamWriter(sv.FileName))
                {
                    List<DirectTicket> savingTicket = foundTicketBox.Items.Cast<DirectTicket>().ToList();
                    xs.Serialize(sw, savingTicket);
                }
                LogHelper.Log(LogType.NOTICE, $"Saved {this.foundTicketBox.Items.Count} direct flight tickets to local file {sv.FileName}");
            }
            else
            {
                LogHelper.Log(LogType.WARNING, $"Filename {sv.FileName} is invalid, no file is saved at this time.");
            }
        }

        private void ticketLoadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Direct Ticket XML File|*.xml";
            op.Title = "Load Tickets From...";
            op.ShowDialog();
            if (op.FileName != "")
            {
                if (!File.Exists(op.FileName))
                {
                    LogHelper.Log(LogType.ERROR, $"error loading file {op.FileName}, check if it exists.");
                    return;
                }
                XmlSerializer xs = new XmlSerializer(typeof(List<DirectTicket>));
                using (StreamReader sr = new StreamReader(op.FileName))
                {
                    List<DirectTicket> loaded = null;
                    try
                    {
                        loaded = xs.Deserialize(sr) as List<DirectTicket>;
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Log(LogType.ERROR, $"Error loading file {op.FileName}, it might have been corrupted.");
                        LogHelper.Log(LogType.ERROR, $"Exception info: {ex.Message}");
                        return;
                    }
                    //loaded should be good at this point
                    foreach (DirectTicket tkt in loaded)
                    {
                        this.foundTicketBox.Items.Add(tkt);
                    }
                    LogHelper.Log(LogType.NOTICE, $"Successfully loaded {loaded.Count} direct tickets into found ticket box");
                }
            }
        }

        private void removeTicketButton_Click(object sender, EventArgs e)
        {
            this.foundTicketBox.Items.Remove(this.foundTicketBox.SelectedItem);
        }

        public void IncSubProgress(int totalItemsInsession)
        {
            double singlePer = 1.0 / (double)this.queryBox.Items.Count;
            double indivPer = singlePer / (double)totalItemsInsession;
            int progress = (int)(indivPer * 10000.0);
            this.queryProgressBar.Invoke((MethodInvoker)delegate { this.queryProgressBar.Value += progress; });
        }

        public void SetRunning(bool isRunning)
        {
            this.queryBox.Enabled = !isRunning;
            this.querySaveButton.Enabled = !isRunning;
            this.queryLoadButton.Enabled = !isRunning;
            this.execOnceButton.Enabled = !isRunning;
            this.execRepeatButton.Enabled = !isRunning;
            this.newQueryButton.Enabled = !isRunning;
            this.removeQueryButton.Enabled = !isRunning;
            this.ticketLoadButton.Enabled = !isRunning;
            this.ticketSaveButton.Enabled = !isRunning;
            this.removeTicketButton.Enabled = !isRunning;
            this.stopButton.Enabled = isRunning;

        }

        public void NextRepeat(object sender, EventArgs e)
        {
            this.StopAll();
            this.execOnceButton.PerformClick();
        }
    }

    
}
