using System;
using System.Windows.Forms;

namespace PharmaShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var frmLogin = new LoginForm();
            var respondLoginForm = frmLogin.ShowDialog();
            if (respondLoginForm == DialogResult.OK)
            {
                Application.Run(new MainServiceForm());
            }
            else if (respondLoginForm == DialogResult.Yes)
            {
                Application.Run(new MainAdminForm());
            }

            return;
        }
    }
}
