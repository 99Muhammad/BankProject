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
    public partial class frmDelete : Form
    {
        clsUsers _LoginUser = new clsUsers();
        clsInfoForUserLogin login = new clsInfoForUserLogin();
        public frmDelete()
        {
            InitializeComponent();
           // _LoginUser = LoginUser;
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {


            
        }

        private void btn_uShowdata_Click(object sender, EventArgs e)
        {

            _LoginUser = clsUsers.Find(txt_UserName.Text,txt_Password.Text);

            if (_LoginUser == null)
            {
                //txtBoxDel_Validating(sender, e);
                MessageBox.Show(@"User with (User name and Pasword) 
                is Not avaliable,try another one", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = _LoginUser.
                 ShowInfoForSingleUser(_LoginUser);
        }

        private void btn_uDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this user?"
              , "Confirm",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                if (_LoginUser.Delete())
                {
                    MessageBox.Show(@"Delted done succssfully", "Result",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(@"Deleted failed", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
            
        }

        private void btn_uClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
