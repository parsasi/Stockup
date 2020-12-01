using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StockUpBL.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string UPC { get; set; }
        public string Manufacturer { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        public string Description { get; set; }
        [Required]
        public Category Category { get; set; }
        public DateTime LastRecieved { get; set; }

    }
}
