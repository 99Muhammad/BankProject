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
    public partial class frmClientInfo : Form
    {
        //clsUsers loginUser=new clsUsers();
       
      public  clsClient _ClientInfo = new clsClient();
        string _AccountNumber;
        public frmClientInfo(clsClient ClientInfo)
        {
            InitializeComponent();
            _ClientInfo = ClientInfo;
           // _AccountNumber = accountNumber;
        }

        private void frmClientInfo_Load(object sender, EventArgs e)
        {
          //  frm_ClientMenue frm = new frm_ClientMenue( loginUser);
            //  _ClientInf = clsClient._FindClient(_AccountNumber);
         
         dataGridView1.DataSource = 
                _ClientInfo.LoadDataForSingleClient(_ClientInfo);
        //  frm.LoadDataForSingleClient(_ClientInfo, dataGridView1);  
         //   Image image = Image.FromFile(_ClientInf.ImagePath);

            // Set the image to the PictureBox
            //pictureBox1.Image = image;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //frm_ClientMenue frm = new frm_ClientMenue(loginUser);

            if ( MessageBox.Show("Are you sure to delete this client ??", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button2) ==DialogResult.Yes)
            {
                //frm._DeleteClient(_AccountNumber);
                if(_ClientInfo.Delete())
                {
                    MessageBox.Show("Deleted successfully", "Result",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Deletion operation failed", "Error",
              MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
