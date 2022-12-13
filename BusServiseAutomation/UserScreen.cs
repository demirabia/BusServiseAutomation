using Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace BusServiseAutomation
{
    public partial class UserScreen : Form
    {
        public UserScreen()
        {
            InitializeComponent();
        }        
        public void List()
        {
            dataGridViewUser.DataSource = FacadeUser.ListIt();
        }

        private void btnUserList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            EntityUser add = new EntityUser();
            add.UserName = txtUserName.Text;
            add.UserMail = txtUserMail.Text;
            add.UserPhone = txtUserPhone.Text;
            add.UserYear = Convert.ToInt32(txtUserYear.Text);
            add.TicketID = Convert.ToInt32(comboBox1.SelectedItem);
            FacadeUser.ADD(add);
            List();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            EntityUser upd = new EntityUser();
            upd.UserID = Convert.ToInt32(txtUserName.Tag);
            upd.UserName = txtUserName.Text;
            upd.UserMail = txtUserMail.Text;
            upd.UserPhone = txtUserPhone.Text;
            upd.UserYear = Convert.ToInt32(txtUserYear.Text);
            upd.TicketID = Convert.ToInt32(comboBox1.SelectedItem);
            FacadeUser.Update(upd);
            List();
        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            EntityUser dlt = new EntityUser();
            dlt.UserID = Convert.ToInt32(txtUserName.Tag);
            FacadeUser.Delete(dlt);
            List();
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line = dataGridViewUser.CurrentRow;
            txtUserName.Tag = line.Cells["UserID"].Value.ToString();
            txtUserName.Text = line.Cells["UserName"].Value.ToString();
            txtUserMail.Text = line.Cells["UserMail"].Value.ToString();
            txtUserPhone.Text = line.Cells["UserPhone"].Value.ToString();
            txtUserYear.Text = line.Cells["UserYear"].Value.ToString();
            comboBox1.SelectedItem = line.Cells["TicketID"].Value.ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }

        private void UserScreen_Load(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Ticket";
            cmd.Connection = OtherConnection.con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            OtherConnection.con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["TicketID"]);
            }
            OtherConnection.con.Close();
            List();
        }
    }
}
