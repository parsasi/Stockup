using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockUp.Forms;

namespace StockUp
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
            var loginForm = new Login();
            FormNavigator.currentForm = loginForm;
            FormNavigator.forms = new List<StockUpForm> { loginForm, new InvoiceDashboardForm(), new DashboardForm() , new ProductDashboardForm() , new addProductForm() };
            Application.Run(loginForm);
        }
    }
}
