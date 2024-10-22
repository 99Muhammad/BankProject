using ClientsUsers_BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class frmListUser : Form
    {
        DataTable dt = new DataTable();
        clsUsers users = new clsUsers();
        public frmListUser()
        {
            InitializeComponent();
        }

        private void frmListUser_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users.GetAllUsers();
            
            comboBox1.SelectedIndex = 0;
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dt= users.GetAllUsers();
            DataView dv = dt.DefaultView;
            if (comboBox1.SelectedIndex == 0)
            {
                dv.RowFilter = "UserName LIKE '%" + txt_Search.Text + "%'";
            }
            else  if(comboBox1.SelectedIndex == 1) 
            {
                dv.RowFilter = "Password LIKE '%" + txt_Search.Text + "%'";
            }
            dataGridView1.DataSource = dv;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
