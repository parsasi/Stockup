using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockUpBL.Models;

namespace StockUpApp.ViewModels
{
    class CustomerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DOB { get; set; }

        public CustomerViewModel(Customer customer)
        {
            this.Id = customer.Id;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.Phone = customer.Phone;
            this.Email = customer.Email;
            this.DOB = customer.DOB.ToString();
        }
    }
}
