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
    public partial class BusScreen : Form
    {
        public BusScreen()
        {
            InitializeComponent();
        }

        public void List()
        {
            dataGridViewBus.DataSource = FacadeBus.ListIt();
        }
        private void btnBusList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnBusAdd_Click(object sender, EventArgs e)
        {
            EntityBus add = new EntityBus();
            add.BusName = txtBusName.Text;
            add.BusPlate = txtBusPlate.Text;
            add.BusLocation = txtBusLocation.Text;
            add.BusDestination = txtBusDestination.Text;
            add.StaffID = Convert.ToInt32(comboBox1.SelectedItem);
            FacadeBus.ADD(add);
            List();
        }

        private void btnBusUpdate_Click(object sender, EventArgs e)
        {
            EntityBus upd = new EntityBus();
            upd.BusID = Convert.ToInt32(txtBusName.Tag);
            upd.BusName = txtBusName.Text;
            upd.BusPlate = txtBusPlate.Text;
            upd.BusLocation= txtBusLocation.Text;
            upd.BusDestination= txtBusDestination.Text;
            upd.StaffID= Convert.ToInt32(comboBox1.SelectedItem);          
            FacadeBus.Update(upd);
            List();
        }

        private void btnBusDelete_Click(object sender, EventArgs e)
        {
            EntityBus dlt = new EntityBus();
            dlt.BusID = Convert.ToInt32(txtBusName.Tag);
            FacadeBus.Delete(dlt);
            List();
        }

        private void dataGridViewBus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridViewBus.CurrentRow;
            txtBusName.Tag = line.Cells["BusID"].Value.ToString();
            txtBusName.Text = line.Cells["BusName"].Value.ToString();
            txtBusPlate.Text = line.Cells["BusPlate"].Value.ToString();
            txtBusLocation.Text = line.Cells["BusLocation"].Value.ToString();
            txtBusDestination.Text = line.Cells["BusDestination"].Value.ToString();
            comboBox1.SelectedItem = line.Cells["StaffID"].Value.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }

        private void BusScreen_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Staff";
            cmd.Connection = OtherConnection.con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            OtherConnection.con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["StaffID"]);
            }
            OtherConnection.con.Close();
            List();
        }
    }
}
