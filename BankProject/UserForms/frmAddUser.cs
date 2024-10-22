using ClientsUsers_BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    public partial class frmAddAndUpdateUser : Form
    {

        clsUsers _LoginUsers =new clsUsers();
        int CurentPer=0;
       public enum enAddUpdate { Add=0,Update=1,Delete=2,List=3};
        enAddUpdate crud = enAddUpdate.Add;

        public enum enPermissions {All=-1, Nothing =0, AddNewClient=2,UpdateClientInfo=4,Delete=8,
        List=16,Find=32,};
        enPermissions Permissions = enPermissions.Nothing;
        public frmAddAndUpdateUser(clsUsers LoginUser)
        {

            _LoginUsers = LoginUser;
            InitializeComponent();

          //  crud = (enAddUpdate)IndexButton;
        }

        private void _LoudInfoToUpdate(clsUsers users)
        {
            _LoginUsers.UserName = _LoginUsers.UserName;
            _LoginUsers.UserName = _LoginUsers.Password;
            _LoginUsers.Phone = users.Phone;
            _LoginUsers.ImagePath = users.ImagePath;
            _LoginUsers.Address = users.Address;
            _LoginUsers.Permission = users.Permission;
            _LoginUsers.FirstName = users.FirstName;
            _LoginUsers.LastName = users.LastName;
            _LoginUsers.Permission = users.Permission;
        }

        public frmAddAndUpdateUser(int IndexButton, clsUsers LoginUser)
        {
            InitializeComponent();

            
            _LoginUsers = LoginUser;
            crud = (enAddUpdate)IndexButton;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoudCheckedPermissions()
        {
            if((_LoginUsers.Permission & int.Parse(chk_AddClient.Tag.ToString()))==
              int.Parse(chk_AddClient.Tag.ToString()))
            {
                chk_AddClient.Checked = true ;
            }
            if((_LoginUsers.Permission & int.Parse(chk_UpdateClient.Tag.ToString()))
                == int.Parse(chk_UpdateClient.Tag.ToString()))
            {
                chk_UpdateClient.Checked = true;
            }
            if ((_LoginUsers.Permission & int.Parse(chk_DeleteClient.Tag.ToString()))
               == int.Parse(chk_DeleteClient.Tag.ToString()))
            {
                chk_DeleteClient.Checked = true;
            }
            if ((_LoginUsers.Permission & int.Parse(chk_FindClient.Tag.ToString()))
               == int.Parse(chk_FindClient.Tag.ToString()))
            {
                chk_FindClient.Checked = true;
            }
            if ((_LoginUsers.Permission & int.Parse(chk_ListClient.Tag.ToString()))
               == int.Parse(chk_ListClient.Tag.ToString()))
            {
                chk_ListClient.Checked = true;
            }
            if ((_LoginUsers.Permission & int.Parse(chk_Registered.Tag.ToString()))
               == int.Parse(chk_Registered.Tag.ToString()))
            {
                chk_Registered.Checked = true;
            }

        }
        private void _LoudUpdatePage()
        {
          
            txt_uUserName.Text = _LoginUsers.UserName;
            txt_uPassword.Text = _LoginUsers.Password;
            txt_uPhones.Text = _LoginUsers.Phone;
            txt_uUserName.Text = _LoginUsers.UserName;
            txt_uPassword.Text = _LoginUsers.Password;
            txt_uPhones.Text = _LoginUsers.Phone;
            txt_uImagePath.Text = _LoginUsers.ImagePath;
            txt_uAddress.Text = _LoginUsers.Address;
            txt_uFirstName.Text = _LoginUsers.FirstName;
            txt_uLastName.Text = _LoginUsers.LastName;
            _LoginUsers.Permission = _LoginUsers.Permission;

            _LoudCheckedPermissions();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {
            switch(crud)
            {
                case enAddUpdate.Add:
                    {
                        lbl_Address.Text = "Add new user";
                        lblLink_Remove.Visible = false;
                        CurentPer = 0;
                        break;
                    }
                case enAddUpdate.Update:
                    {
                        lbl_Address.Text = "Update user info";
                        txt_uUserName.Enabled = false;
                        txt_uPassword.Enabled = false;

                        _LoudUpdatePage();
                        break;
                    }
            }
        }

        private void txt_uPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private bool _UpdateUserInfo()
        {
            _LoginUsers.FirstName = txt_uFirstName.Text;
            _LoginUsers.LastName = txt_uLastName.Text;
            _LoginUsers.Address = txt_uAddress.Text;            
            _LoginUsers.Phone = txt_uPhones.Text;

            if (CurentPer == 126)
            {
                CurentPer = -1;
            }
            _LoginUsers.Permission = CurentPer;


            if (string.IsNullOrWhiteSpace(txt_uImagePath.Text))
            {
                _LoginUsers.ImagePath = null;
            }
            else
            {
                _LoginUsers.ImagePath = txt_uImagePath.Text;
              
            }

            return _LoginUsers.UpdateUserInfo();
        }
        
            private bool _AddUser()
        {
            _LoginUsers.FirstName = txt_uFirstName.Text;
            _LoginUsers.LastName = txt_uLastName.Text;
            _LoginUsers.Address = txt_uAddress.Text;
            _LoginUsers.UserName = txt_uUserName.Text;
            _LoginUsers.Password=txt_uPassword.Text;
            _LoginUsers.Phone = txt_uPhones.Text;

            if (CurentPer == 126)
            {
                CurentPer = -1;
            }
            _LoginUsers.Permission = CurentPer;


            if (txt_uImagePath.Text != "")
            {
                _LoginUsers.ImagePath = txt_uImagePath.Text;
            }
            else
            {
                _LoginUsers.ImagePath = null;
            }
            
            //_Users.ImagePath = txt_uImagePath.Text;

            return _LoginUsers.AddNewUser();
        }

        private void _EmptyAllFields(object sender, EventArgs e)
        {
            txt_uUserName.Text = string.Empty;
            txt_uFirstName.Text = string.Empty;
            txt_uLastName.Text = string.Empty;
            txt_uPassword.Text = string.Empty;
            txt_uPhones.Text = string.Empty;
            txt_uImagePath.Text = string.Empty;

            btn_RemoveAll_Click(sender,e);
            
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (crud==enAddUpdate.Add)
            {
                if (_AddUser())
                {
                    MessageBox.Show("The user has been " +
                        "added successfully ","Result",MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Adding user failed !,Username " +
                        "or password used,try another one", "Error",
                        MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_uUserName.Text = string.Empty;
                    txt_uPassword.Text = string.Empty;
                }
            }
            else if(crud==enAddUpdate.Update)
            {

                if(_UpdateUserInfo())
                {
                    if (MessageBox.Show("Are you sure you want to" +
                        " update this information? ", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        MessageBox.Show("User information has been " +
                            "updated successfully"
                            , "Result", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);


                        _EmptyAllFields(sender, e);
                    }         
                }
                else
                {
                    MessageBox.Show("Udating user information failed !",
                        "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void _UserValidating(TextBox txt,CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt.Text))
            {
                txt.Focus();
                errorProvider1.SetError(txt, txt.Tag.ToString() + " should have a value");
            }
            else
            {
                errorProvider1.SetError(txt,"");
            }
        }
        private void txt_uUserName_Validating(object sender, CancelEventArgs e)
        {
            _UserValidating((TextBox)sender, e);
        }

        private void btn_CheckedAll_Click(object sender, EventArgs e)
        {
            //CurentPer = -1;
           
           foreach(Control control in groupBox1.Controls)
            {
                if(control is CheckBox checkBox)
                {
                    checkBox.Checked = true;  
                }
            }
            //_LoginUsers.Permission = -1;
            CurentPer = -1;
        }

        private void btn_RemoveAll_Click(object sender, EventArgs e)
        {
           // CurentPer = 0;
            foreach(Control control in groupBox1.Controls)
            {
                if(control is CheckBox checkBox)
                {
                    checkBox.Checked = false;
                }
            }
        }

        private void CheckedChanged(CheckBox checkBox, EventArgs e)
        {

            if (checkBox.Checked)
            {
                CurentPer += int.Parse(checkBox.Tag.ToString());
            }
            else
            {
                CurentPer -= int.Parse(checkBox.Tag.ToString());
            }

        }

        private void chk_AddClient_CheckedChanged(object sender, EventArgs e)
        {
             CheckedChanged((CheckBox)sender, e);
        }

        private void lbl_Address_Click(object sender, EventArgs e)
        {

        }
    }
}
