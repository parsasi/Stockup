using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StockUpBL.Models;
using StockUpDAL;

namespace StockUp.Forms
{
    public partial class ProductDashboardForm : StockUpForm
    {
        public ProductDashboardForm()
        {
            InitializeComponent();
        }

        private void ProductDashboard_Load(object sender, EventArgs e)
        {
            var dbContext = new AppDbContext();
            var products = dbContext.Products.ToList();
            productsDGV.DataSource = products;
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("DashboardForm");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm("addProductForm");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
