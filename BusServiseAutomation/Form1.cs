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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusServiseAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void List()
        {
            dataGridViewStaff.DataSource = FacadeStaff.ListIt();
        }
        private void btnStaffList_Click(object sender, EventArgs e)
        {
            List();
        }

        private void btnStaffAdd_Click(object sender, EventArgs e)
        {
            EntityStaff add = new EntityStaff();
            add.StaffName=txtStaffAddName.Text;
            add.StaffMail=txtStaffMail.Text;
            add.StaffPhone = txtSatffPhone.Text;
            add.StaffPassword = txtPasswordAdd.Text;
            add.UserID =Convert.ToInt32(comboBox1.SelectedItem);
            FacadeStaff.ADD(add);
            List();
        }

        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            EntityStaff upd = new EntityStaff();
            upd.StaffID = Convert.ToInt32(txtStaffAddName.Tag);
            upd.StaffName = txtStaffAddName.Text;
            upd.StaffMail = txtStaffMail.Text;
            upd.StaffPhone = txtSatffPhone.Text;
            upd.StaffPassword = txtPasswordAdd.Text;
            upd.UserID = Convert.ToInt32(comboBox1.SelectedItem);
            FacadeStaff.Update(upd);
            List();
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            EntityStaff dlt = new EntityStaff();
            dlt.StaffID= Convert.ToInt32(txtStaffAddName.Tag);
            FacadeStaff.Delete(dlt);
            List();
        }

        private void dataGridViewStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow line=dataGridViewStaff.CurrentRow;
            txtStaffAddName.Tag = line.Cells["StaffID"].Value.ToString();
            txtStaffAddName.Text = line.Cells["StaffName"].Value.ToString();
            txtStaffMail.Text = line.Cells["StaffMail"].Value.ToString();
            txtSatffPhone.Text = line.Cells["StaffPhone"].Value.ToString();
            txtPasswordAdd.Text = line.Cells["StaffPassword"].Value.ToString();
            comboBox1.SelectedItem = line.Cells["UserID"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select*from Users";
            cmd.Connection = OtherConnection.con;
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr;
            OtherConnection.con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["UserID"]);
            }
            OtherConnection.con.Close();
            List();
            gBoxStaff.Visible = false;
            gBoxStaffLogin.Visible = true;
            dataGridViewStaff.Visible = false;
            btnStaffList.Visible = false;
            btnStaffDelete.Visible = false;
            btnNext.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OtherConnection.con;
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.CommandText = "LoginStaff";
            cmd.Parameters.AddWithValue("StaffName",txtStaffName.Text);
            cmd.Parameters.AddWithValue("StaffPassword", txtStaffPassword.Text);

            OtherConnection.con.Open();
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler!!!Başarılı Giriş...");
                gBoxStaff.Visible = true;
                gBoxStaffLogin.Visible = false;
                dataGridViewStaff.Visible = true;
                btnStaffList.Visible = true;
                btnStaffDelete.Visible = true;
                btnNext.Visible = true;

            }
            else
            {
                MessageBox.Show("Hatalı Giriş...");
            }
            
            OtherConnection.con.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            HomePage go = new HomePage();
            go.Show();
            this.Hide();
        }
    }
}
