using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clients_BussinessLayer;
using ClientsUsers_BussinessLayer;
using static Clients_BussinessLayer.clsClient;

namespace BankProject
{
    public partial class frm_ClientMenue : Form
    {

        bool isFill = false;
        //clsUserNamePaswword namePaswword;
      //clsInfoForUserLogin clsInfo = new clsInfoForUserLogin();
        bool EnabledAndDisable = false;
        DataTable dataTable = new DataTable();
        clsUsers LoginUser = new clsUsers();
       // string username="", password = "";
        //public frm_ClientMenue(clsInfoForUserLogin user)
        public frm_ClientMenue(clsUsers loginUser)
        {
           LoginUser = loginUser;
            InitializeComponent();
            //clsInfo = user;
            //username = Username;
            //password = Password;
        }
        clsClient _Client = new clsClient();
        
        
        
       
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public enum enPermissions {AllPages=-1,NothingAnyPage=0, AddPage=2,UpdatePage=4,DeletePage=8
        ,ListPage=16,FindPage=32,ShowAllRegistered=64}

        private enPermissions permissions;

       //enPermissions permissions = (enPermissions)clsUsers.Permission;
        
        
        //private void _CheckPermissions()
        //{
           
        //    switch(permissions)
        //    {
        //        case enPermissions.AllPages:
        //            {

        //                break;
        //            }
        //            case enPermissions

        //    }
        //}

        //private void _MessageBoxForUsers()
        //{
        //    MessageBox.Show("This page isn't available for you!",
        //           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

        private void _CheckPermissionsForUsers()
        {
            // users = users.Find(username, password);

            if ((LoginUser.Permission & (int)enPermissions.AllPages)
                == (int)enPermissions.AllPages)
            {
                return;
            }

            if (LoginUser.Permission==0)
                {
                tt_All.Enabled = false;
                MessageBox.Show("This user does not have any permission" +
                    " for client !", 
                    "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
                }
            

            if ((LoginUser.Permission & (int)enPermissions.AddPage) ==
              (int)enPermissions.AddPage)
            {
                tp_AddClient.Enabled = true;
            }
            else
            {
                tp_AddClient.Enabled=false;
          
            }
            if ((LoginUser.Permission & (int)enPermissions.UpdatePage) ==
              (int)enPermissions.UpdatePage)
                {
                    tp_UpdateScreen.Enabled = true;
            }
            else
            {
                tp_UpdateScreen.Enabled=false;
         
            }
            if ((LoginUser.Permission & (int)enPermissions.DeletePage) ==
             (int)enPermissions.DeletePage)
            {
                tp_DeleteScreen.Enabled = true ;
            }
            else
            {
                tp_DeleteScreen.Enabled = false;
              
            }
            if ((LoginUser.Permission & (int)enPermissions.ListPage) ==
             (int)enPermissions.ListPage)
            {
                tp_ListScreen.Enabled = true;
              
            }
            else
            {
                tp_ListScreen.Enabled=false;
                dataGridView1.Visible = false;
            }
            if ((LoginUser.Permission & (int)enPermissions.FindPage) ==
             (int)enPermissions.FindPage)
            {
                tp_FindScreen.Enabled = true;
            }
            else
            {
                tp_FindScreen.Enabled = false;
            }
        }

        private void frm_MainMenue_Load(object sender, EventArgs e)
         {
            
            
           _CheckPermissionsForUsers();
          
            btn_ShowPreData.Enabled = false;
            btn_Update.Enabled = false;
            btnShowInfoClient.Enabled = false;
          
        }
        private bool _AddNewClient()
        {
            float Balance ;
            _Client.FirstName = txt_FirstName.Text;
            _Client.LastName = txt_LastName.Text;
            _Client.Phone = txt_Phone.Text;
            if (txt_ImagePath.Text != "")
            {
                _Client.ImagePath = txt_ImagePath.Text;
            }
            else
            {
                _Client.ImagePath = null;
            }

            _Client.Address = txt_Address.Text;

           if(float.TryParse(txt_Balance.Text.ToString(), out Balance ))
            {
                _Client.Balance = Balance;
            }
            else
            {
                MessageBox.Show("{ In a Balance field } Text is not allowed," +
                    " you must enter " +
                    "only a number","Error",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txt_Balance.Text = string.Empty;
                return false;
            }
            _Client.PinCode = txt_PinCode.Text;
            _Client.AccountNumber = txt_AccountNumber.Text;
            _Client.UserID = LoginUser.UserID;

            if (_Client.AddNewClient())
            {
                MessageBox.Show("Added done successfully");
                return true;
            }
             
            else
            {
              if(  MessageBox.Show(@"Some another client has the same
            PinCode or AccountNumber try another of them!",
                    "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    txt_PinCode.Text = "";
                    txt_AccountNumber.Text = "" ;
                }
            }
            return false;

        }
        private void EnabledAndDisableTextBoxesAfterUpdatingThem()
        {
                  txtFirstName.Enabled=EnabledAndDisable    ;
                  txtLastName.Enabled=EnabledAndDisable      ;       
                  txtPinCode.Enabled=EnabledAndDisable       ;
                  txtPhone.Enabled=EnabledAndDisable       ;
                  txtBalance.Enabled=EnabledAndDisable ;
                  txtAddress.Enabled=EnabledAndDisable ;
                  txtImagePath.Enabled=EnabledAndDisable  ;
                  btn_Update.Enabled = EnabledAndDisable;
                  btn_ShowPreData.Enabled = EnabledAndDisable; 
        }
        private void btn_Update_Click(object sender, EventArgs e)  
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" &&
              txtBalance.Text != ""
              && txtAddress.Text != "" && txtPinCode.Text != "" &&
              txtPhone.Text != "" )
            {
                if (MessageBox.Show("Are you sure you want to Update this client info?",
                    "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    
                    float cBalance;

                    _Client.FirstName =txtFirstName.Text;
                    _Client.LastName =txtLastName.Text;
                    _Client.PinCode =txtPinCode.Text;
                    _Client.Phone =txtPhone.Text;
                    if(float.TryParse(txtBalance.Text,out cBalance))
                    {
                        _Client.Balance = cBalance;
                    }
                    else
                    {
                        MessageBox.Show("No text is allowed in [ Balance ]" +
                            " field", "Error",
                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                  
                    _Client.Address = txtAddress.Text;
                    _Client.ImagePath =txtImagePath.Text;

                    //_Client.Mode = enMod.Update;

                    if (_Client._UpdateClient())
                    {

                        MessageBox.Show("Updated done successfully",
                    "Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                        
                        EnabledAndDisable = false;
                        EnabledAndDisableTextBoxesAfterUpdatingThem();
                    }
                    else
                    {
                        MessageBox.Show("Update failed !",
                    "Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                      
                    }
                }
            }
            else
            {
               MessageBox.Show("Please,Fill all fields","Error",
                   MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }
        private void btnLoadPreviousInfo_Click(object sender, EventArgs e)
        {
            _Client = clsClient._FindClient(txtAccountNumber.Text);
            if(_Client == null )
            {
                MessageBox.Show("Invalid account number!", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Question);
                return;
            }
            EnabledAndDisable = true;

          EnabledAndDisableTextBoxesAfterUpdatingThem();

            txtFirstName.Text = _Client.FirstName;
            txtLastName.Text = _Client.LastName;
            txtPinCode.Text = _Client.PinCode;
            txtPhone.Text = _Client.Phone;
            txtBalance.Text = _Client.Balance.ToString();
            txtAddress.Text = _Client.Address;
            txtImagePath.Text = _Client.ImagePath;

            btn_Update.Enabled = true;

        }

        public void _DeleteClient(string AccountNumber)
        {  
            if (_Client.Delete())
            {
                MessageBox.Show("Deleted successfully");
            }
            else
            {
                MessageBox.Show("Deleted Failed");  
            }
        }
        private void btn_ShowClientInfo(object sender, EventArgs e)
        {
            _Client = clsClient._FindClient(txtBoxDel.Text);

            if(_Client==null)
            {
                //txtBoxDel_Validating(sender, e);
                MessageBox.Show(@"Client with this account number 
                is Not avaliable,try another one","Error",
                MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
           frmClientInfo frm = new frmClientInfo(_Client);
           frm.Show();
           // _DeleteClient();
        }

        private void tt_Update_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsClient.GetAllClients();
        }

       
        //public  void LoadDataForSingleClient(clsClient client,DataGridView dgv)
        //{
        //   // _Client = clsClient._FindClient(AccountNumber);
        //    // DataTable dt = new DataTable();
        //    if(client == null)
        //    {
        //        MessageBox.Show("Invalid account number ,try again!");
        //        txtBoxDel.Text = null;
        //        return;
        //    }
        //    DataRow dw = dataTable.NewRow();
        //    if (dataGridView2.Columns.Count == 0)
        //    {
        //        dataTable.Columns.Add("ClientID", typeof(int));
        //        dataTable.Columns.Add("First Name", typeof(string));
        //        dataTable.Columns.Add("Last name", typeof(string));
        //        dataTable.Columns.Add("Account number", typeof(string));
        //        dataTable.Columns.Add("PinCode", typeof(string));
        //        dataTable.Columns.Add("Phone", typeof(string));
        //        dataTable.Columns.Add("Balance", typeof(string));
        //        dataTable.Columns.Add("Address", typeof(string));
        //        dataTable.Columns.Add("ImagePath", typeof(string));
        //    }

        //        dataTable.Rows.Add(client.ClientID, client.FirstName,
        //   client.LastName, client.AccountNumber, client.PinCode,
        //   client.Phone, client.Balance, client.Address, client.ImagePath);

            
        //    //else if(dataGridView2.Rows.Count ==1)
        //    //{
        //    //    dgv.DataSource = null;
        //    //    return;
        //    //}

        //    //االطريقة هاي اللي تحت ما بتزبط 
        //    // dt.Rows.Add(_Client.ClientID);
        //    // dt.Rows.Add(_Client.ClientID);
        //    // dt.Rows.Add(_Client.FirstName);
        //    // dt.Rows.Add(_Client.LastName);
        //    // dt.Rows.Add(_Client.AccountNumber);
        //    // dt.Rows.Add(_Client.PinCode);
        //    // dt.Rows.Add(_Client.Phone);
        //    // dt.Rows.Add(_Client.Balance);
        //    // dt.Rows.Add(_Client.Address);
        //    // dt.Rows.Add(_Client.ImagePath);

        //    //هاي الطريقة الثانية 
        //    //dw["ClientID"] = _Client.ClientID;
        //    //dw["First Name"] = _Client.FirstName;
        //    //dw["Last name"] = _Client.LastName;
        //    //dw["Account number"] = _Client.AccountNumber;
        //    //dw["PinCode"] =  _Client.PinCode;
        //    //dw["Phone"] = _Client.Phone;
        //    //dw["Balance"] = _Client.Balance;
        //    //dw["Address"] = _Client.Address;
        //    //dw["ImagePath"] = _Client.ImagePath;
        //    //dt.Rows.Add(dw);
        //    dgv.DataSource = dataTable;
        //}


        public void btn_Search_Click(object sender, EventArgs e)
        {
            _Client = clsClient._FindClient(txtAccount1.Text);
            if (_Client != null)
            {
                //_Client.AccountNumber = ;
                dataGridView2.DataSource = _Client.LoadDataForSingleClient(_Client);
                txtAccount1.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("The account number does not belong " +
                    "to any client, try again", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccount1.Text = string.Empty;
            }
           
        }
        private void txt_SearchByName(object sender, EventArgs e)
        {
            dataTable = clsClient.GetAllClients();
            DataView dv = dataTable.DefaultView;
            dv.RowFilter = "FirstName LIKE '%" + txtSearchByName.Text + "%'";
            dataGridView1.DataSource = dv;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_FirstName.Text != "" && txt_LastName.Text != "" &&
               txt_Balance.Text != ""
               && txt_Address.Text != "" && txt_PinCode.Text != "" &&
               txt_Phone.Text != "" && txt_AccountNumber.Text != "")
            {
                if( MessageBox.Show("Are you sure you want add this clietn?",
                    "Confirm",MessageBoxButtons.YesNo,
                    MessageBoxIcon.Asterisk, 
                    MessageBoxDefaultButton.Button1)== DialogResult.Yes)
                {
                    if (_AddNewClient())
                    {
                        txt_FirstName.Text = "";
                        txt_LastName.Text = "";
                        txt_Phone.Text = "";
                        txt_PinCode.Text = "";
                        txt_Balance.Text = "";
                        txt_AccountNumber.Text = "";
                        txt_ImagePath.Text = "";
                        txt_Address.Text = "";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, Fill all client information");
            }
                
        }

        private void _ValidatingForAddClient(TextBox textbox, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textbox.Text.ToString()))
            {
                //e.Cancel = true;
                textbox.Focus();
                errorProvider1.SetError(textbox, textbox.Tag.ToString() + " should have a value");

            }
            else
            {
               // e.Cancel = false;
                errorProvider1.SetError(textbox, "");
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
          _ValidatingForAddClient((TextBox)sender, e);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        //private void txtAccountNumber_Validating(object sender, CancelEventArgs e)
        //{

        //    if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
        //    {
        //        txtAccountNumber.Focus();
        //        errorProvider1.SetError(txtAccountNumber, "Should write account number ");
              
        //    }
        //    else
        //    {
        //        // e.Cancel = false;
               
        //        errorProvider1.SetError(txtAccountNumber, "");
        //    }
        //}

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                btn_ShowPreData.Enabled = true;
            }
        }
        private void txt_ValidatingForUpdate(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt.Text.ToString()))
            {

                //e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, txt.Tag.ToString() + " should have a value");

            }
            else
            {
                // e.Cancel = false;
                errorProvider1.SetError(txt, "");
            }
        }
   
        private void txt_Validating_(object sender, CancelEventArgs e)
        {
            txt_ValidatingForUpdate((TextBox)sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataView dgv = dataTable.DefaultView;
            dgv.Sort = "FirstName ASC";
            dataGridView2.DataSource = dgv;
        }

        private void txtBoxDel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxDel.Text))
            {
                 txtBoxDel.Focus();

                errorProvider1.SetError(txtBoxDel,
           txtBoxDel.Tag.ToString() + " should have a value");
            }
            else {
                errorProvider1.SetError(txtBoxDel,
          txtBoxDel.Tag.ToString() + "");
            }

        
        }

        private void txtBoxDel_TextChanged(object sender, EventArgs e)
        {
            btnShowInfoClient.Enabled = true;
        }

        private void OrderDataByContextMenue(string AccordingWhat)
        {
            dataTable = clsClient.GetAllClients();
            DataView dgv = dataTable.DefaultView;
            dgv.Sort = AccordingWhat;
            dataGridView1.DataSource = dgv;
        }
        private void orderingNameASCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDataByContextMenue("firstName asc");
        }

        private void tp_AddClient_Click(object sender, EventArgs e)
        {

        }

        private void txtAccount1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tp_DeleteScreen_Click(object sender, EventArgs e)
        {

        }

        private void orderingByNameDESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderDataByContextMenue("Balance desc");
        }

        private void tp_UpdateScreen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tp_ListScreen_Click(object sender, EventArgs e)
        {

        }

        private void btn_CloseFind_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }
    }
}
