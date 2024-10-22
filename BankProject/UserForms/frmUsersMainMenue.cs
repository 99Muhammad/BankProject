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
    public partial class frmUsersMainMenue : Form
    {
        // clsInfoForUserLogin user = new clsInfoForUserLogin();
        clsUsers LoginUser = new clsUsers();
        public frmUsersMainMenue(clsUsers loginUser)
        {
            LoginUser = loginUser;
            InitializeComponent();
        }

        private void btn_AddUser_Click(object sender, EventArgs e)
        {
           
            frmAddAndUpdateUser frm = new frmAddAndUpdateUser(0,LoginUser);

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
           //the small form that transfer to Add form 
            frmUpdateUserInfo frm = new frmUpdateUserInfo(LoginUser);
            frm.Show();

        }

        private void frmUsersMainMenue_Load(object sender, EventArgs e)
        {

        }

        private void btn_DeleteUser_Click(object sender, EventArgs e)
        {
            frmDelete del = new frmDelete();
            del.Show();
        }

        private void btn_ListUser_Click(object sender, EventArgs e)
        {
            frmListUser frm = new frmListUser();
            frm.Show();
        }
    }
}
