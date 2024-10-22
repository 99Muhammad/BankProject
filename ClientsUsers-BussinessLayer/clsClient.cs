using Clients_DataAccessLayer;
using ClientsUsers_BussinessLayer;
using ClientsUsers_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clients_BussinessLayer
{
    public class clsClient
    {
        public enum enMod { AddNew = 0, Update = 1 };
        public enMod Mode = enMod.AddNew;
        //clsInfoForUserLogin clsInfoForUser = new clsInfoForUserLogin("", "",
        //    "", "", "", "", "", 0, 0,0);
        clsInfoForUserLogin clsInfoForUser = new clsInfoForUserLogin();

        public int UserID = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public string Phone { get; set; }
        public float Balance { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int ClientID { get; set; }

        public clsClient()
        {
            this.ClientID = -1;
            this.FirstName = "";
            this.LastName = "";
            this.Balance = 0;
            this.Phone = "";
            this.ImagePath = "";
            this.Address = "";
            this.AccountNumber = "";
            this.PinCode = "";
            UserID = 0;

            Mode = enMod.AddNew;

        }

        public clsClient(string firstName,
            string lastName, string accountNumber,
            string pinCode, string phone, float balance,
            string address, string imagePath, int clientID, int userID)
        {
            Mode = enMod.Update;
            FirstName = firstName;
            LastName = lastName;
            AccountNumber = accountNumber;
            PinCode = pinCode;
            Phone = phone;
            Balance = balance;
            Address = address;
            ImagePath = imagePath;
            ClientID = clientID;
            UserID = userID;
        }

        public bool AddNewClient()
        {
            this.ClientID = clsDataAccessClient.Save(this.FirstName,
            this.LastName, this.AccountNumber, this.PinCode, this.Phone,
           this.Balance, this.Address, this.ImagePath, this.UserID);

            return (this.ClientID != -1);
        }

        public static clsClient _FindClient(string AccountNumber)
        {
            string FirstName = "", LastName = "", PinCode = "",
          Phone = "", Address = "", ImagePath = "";
            int ClientID = -1;
            float Balance = 0;
            // return clsDataAccessClient.FindClient(AccountNumber);
            if (clsDataAccessClient.FindClient(ref FirstName,
    ref LastName, ref AccountNumber, ref PinCode,
ref Phone, ref Balance, ref Address, ref ImagePath, ref ClientID))
            {
                return new clsClient(FirstName,
                 LastName, AccountNumber, PinCode,
                 Phone, Balance, Address, ImagePath, ClientID, 0);
            }
            return null;
        }
        public bool _UpdateClient()
        {

            return clsDataAccessClient.UpdateClientInfo(this.FirstName,
             this.LastName, this.AccountNumber, this.PinCode,
             this.Phone, this.Balance, this.Address, this.ImagePath
              , this.ClientID);

        }
        //public bool Save()
        //{
        //    switch(Mode)
        //    {
        //        case enMod.AddNew:
        //            {
        //                if(_AddNewClient())
        //                {
        //                    Mode = enMod.Update;
        //                    return true;
        //                }
        //                else{
        //                    return false;
        //                }
        //            }
        //        case enMod.Update:
        //            {
        //                if(_UpdateClient())
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //    }
        //    return false;

        //}

        public DataTable LoadDataForSingleClient(clsClient client)
        {
           // public void LoadDataForSingleClient(clsClient client, DataGridView dgv)

                /* _Client = clsClient._FindClient(AccountNumber);
                // DataTable dt = new DataTable();
                //if (client == null)
                //{
                //    MessageBox.Show("Invalid account number ,try again!");
                //    txtBoxDel.Text = null;
                //    return;
                //}*/

                DataTable dataTable = new DataTable();
            DataRow dw = dataTable.NewRow();
            // if (dataGridView2.Columns.Count == 0)
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

            dataTable.Rows.Add(client.ClientID, client.FirstName,
       client.LastName, client.AccountNumber, client.PinCode,
       client.Phone, client.Balance, client.Address, client.ImagePath);


           // dgv.DataSource = dataTable;
           return dataTable;    
        }
        public bool Delete()
        {
            return clsDataAccessClient.Delete(this.AccountNumber);
        }

        public static DataTable GetAllClients()
        {
            return clsDataAccessClient.GetAllClients();
        }

      
    }
}
