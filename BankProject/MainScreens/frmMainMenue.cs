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
    public partial class frmMainMenue : Form
    {
        // string username="", passwod = "";
        //clsInfoForUserLogin User = new clsInfoForUserLogin();
        clsUsers LoginUser = new clsUsers();
        // public frmMainMenue(clsInfoForUserLogin user)
        public frmMainMenue(clsUsers loginUser)
        {
            // User = user;
            //username = UserName;    
            //passwod = Password;
            InitializeComponent();
            LoginUser = loginUser;
        }

        private void clientMainMenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frm_ClientMenue frm = new frm_ClientMenue(LoginUser);
            //frm_ClientMenue frm = new frm_ClientMenue();
            frm.ShowDialog();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void goToManageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersMainMenue frm = new frmUsersMainMenue(LoginUser);
            frm.ShowDialog();   
        }

     
        private void showAllRegisteredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegisters frm = new frmRegisters(LoginUser);
            frm.ShowDialog();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransaction frm = new frmTransaction(LoginUser);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ClientMenue frm = new frm_ClientMenue(LoginUser);
            //frm_ClientMenue frm = new frm_ClientMenue();
            frm.ShowDialog();
        }

        private void btn_ManageClient_MouseHover(object sender, EventArgs e)
        {
            btn_ManageClient.BackColor = Color.LightGreen;
        }

        private void btn_ManageClient_MouseLeave(object sender, EventArgs e)
        {
            btn_ManageClient.BackColor = Color.Transparent;
        }

        private void btn_ManageUsers_MouseHover(object sender, EventArgs e)
        {
            btn_ManageUsers.BackColor = Color.LightGreen;
        }

        private void btn_ManageUsers_MouseLeave(object sender, EventArgs e)
        {
            btn_ManageUsers.BackColor=Color.Transparent;
        }

        private void btn_Transaction_MouseHover(object sender, EventArgs e)
        {
            btn_Transaction.BackColor = Color.LightGreen;
        }

        private void btn_Transaction_MouseLeave(object sender, EventArgs e)
        {
            btn_Transaction.BackColor = Color.Transparent;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btn_Registered.BackColor=Color.Transparent;
        }

        private void btn_Registered_MouseHover(object sender, EventArgs e)
        {
            btn_Registered.BackColor = Color.LightGreen;
        }

        private void btn_ManageUsers_Click(object sender, EventArgs e)
        {
            
            frmUsersMainMenue frm = new frmUsersMainMenue(LoginUser);
            frm.ShowDialog();
        }

        private void btn_Transaction_Click(object sender, EventArgs e)
        {
            frmTransaction frm = new frmTransaction(LoginUser);
            frm.Show();
        }

        private void btn_Registered_Click(object sender, EventArgs e)
        {
            frmRegisters frm = new frmRegisters(LoginUser);
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginUser= null;    
        }

        private void btn_CloseMainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
