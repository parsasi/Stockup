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
    public partial class CustomerDashboardForm : StockUpForm
    {
        private Customer SelectedCustomer { get; set; }

        public CustomerDashboardForm()
        {
            InitializeComponent();
            this.InitDB();
        }


        private void FillCustomersDGV(List<CustomerViewModel> customers)
        {
            customersDGV.DataSource = customers;
        }

        private void FillCustomersDGV()
        {
            var customers = this.ListCustomers();
            FillCustomersDGV(customers);
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            FormNavigator.SwitchForm("DashboardForm");
        }

        private void addFormButton_Click(object sender, EventArgs e)
        {
            FormNavigator.OpenForm("addCustomerForm");
        }

        private List<CustomerViewModel> ListCustomers()
        {
            var allCustomers = this.DbContext.Customers.ToList();
            List<CustomerViewModel> allCustomersView = allCustomers.Select(item => new CustomerViewModel(item)).ToList();
            return allCustomersView;
        }

        private List<CustomerViewModel> ListCustomers(string SearchTerm)
        {
            var allCustomers = this.DbContext.Customers.ToList();
            List<CustomerViewModel> allCustomersView = allCustomers.Select(item => new CustomerViewModel(item)).Where(item => item.FirstName.Contains(SearchTerm)).ToList();
            return allCustomersView;
        }

        private Customer GetCustomer(int Id)
        {
            var customer = this.DbContext.Customers.Where(item => item.Id == Id).SingleOrDefault();
            return customer;
        }
        private void UpdateSelectedCustomer(int Id)
        {
            var customer = this.GetCustomer(Id);
            this.SelectedCustomer = customer;
        }
        private void UpdateDetails()
        {
            firstNameLabel.Text = this.SelectedCustomer.FirstName;
            lastNameLabel.Text = this.SelectedCustomer.LastName;
            phoneLabel.Text = this.SelectedCustomer.Phone;
            emailLabel.Text = this.SelectedCustomer.Email;
            dobLabel.Text = this.SelectedCustomer.DOB.ToString();
        }
        private void UpdateEditDetails()
        {
            firstNameLabel.Text = this.SelectedCustomer.FirstName;
            lastNameLabel.Text = this.SelectedCustomer.LastName;
            phoneLabel.Text = this.SelectedCustomer.Phone;
            emailLabel.Text = this.SelectedCustomer.Email;
            dobLabel.Text = this.SelectedCustomer.DOB.ToString();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (this.SelectedCustomer != null)
            {
                this.DeleteProduct(this.SelectedCustomer);
                this.SelectedCustomer = null;
            }
        }

        private async void DeleteProduct(Customer customer)
        {
            this.DbContext.Remove(customer);
            await this.DbContext.SaveChangesAsync();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string searchTerm = productSearchTextbox.Text;

            List<CustomerViewModel> customerList;

            if (searchTerm != "" && searchTerm != null)
            {
                customerList = this.ListCustomers(searchTerm);
                FillCustomersDGV(customerList);
            }
            else
            {
                customerList = this.ListCustomers();
            }
            FillCustomersDGV(customerList);
        }

        private void CustomerDashboardForm_Load(object sender, EventArgs e)
        {
            FillCustomersDGV();
        }

        private void customersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
                //Gets the row number of the selected cell
                var row = customersDGV.CurrentCell.RowIndex;
                //Gets the value of the first cell, for that row number
                //This value will be the UPC of the prodcut 
                int Id = int.Parse(customersDGV.Rows[row].Cells[0].Value.ToString());

                //Updates the selected product of the form using the UPC
                this.UpdateSelectedCustomer(Id);
                //Updates the details and textbox values shown on the right side of the form
                this.UpdateDetails();
                this.UpdateEditDetails();
            
        }
    }
}
