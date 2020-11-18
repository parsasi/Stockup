using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockUpBL.Models
{
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
    }
}
