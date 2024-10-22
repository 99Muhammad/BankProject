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
    public partial class frmShowTotalBalances : Form
    {
        clsTransaction transaction = new clsTransaction();
        public frmShowTotalBalances()
        {
            InitializeComponent();
        }
        private float ShowSumOfBalances()
        {
            return transaction.GetSumOfBalances();
        }
        private string ConvertNumberToString(int Number)
        {
            if(Number==0)
            {
                return "Zero";
            }
            string Word = "";
            if (Number <= 19)
            {
                string[] Units = { "", "One", "Two", "Three", "Four",
                "Five", "Six", "Seven", "Eight", "Nine", "Ten",
                "Eleven", "Twelve", "Thirteen", "Fourteen",
                "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
                Word += Units[Number];
            }
            if(Number>=20&&Number<=99)
            {
                string[] Tens = { "", "", "Twenty", "Thirty"
                        , "Forty", "Fifty", "Sixty", "Seventy", 
                    "Eighty", "Ninety" };
                Word+= Tens[Number/10] +" "+ConvertNumberToString(Number%10);
            }
            if(Number>=100 && Number<999)
            {
                Word+= ConvertNumberToString(Number/100)+" Hundred "+
                    ConvertNumberToString(Number%100);
            }
            if(Number>=1000 && Number<=9999)
            {
                Word += ConvertNumberToString(Number / 1000) + " Thousand " +
                    ConvertNumberToString(Number % 1000);
            }
            return Word;
        }
        private void frmShowTotalBalances_Load(object sender, EventArgs e)
        {
            float SumBalances = ShowSumOfBalances();
            lbl_TaxtBalances.Text ="( "+SumBalances.ToString()+" )"+
                ConvertNumberToString((int)SumBalances);
            dataGridView1.DataSource = transaction.GetAllBalances();
            //MessageBox.Show("Sum of all balances is : " +
            //    SumBalances + Environment.NewLine+
            //    "( "+ ConvertNumberToString((int)SumBalances)+" )");
        }
    }
}
