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
    public partial class frmTransferLog : Form
    {
        clsTransaction transaction = new clsTransaction();
        public frmTransferLog()
        {
            InitializeComponent();
        }

        private void frmTransferLog_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = transaction.GetAllTransfers();  
        }
    }
}
