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
    public partial class DashboardForm : StockUpForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("InvoiceDashboardForm");

        }

        private void productDashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("ProductDashboardForm");
        }

        private void categoryDashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("CategoryDashboardForm");
        }

        private void customerDashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("CustomerDashboardForm");
        }
    }
}
