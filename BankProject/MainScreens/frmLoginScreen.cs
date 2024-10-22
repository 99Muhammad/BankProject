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
    public partial class frmLoginScreen : Form
    {

        int NumOfTrial = 1;
        int RoundNum = 3;
        int CountError = 0;
       
        public clsUsers UserLogin = new clsUsers();

        public clsInfoForUserLogin forUserLogin = new clsInfoForUserLogin();
      
        public frmLoginScreen()
        {
            InitializeComponent();
          
        }

        private void btnL_GoMainScreen_Click(object sender, EventArgs e)
        {
            /*  new clsUserNamePaswword
            //    (txtL_UserName.Text, txtL_Password.Text);
            //clsUserNamePaswword userNamePaswword =


            // clsUsers.User = clsUsers.User.Find("","");



            //  if (UserLogin.IsUserExisting(txtL_UserName.Text, txtL_Password.Text))*/


            UserLogin = clsUsers.Find(txtL_UserName.Text, txtL_Password.Text);
            if (UserLogin!=null)
            {
                /*forUserLogin.forUserLogin=
                //   user.Find(txtL_UserName.Text, txtL_Password.Text);
               
                // userLogin = user.Find(txtL_UserName.Text, txtL_Password.Text);*/


                UserLogin.InserteDateTimeWhenLogin(UserLogin.UserID
                   , UserLogin.DateTimeRegister);

               // frmMainMenue Main = new frmMainMenue(userLogin);

                frmMainMenue Main = new frmMainMenue(UserLogin);

                Main.Show();
            }
            else
            {
                MessageBox.Show("User name or paswword invalid!,try again"+
                    Environment.NewLine+ " You have "+ --RoundNum + " trial(s)"
                    , "Error",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);

                if(++NumOfTrial>3)
                {
                   
                    notifyIcon1.Icon = SystemIcons.Application;
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.BalloonTipTitle = "Error";
                    notifyIcon1.BalloonTipText = @"
                    Wait until the period expires and try again";
                    notifyIcon1.ShowBalloonTip(1000);
                    txtL_Password.Enabled = false;
                    txtL_UserName.Enabled = false;
                    btnL_GoMainScreen.Enabled = false;
                    timer1_Tick(sender, e);
                    NumOfTrial = 1;
                    RoundNum = 3;
                }
            }
            txtL_Password.Text = string.Empty;
            txtL_UserName.Text = string.Empty;
        }

        private void _ValidatingUserNamePassword(TextBox text, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(text.Text))
            {
                errorProvider1.SetError(text, text.Tag.ToString()+
                    " should has a value");
                text.Focus();
            }
            else
            {
                errorProvider1.SetError(text, "");
            }
        }
        private void _Validating(object sender, CancelEventArgs e)
        {
            _ValidatingUserNamePassword((TextBox)sender, e);
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountError++;
            lbl_Timer.Visible = true;
            lbl_Timer.Text = CountError.ToString();
            timer1.Enabled = true;
            lbl_tryagin.Visible = true;
            if (CountError==50)
            {
                timer1.Enabled = false;
                lbl_Timer.Visible=false;
                CountError = 0;
                txtL_Password.Enabled = true;
                txtL_UserName.Enabled = true;
                btnL_GoMainScreen.Enabled = true ;
                lbl_tryagin.Visible = false;
                return;
            }
        }

      
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            lbl_tryagin.Visible = false;
            lbl_Timer.Visible = false;
        }

        private void chk_Password_CheckedChanged(object sender, EventArgs e)
        {
            if(chk_Password.Checked==true)
            {
                txtL_Password.PasswordChar = '\0';
            }
            else
            {
                txtL_Password.PasswordChar = '*';
            }
            
        }
    }
}
