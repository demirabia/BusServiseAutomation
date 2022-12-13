using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Entity;
using Facade;

namespace BusServiseAutomation
{
    public partial class ReportScreen : Form
    {
        public ReportScreen()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FacadeReport1.ListIt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FacadeReport1.ListIt1();
        }
    }
}
