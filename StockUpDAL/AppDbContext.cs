using System;
using Microsoft.EntityFrameworkCore;
using StockUpBL.Models;


namespace StockUpDAL 
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Invoice> Invoices { get; set; } 

        

    }
}
