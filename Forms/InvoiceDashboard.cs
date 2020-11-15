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
    public partial class InvoiceDashboardForm : StockUpForm
    {
        public InvoiceDashboardForm()
        {
            InitializeComponent();
        }

        private void DeleteInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void dashboardInvoiceButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("DashboardForm");
        }
    }
}
