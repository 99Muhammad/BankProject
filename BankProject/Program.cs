using ClientsUsers_BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            clsUsers user=new clsUsers();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLoginScreen());
           // Application.Run(new frmAddAndUpdateUser(0,user));
            // Application.Run(new frmMainMenue(user));
           //Application.Run(new frm_ClientMenue(user));
            //tt_Update.TabPages[0].Enabled = false;
        }
    }
}
