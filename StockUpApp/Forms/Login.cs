using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockUp.Forms
{
    public partial class Login : StockUpForm
    {
        public Login() : base()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var username = usernameTexbox.Text;
            var password = passwordTextbox.Text;
            if(username == "admin" && password == "admin")
            {
                FormNavigator.SwitchForm("DashboardForm");
            }
        }
    }
}
