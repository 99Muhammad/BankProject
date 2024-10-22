using Clients_BussinessLayer;
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
    public partial class frmRegisters : Form
    {
        public enum enPermission
        {
            AllPages = -1, AddPage = 2, UpdatePage = 4, DeletePage = 8
        , ListPage = 16, FindPage = 32, ShowAllRegister = 64
        }
        clsUsers _LoginUser = new clsUsers();
        clsClient _Client = new clsClient();
        //int PermissionOfRegister = 64;
        clsInfoForUserLogin login = new clsInfoForUserLogin();
        public frmRegisters(clsUsers login)
        {
            InitializeComponent();
            _LoginUser = login;
        }

        private void frmRegisters_Load(object sender, EventArgs e)
        {
            if (((_LoginUser.Permission & (int)enPermission.ShowAllRegister)
               == (int)enPermission.ShowAllRegister)
               )
            {
                dataGridView1.DataSource = _LoginUser.GetAllRegetered();
                lbl_NumberOfRregistered.Text = _LoginUser.NumberOfRecord().ToString();
            }
            else
            {
                MessageBox.Show("Sorry you don't have access!","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Close();
            }
           

        }
    }
}
