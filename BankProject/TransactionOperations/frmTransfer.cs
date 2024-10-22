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
    
    public partial class frmTransfer : Form
    {
        clsClient _ClientFrom = new clsClient();
        clsClient _ClientTo = new clsClient();

       clsTransaction transaction = new clsTransaction();
        clsUsers _LoginUser = new clsUsers();
        public frmTransfer(clsUsers LoginUser)
        {
            _LoginUser = LoginUser;
            InitializeComponent();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
           _ClientFrom = clsClient._FindClient(txt_transferFrom.Text);
            if (_ClientFrom != null)
            {
                lbl_AccNumberFrom.Text = _ClientFrom.AccountNumber;
                lbl_BalanceFrom.Text = _ClientFrom.Balance.ToString();
                lbl_FullNameFrom.Text = _ClientFrom.FirstName + " " +
                    _ClientFrom.LastName;
            }
            else
            {
                MessageBox.Show("Invalid account number ,try again");
            }

        }

        private void btn_ShowInfoTo_Click(object sender, EventArgs e)
        {
           _ClientTo = clsClient._FindClient(txt_TransferTo.Text);
            if (_ClientTo != null)
            {
                lbl_AccNumberTo.Text = _ClientTo.AccountNumber;
                lbl_BalanceTo.Text = _ClientTo.Balance.ToString();
                lbl_FullNameTo.Text = _ClientTo.FirstName + " " +
                    _ClientTo.LastName;
            }
            else
            {
                MessageBox.Show("Invalid account number ,try again");
            }
        }

        private void btn_PerformTransfer_Click(object sender, EventArgs e)
        {
            if(float.Parse(txt_TransferAmount.Text)>_ClientFrom.Balance)
            {
                MessageBox.Show("Amount larger than balance of" +
                    " accountnumber " + lbl_AccNumberFrom.Text + "try again",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            float BalanceBeforeTo= _ClientTo.Balance, BalanceBeforefrom= _ClientFrom.Balance;
            if (MessageBox.Show("Are you sure you want to perform transfer? ",
                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                
                _ClientFrom.Balance += float.Parse(txt_TransferAmount.Text) * -1;
                _ClientTo.Balance += float.Parse(txt_TransferAmount.Text) * 1;

                transaction.SaveTransferInfo(_LoginUser.UserName,
                     _LoginUser.Password,_ClientFrom.AccountNumber
                    ,_ClientTo.AccountNumber, BalanceBeforefrom,
                     BalanceBeforeTo, _ClientFrom.Balance, _ClientTo.Balance);

                if (_ClientFrom._UpdateClient()&& _ClientTo._UpdateClient())
                {
                    MessageBox.Show("Transfer done successfully ",
                   "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Transfer Failed ",
                  "Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {

        }
    }
}
