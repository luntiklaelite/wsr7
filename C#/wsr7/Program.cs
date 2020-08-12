using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using wsr7.managers;

namespace wsr7
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int errors = 0;
            while (true)
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    ManagerForms.ChangeForm(new MainForm());
                    Application.Run();
                }
                catch
                {
                    errors++;
                    if (errors == 3)
                        break;
                    MessageBox.Show("Непредвиденная ошибка!");
                    continue;
                }
                break;
            }
        }
    }
}
