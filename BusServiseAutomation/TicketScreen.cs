using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Facade;

namespace BusServiseAutomation
{
    public partial class TicketScreen : Form
    {
        public TicketScreen()
        {
            InitializeComponent();
        }

        public void List()
        {
            dataGridViewTicket.DataSource = FacadeTicket.ListIt();
        }

        public void totalPriceCalc()
        {
            txtTotal.Text = (Convert.ToInt32(txtTicketPrice.Text) * Convert.ToInt32(txtTicketQty.Text)).ToString();
        }
        private void btnTicketList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnTicketAdd_Click(object sender, EventArgs e)
        {
            EntityTicket add = new EntityTicket();
            add.TicketPrice = Convert.ToDecimal(txtTicketPrice.Text);
            add.TicketQty = Convert.ToInt32(txtTicketQty.Text);
            add.BusID = Convert.ToInt32(comboBox1.SelectedItem);
            FacadeTicket.ADD(add);
            List();
        }

        private void btnTicketUpdate_Click(object sender, EventArgs e)
        {
            EntityTicket upd = new EntityTicket();
            upd.TicketID = Convert.ToInt32(txtTicketPrice.Tag);
    ;       upd.TicketPrice = Convert.ToDecimal(txtTicketPrice.Text);
            upd.TicketQty = Convert.ToInt32(txtTicketQty.Text);
            upd.BusID = Convert.ToInt32(comboBox1.SelectedItem);
            totalPriceCalc();
            FacadeTicket.Update(upd);
            List();
        }

        private void btnTicketDelete_Click(object sender, EventArgs e)
        {
            EntityTicket dlt = new EntityTicket();
            dlt.TicketID = Convert.ToInt32(txtTicketPrice.Tag);
            FacadeTicket.Delete(dlt);
            List();
        }

        private void dataGridViewTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridViewTicket.CurrentRow;
            txtTicketPrice.Tag = line.Cells["TicketID"].Value.ToString();
            txtTicketQty.Text = line.Cells["TicketQty"].Value.ToString();
            txtTicketPrice.Text = line.Cells["TicketPrice"].Value.ToString();
            comboBox1.SelectedItem = line.Cells["BusID"].Value.ToString();
            totalPriceCalc();
        }

        private void TicketScreen_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Bus";
            cmd.Connection = OtherConnection.con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            OtherConnection.con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["BusID"]);
            }
            OtherConnection.con.Close();
            List();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }
    }
}
