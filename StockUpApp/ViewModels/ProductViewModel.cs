using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockUpBL.Models;

namespace StockUpApp.ViewModels
{
    class ProductViewModel
    {
        public string UPC { get; set; }
        public string Title { get; set; }
        public string Manufacturer { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        public double Price { get; set; }


        public ProductViewModel(Product product) 
        {
            this.Title = product.Title;
            this.Manufacturer = product.Manufacturer;
            this.Description = product.Description;
            this.Category = product.Category.Title;
            this.Quantity = product.Quantity;
            this.UPC = product.UPC;
            this.Price = product.Price;
        }
    }
}
