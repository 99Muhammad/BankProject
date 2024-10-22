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
using static System.Net.Mime.MediaTypeNames;

namespace BankProject
{
    public partial class frmUpdateUserInfo : Form
    {
        clsUsers _LoginUsers = new clsUsers();

        public frmUpdateUserInfo(clsUsers LoginUser)
        {
            _LoginUsers = LoginUser;
            InitializeComponent();

        }

        private bool IsUserExisting(string usernme, string password)
        {
            //if(_LoginUsers.IsUserExisting(usernme,password))
            //{
            //    clsInfoForUserLogin User =clsUsers.Find(usernme, password);
            //    return true;
            //}
            return _LoginUsers.IsUserExisting(usernme, password);

            //return false;
          
        }
        private void btn_GoToUpdate_Click(object sender, EventArgs e)
        {
            if (txt_uUserNameUpdate.Text == ""||txt_uPasswordUpdate.Text
                =="")
            {
                MessageBox.Show("User name or password invalid!","Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_uUserNameUpdate.Text = null;
                txt_uPasswordUpdate.Text = null;
                return;
            }
                
            if (IsUserExisting(txt_uUserNameUpdate.Text,
                txt_uPasswordUpdate.Text))
            {
                frmAddAndUpdateUser frm = new frmAddAndUpdateUser(1, _LoginUsers);
                frm.Show();
            }
            else
            {
                MessageBox.Show("User name or password invalid!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_uUserNameUpdate.Text = null;
                txt_uPasswordUpdate.Text = null;
            }
        }

        private void frmUpdateUserInfo_Load(object sender, EventArgs e)
        {
           
        }
       
        private void txt_uUserNameUpdate_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_uUserNameUpdate.Text.ToString()))
            {
                errorProvider1.SetError(txt_uUserNameUpdate,
                   "Cannot be empty,you should fill it");
                txt_uUserNameUpdate.Focus();
            }
           
        }

        private void txt_uPasswordUpdate_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_uPasswordUpdate.Text.ToString()))
            {
                errorProvider1.SetError(txt_uPasswordUpdate,
                   "Cannot be empty,you should fill it");
                txt_uPasswordUpdate.Focus();
            }
        }

        private void btn_closeUpdate_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_PasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_PasswordShow.Checked==true)
            {
                txt_uPasswordUpdate.UseSystemPasswordChar = false;
            }
            else
            {
                txt_uPasswordUpdate.UseSystemPasswordChar = true;
            }
        }
    }
}
