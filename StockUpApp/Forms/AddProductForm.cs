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

namespace StockUp.Forms
{
    public partial class addProductForm : StockUpForm
    {
        public addProductForm()
        {
            InitializeComponent();
            this.InitDB();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            var categoeies = this.DbContext.Categories.ToList();
            categoryListBox.DataSource = categoeies;
            categoryListBox.DisplayMember = "Title";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            FormNavigator.CloseForm(this);
        }

        private void quantityEditPlusButton_Click(object sender, EventArgs e)
        {
            int existingNumber;
            try
            {
                existingNumber = int.Parse(quantityAddTextbox.Text);
            }
            catch
            {
                existingNumber = 0;   
            }
            quantityAddTextbox.Text =  (existingNumber + 1).ToString();
        }

        private void quantityEditSubButton_Click(object sender, EventArgs e)
        {
            var existingNumber = int.Parse(quantityAddTextbox.Text);
            if(existingNumber > 0)
            {
                quantityAddTextbox.Text = (existingNumber - 1).ToString();
            }
        }

        private void saveProductButton_Click(object sender, EventArgs e)
        {
            var title = titleTextbox.Text;
            var manufacturer = manufacturerTextbox.Text;
            Category category = (Category)categoryListBox.SelectedItem;
            var description = descriptionTextbox.Text;
            int quantity = int.Parse(quantityAddTextbox.Text);
            double price = double.Parse(priceTextbox.Text);
            addProduct(title, manufacturer, category, price , description, quantity);
        }

        public async void addProduct(string productName, string manufacturer, Category category, double price , string description = "", int quantity = 0)
        {
            var newProduct = new Product();
            newProduct.Title = productName;
            newProduct.Manufacturer = manufacturer;
            newProduct.Quantity = quantity;
            newProduct.Description = description;
            newProduct.Category = category;
            newProduct.UPC = System.Guid.NewGuid().ToString();
            newProduct.LastRecieved = DateTime.Now;
            newProduct.Price = price;
            this.DbContext.Products.Add(newProduct);
            await this.DbContext.SaveChangesAsync();
            FormNavigator.CloseForm("addProductForm");
        }
    }

}
