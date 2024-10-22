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
    public partial class frmTransaction : Form
    {
        clsUsers _LoginUser = new clsUsers();
        public frmTransaction(clsUsers LoginUser)
        {
            InitializeComponent();
            _LoginUser = LoginUser;
        }
        
        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            frmDepositAndWithDrow frm = new frmDepositAndWithDrow(1, " Deposit ");
            frm.ShowDialog();
        }

        private void btn_WithDrow_Click(object sender, EventArgs e)
        {
            frmDepositAndWithDrow frm = new frmDepositAndWithDrow(-1," Withdrow ");
            frm.ShowDialog();
        }

        private void btn_TotalBalance_Click(object sender, EventArgs e)
        {
            frmShowTotalBalances frm = new frmShowTotalBalances();
            frm.Show();
        }

        private void btn_MainMenue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            frmTransfer frm = new frmTransfer(_LoginUser);
            frm.Show();
        }

        private void btn_TranferLog_Click(object sender, EventArgs e)
        {
            frmTransferLog log=new frmTransferLog();
            log.Show();
        }
    }
}
