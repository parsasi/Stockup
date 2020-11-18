using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace StockUpBL.Models
{
    class Product
    {
        public int Id { get; set; }
        [Required]
        public string UPC { get; set; }
        public string Manufacturer { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Quantity { get; set; }
        public int Description { get; set; }
        [Required]
        public Category Category { get; set; }
        public DateTime LastRecieved { get; set; }
    }
}
