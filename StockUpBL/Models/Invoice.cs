using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockUpBL.Models
{
    class Invoice
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public double Total { get; set; }
        public int Discount { get; set; }
        public List<Product> Products { get; set; }
    }
}
