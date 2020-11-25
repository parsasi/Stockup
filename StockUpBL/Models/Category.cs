using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using StockUpBL;

namespace StockUpBL.Models
{
    public class Category 
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Code { get; set; }
    }
}
