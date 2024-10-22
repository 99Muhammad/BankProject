using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsUsers_BussinessLayer
{
    public class clsInfoForUserLogin
    {
        public clsInfoForUserLogin forUserLogin;
        public  int UserID { get; set; }
        public  string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public  string Password { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public int Permission { get; set; }
        public int ClientID { get; set; }

        public DateTime UserRegister { get; set; }

        public clsInfoForUserLogin(string userName, string firstName,
            string lastName,
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
            UserRegister = DateTime.Now;
        }
        public void gg()
        {
          
        }
        public clsInfoForUserLogin()
        {
            //clsInfoForUserLogin cls = clsUsers.Find("", ""); 

            
        }



    }
}
