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

namespace TXCrawlWinformUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            LogHelper.logForm = this;
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
        }

        private void logClearButton_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";

        }

        private void newQueryButton_Click(object sender, EventArgs e)
        {
            QueryForm qf = new QueryForm();
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
            QueryForm qf = new QueryForm();
            qf.viewing = true;
            qf.query = selectedQuery;
            qf.Show();
        }

        public List<DirectTicket> GetTicketFromQuery(SingleLineManager query)
        {
            query.QueryTickets(query.GenerateURL());
            return new List<DirectTicket>(query.ticketsToday);
        }

        private void execOnceButton_Click(object sender, EventArgs e)
        {

        }
    }

    
}
