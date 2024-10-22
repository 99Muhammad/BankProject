using Clients_BussinessLayer;
using Clients_DataAccessLayer;
using ClientsUsers_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace ClientsUsers_BussinessLayer
{
    //: clsInfoForUserLogin
    public class clsUsers 
    {

       // public static clsUsers User;
        public int UserID { get; set; }
        public  string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int Permission { get; set; }
        public int ClientID { get; set; }
        public DateTime DateTimeRegister { get; set; }

        public clsUsers()
        {
            
        }
        public clsUsers(string userName, string firstName, string lastName,
            string password, string phone, string address,
            string imagePath, int permission, int clientID, int userID)
        {
            UserName = userName;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Phone = phone;
            Address = address; 
            ImagePath = imagePath;
            Permission = permission;
            ClientID = clientID;
            UserID = userID;
            DateTimeRegister = DateTime.Now;
    }

        public bool AddNewUser()
        {

            ClientID = clsDataAccessUsers._AddUser(UserName, this.FirstName,
                this.LastName, Password, this.Phone, this.Address,
                this.ImagePath, this.Permission);
           

            return (ClientID != -1);
        }

        public DataTable ShowInfoForSingleUser(clsUsers LoginUser)
        {
            DataTable dt = new DataTable();
            {
                dt.Columns.Add("User name", typeof(string));
                dt.Columns.Add("First name", typeof(string));
                dt.Columns.Add("Last name", typeof(string));
                dt.Columns.Add("Password", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Permission", typeof(int));
                dt.Columns.Add("Address", typeof(string));
                dt.Columns.Add("Image path", typeof(string));

                dt.Rows.Add(LoginUser.UserName, LoginUser.FirstName,
                    LoginUser   .LastName,
                  LoginUser.Password,LoginUser.Phone, LoginUser.Permission,
                  LoginUser.Address, LoginUser.ImagePath);
            }
            return dt;
        }
        public bool UpdateUserInfo()
        {
            return clsDataAccessUsers._UpdateUserInfo(UserName,
               this.Password, this.Address,
                 this.FirstName, this.LastName, this.Phone, this.Permission,
                this.ImagePath);
        }
        public bool IsUserExisting(string UserName, string Password)
        {  
            return (clsDataAccessUsers.IsUserExisting(UserName, Password));
        }

        public static clsUsers Find(string UserName, string Password)
        {
            string Address = "", FirstName = "", LastName = "",
                Phone = "", ImagePath = "";
            int Permission = 0, clientID = 0, userID = 0;

            if (clsDataAccessUsers.Find(ref UserName,
             ref Password, ref Address, ref FirstName,
            ref LastName, ref Phone, ref Permission,
            ref ImagePath, ref userID))
            {
                return new clsUsers(UserName, FirstName, LastName,
                 Password, Phone, Address,
               ImagePath, Permission, clientID, userID);
            }
            return null;

        }
        public bool Delete()
        {
           
            //if(clsDataAccessRegisterDate.DeleteRegisteredByUserID(UserID)
            //    ||clsDataAccessClient.DeleteClientWithGivenUserID(UserID,ClientID))
            {
                return clsDataAccessUsers.Delete(UserName, Password);
            }
           // return false;
           
        }

        public DataTable GetAllUsers()
        {
            return clsDataAccessUsers.GetAllUsers();
        }

        public bool InserteDateTimeWhenLogin(int UserID, DateTime dateTime)
        {
            return clsDataAccessRegisterDate.InsertDateTimeWhenLogin(UserID, dateTime);
        }

        public DataTable GetAllRegetered()
        {
            return clsDataAccessRegisterDate.GetAllRegisteredInSystem();
        }
        public int NumberOfRecord()
        {
            return clsDataAccessRegisterDate.CountAllRegisteres();
        }

    }
}
