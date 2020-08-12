using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsr7.data;
using wsr7.Data;
using wsr7.Forms;

namespace wsr7.managers
{
    public abstract class ManagerLogin
    {
        public static User LocalUser { get; private set; }
        public static bool Auth(string login, string pass)
        {
            try
            {
                LocalUser = ModelContext.init().Users.Where(u => u.login == login && u.pass == pass).Single();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void DeAuth() 
        {
            LocalUser = null;
        }
    }
}
