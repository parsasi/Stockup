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
using StockUpApp.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace StockUp.Forms
{
    public partial class ProductDashboardForm : StockUpForm
    {
        public ProductDashboardForm()
        {
            InitializeComponent();
            this.InitDB();
        }

        private void ProductDashboard_Load(object sender, EventArgs e)
        {
            var products = this.ListProducts();
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

        private List<ProductViewModel> ListProducts()
        {
            var allProducts = this.DbContext.Products.Include("Category").ToList();
            List<ProductViewModel> allProductsView = allProducts.Select(item => new ProductViewModel(item)).ToList();
            return allProductsView;
        }
    }
}
