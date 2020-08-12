using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wsr7.managers
{
    public abstract class ManagerForms
    {
        static Form CurrentForm = null;
        static bool UserClose = true;
        public static void ChangeForm(Form F)
        {
            if(CurrentForm != null)
            {
                UserClose = false;
                CurrentForm.Close();
                UserClose = true;
            }
            CurrentForm = F;
            CurrentForm.FormClosing += FormClosing;
            CurrentForm.StartPosition = FormStartPosition.CenterScreen;
            CurrentForm.Show();
        }

        private static void FormClosing(object sender, FormClosingEventArgs e)
        {
            if(UserClose)
                Application.Exit();
        }
    }
}
