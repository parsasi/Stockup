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
        private Product SelectedProduct { get; set; }
        public ProductDashboardForm()
        {
            InitializeComponent();
            this.InitDB();
        }

        private void ProductDashboard_Load(object sender, EventArgs e)
        {
            var products = this.ListProducts();
            productsDGV.DataSource = products;
            this.FillCategoryEditListbox();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("DashboardForm");
        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm("addProductForm");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                //Gets the row number of the selected cell
                var row = productsDGV.CurrentCell.RowIndex;
                //Gets the value of the first cell, for that row number
                //This value will be the UPC of the prodcut 
                string UPC = productsDGV.Rows[row].Cells[0].Value.ToString();
                
                //Updates the selected product of the form using the UPC
                this.UpdateSelectedProduct(UPC);
                //Updates the details and textbox values shown on the right side of the form
                this.UpdateDetails();
                this.UpdateEditDetails();
            }
            catch
            {
                //Silently Fail 
            } 
            
        }

        private List<ProductViewModel> ListProducts()
        {
            var allProducts = this.DbContext.Products.Include("Category").ToList();
            List<ProductViewModel> allProductsView = allProducts.Select(item => new ProductViewModel(item)).ToList();
            return allProductsView;
        }

        private Product GetProduct(string UPC)
        {
            var product = this.DbContext.Products.Include("Category").Where(item => item.UPC == UPC).SingleOrDefault();
            return product;
        }
        private void UpdateSelectedProduct(string UPC)
        {
            var product = this.GetProduct(UPC);
            this.SelectedProduct = product;
        }
        private void UpdateDetails()
        {
            manufacturerLabel.Text = this.SelectedProduct.Manufacturer;
            productNameLabel.Text = this.SelectedProduct.Title;
            lastRecievedLabel.Text = this.SelectedProduct.LastRecieved.ToString("MMMM dd, yyyy");
            inStockLabel.Text = this.SelectedProduct.Quantity.ToString();
            categoryLabel.Text = this.SelectedProduct.Category.Title;
            descriptionLabel.Text = this.SelectedProduct.Description;
        }
        private void UpdateEditDetails()
        {
            titleEditTextbox.Text = this.SelectedProduct.Title;
            manufacturerEditTextbox.Text = this.SelectedProduct.Manufacturer;
            quantityEditTextbox.Text = this.SelectedProduct.Quantity.ToString();
            descriptionEditTextbox.Text = this.SelectedProduct.Description;
        }

        private void FillCategoryEditListbox()
        {
            var categoeies = this.DbContext.Categories.ToList();
            categoryEditListBox.DataSource = categoeies;
            categoryEditListBox.DisplayMember = "Title";
        }
    }
}
