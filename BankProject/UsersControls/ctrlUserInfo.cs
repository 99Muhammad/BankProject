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
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public event Action<string> OnSave;

        protected virtual void SaveClicked(string x)
        {
            Action<string> handler = OnSave;
            if(handler != null)
            {
                handler(x);
            }
        }
        private void _ctrlErrorProvider(TextBox UserText,CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserText.Text.ToString()))
            {
                UserText.Focus();
                errorProvider1_User.SetError(UserText, UserText.Tag.ToString() + " should have a value");
            }
            else
            {
                // e.Cancel = false;
                errorProvider1_User.SetError(UserText, "");
            }

        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            _ctrlErrorProvider((TextBox)sender, e);
           
        }
    }
}
