using ClientsUsers_BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class clsUserNamePaswword
    {
        public static string UserName { get; set; }

        public static string Password { get; set; }

        public clsUserNamePaswword(string username,string password) 
        {
            UserName = username;
            Password = password;  
           
        }
       
    }
}
