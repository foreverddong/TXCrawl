using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TXCrawl;

namespace TXCrawlWinformUI
{
    public partial class QueryForm : Form
    {
        public Action<SingleLineManager> addticket = null;
        public SingleLineManager query = null;
        public bool viewing = false;
        public MainForm mainf = null;
        public QueryForm(MainForm pr)
        {
            this.mainf = pr;
            InitializeComponent();
        }

        private void QueryForm_Load(object sender, EventArgs e)
        {
            if (viewing)
            {
                this.departingTextbox.Text = query.source;
                this.departingTextbox.Enabled = false;
                this.arrivalTextBox.Text = query.destination;
                this.arrivalTextBox.Enabled = false;
                this.departDatePicker.Value = query.date;
                this.departDatePicker.Enabled = false;
                switch (query.cabin)
                {
                    case Cabin.ECONOMY:
                        economyButton.Checked = true;
                        businessButton.Checked = false;
                        break;
                    case Cabin.BUSINESS:
                        businessButton.Checked = true;
                        economyButton.Checked = false;
                        break;
                }
                this.economyButton.Enabled = false;
                this.businessButton.Enabled = false;
                this.saveButton.Hide();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SingleLineManager newQr = new SingleLineManager
            {
                source = this.departingTextbox.Text,
                destination = this.arrivalTextBox.Text,
                date = this.departDatePicker.Value,
                cabin = (this.economyButton.Checked) ? Cabin.ECONOMY : Cabin.BUSINESS,
                //Delete headless = false in actual environment, it's intended for debugging only
                headless = true
            };
            newQr.logData += (string data) => { LogHelper.Log(LogType.NOTICE, data); };
            newQr.Increment += ((MainForm)this.mainf).IncSubProgress;
            addticket(newQr);
            this.Close();
        }
    }
}
