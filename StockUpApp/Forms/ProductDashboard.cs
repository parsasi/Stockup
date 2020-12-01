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
            FillProductsDGV();
            this.FillCategoryEditListbox();
        }

        private void FillProductsDGV(List<ProductViewModel> products)
        {
            productsDGV.DataSource = products;
        }

        private void FillProductsDGV()
        {
            var products = this.ListProducts();
            FillProductsDGV(products);
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

        private List<ProductViewModel> ListProducts(string SearchTerm)
        {
            var allProducts = this.DbContext.Products.Include("Category").ToList();
            List<ProductViewModel> allProductsView = allProducts.Select(item => new ProductViewModel(item)).Where(item => item.Title.Contains(SearchTerm)).ToList();
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
            priceLabel.Text = this.SelectedProduct.Price.ToString();
        }
        private void UpdateEditDetails()
        {
            titleEditTextbox.Text = this.SelectedProduct.Title;
            manufacturerEditTextbox.Text = this.SelectedProduct.Manufacturer;
            quantityEditTextbox.Text = this.SelectedProduct.Quantity.ToString();
            descriptionEditTextbox.Text = this.SelectedProduct.Description;
            priceEditTextbox.Text = this.SelectedProduct.Price.ToString();
            categoryEditListBox.SelectedIndex = this.GetCategoryIndex(this.SelectedProduct.Category);
        }

        private int GetCategoryIndex(Category category)
        {
            var allCategories = categoryEditListBox.Items;

            for(int i = 0; i <= allCategories.Count; i++)
            {
                if(allCategories[i].Equals(category))
                {
                    return i;
                }
            }
            return -1;
        }

        private void FillCategoryEditListbox()
        {
            var categoeies = this.DbContext.Categories.ToList();
            categoryEditListBox.DataSource = categoeies;
            categoryEditListBox.DisplayMember = "Title";
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if(this.SelectedProduct != null)
            {
                this.DeleteProduct(this.SelectedProduct);
                this.SelectedProduct = null;
            }
        }

        private async void DeleteProduct(Product product)
        {
            this.DbContext.Remove(product);
            await this.DbContext.SaveChangesAsync();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var productName = titleEditTextbox.Text;
            var manufacturer = manufacturerEditTextbox.Text;
            Category category = (Category)categoryEditListBox.SelectedItem;
            double price = double.Parse(priceEditTextbox.Text);
            var description = descriptionEditTextbox.Text;
            int quantity = int.Parse(quantityEditTextbox.Text);

            EditProduct(productName, manufacturer, category, price, description, quantity);

        }

        private async void EditProduct(string productName, string manufacturer, Category category, double price, string description = "", int quantity = 0)
        {
            if(this.SelectedProduct != null)
            {
                var product = this.GetProduct(this.SelectedProduct.UPC);
                product.Title = productName;
                product.Manufacturer = manufacturer;
                product.Category = category;
                product.Price = price;
                product.Description = description;
                product.Quantity = quantity;
                await this.DbContext.SaveChangesAsync();
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string searchTerm = productSearchTextbox.Text;

            List<ProductViewModel> productList;

            if(searchTerm != "" && searchTerm != null)
            {
                productList = this.ListProducts(searchTerm);
                FillProductsDGV(productList);
            }
            else
            {
                productList  = this.ListProducts();
            }
            FillProductsDGV(productList);
        }
    }
}
