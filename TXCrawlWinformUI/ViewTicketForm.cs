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
    public partial class ViewTicketForm : Form
    {
        public DirectTicket ticket = null;
        public ViewTicketForm(DirectTicket tkt)
        {
            this.ticket = tkt;
            InitializeComponent();
        }

        private void ViewTicketForm_Load(object sender, EventArgs e)
        {
            this.plusOneLabel.Visible = false;
            this.departLabel.Text = ticket.source;
            this.arriveLabel.Text = ticket.destination;
            this.departTimeLabel.Text = ticket.departure.ToShortTimeString();
            this.arriveTimeLabel.Text = ticket.arrival.ToShortTimeString();
            this.departDateLabel.Text = ticket.departure.ToShortDateString();
            if ((ticket.arrival.Date - ticket.departure.Date).TotalDays > 0)
            {
                this.plusOneLabel.Visible = true;
            }
            this.carrierNameLabel.Text = ticket.carrier;
            this.flightNumLabel.Text = ticket.flightNum;
            this.ticketPriceLabel.Text = $"￥{ticket.price}";
        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(ticket.targetLink);
        }
    }
}
