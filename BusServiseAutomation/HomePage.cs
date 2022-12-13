using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusServiseAutomation
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            BusScreen go = new BusScreen();
            go.Show();
            this.Hide();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            TicketScreen go = new TicketScreen();
            go.Show();
            this.Hide();
        }

        private void BtUser_Click(object sender, EventArgs e)
        {
            UserScreen go = new UserScreen();
            go.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1 go = new Form1();
            go.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ReportScreen go = new ReportScreen();
            go.Show();
            this.Hide();
        }
    }
}
