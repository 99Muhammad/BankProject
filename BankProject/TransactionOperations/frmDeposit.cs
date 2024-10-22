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
    public partial class frmDepositAndWithDrow : Form
    {
        DataTable dataTable = new DataTable();
        clsClient _Client = new clsClient();
        int Number =0;
        string Transaction = "";
        public frmDepositAndWithDrow(int number,string transaction)
        {
            Number = number;
            Transaction = transaction;
            InitializeComponent();
        }
        public void LoadDataForSingleClient(string AccountNumber, DataGridView dgv)
        {
            _Client = clsClient._FindClient(AccountNumber);
            // DataTable dt = new DataTable();
            if (_Client == null)
            {
                MessageBox.Show("Invalid account number ,try again!");
                txt_SearchByAccounyNumber.Text = null;
                return;
            }
            DataRow dw = dataTable.NewRow();
            if (dataGridView1.Columns.Count == 0)
            {
                dataTable.Columns.Add("ClientID", typeof(int));
                dataTable.Columns.Add("First Name", typeof(string));
                dataTable.Columns.Add("Last name", typeof(string));
                dataTable.Columns.Add("Account number", typeof(string));
                dataTable.Columns.Add("PinCode", typeof(string));
                dataTable.Columns.Add("Phone", typeof(string));
                dataTable.Columns.Add("Balance", typeof(string));
                dataTable.Columns.Add("Address", typeof(string));
                dataTable.Columns.Add("ImagePath", typeof(string));
            }

            dataTable.Rows.Add(_Client.ClientID, _Client.FirstName,
       _Client.LastName, _Client.AccountNumber, _Client.PinCode,
       _Client.Phone, _Client.Balance, _Client.Address, _Client.ImagePath);


            dgv.DataSource = dataTable;
            if(dataGridView1!=null)
            {
                txt_DepositAmount.Enabled = true;
            }

        }
        private void btn_LoadClientData_Click(object sender, EventArgs e)
        {
            
            LoadDataForSingleClient(txt_SearchByAccounyNumber.Text,
                dataGridView1);
            txt_SearchByAccounyNumber.Text = null;
        }

        private void _DepositOrWithdrow()
        {
            float DepositAmount=0, WithdrowAmount = 0;
            if (Number!=-1)
            {
                 DepositAmount = float.Parse(txt_DepositAmount.Text);
            }
            else
            {
                WithdrowAmount= float.Parse(txt_DepositAmount.Text);
            }
            //float WithdrowAmount = float.Parse(txt_DepositAmount.Text);
            //float DepositAmount = float.Parse(txt_DepositAmount.Text);
            clsTransaction transaction = new clsTransaction();

            transaction.InsertedNewTransaction(_Client.ClientID,
                 DepositAmount, WithdrowAmount,
                 DateTime.Now);
          
            if(DepositAmount>_Client.Balance&&Number==-1)
            {
                MessageBox.Show(@"The amount is greater than your balance.
                Try again", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            _Client.Balance += DepositAmount*Number;
            if (_Client._UpdateClient())
            {
                MessageBox.Show(@"Amount" +Transaction+" successfully " +
                    Environment.NewLine +
                    " New balance is : " + _Client.Balance.ToString(),
                   "Tip", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void chk_PerformTransaction_CheckedChanged(object sender, EventArgs e)
        {
            _DepositOrWithdrow();
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            txt_DepositAmount.Enabled = false;
            btn_LoadClientData.Enabled = false;
            chk_PerformTransaction.Enabled = false;
        }

        private void txt_SearchByAccounyNumber_TextChanged(object sender, EventArgs e)
        {
            btn_LoadClientData.Enabled = true;
        }

        private void txt_DepositAmount_TextChanged(object sender, EventArgs e)
        {
            chk_PerformTransaction.Enabled = true ;
        }
    }
}
