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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // DotNetEnv.Env.Load();
            // string connectionStringEnv = DotNetEnv.Env.GetString("CONNECTION_STRING", "Not Found");
            // System.Diagnostics.Debug.WriteLine(connectionStringEnv);

            // var connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\PARSA\DOCUMENTS\STOCKUP\STOCKUP\STOCKUPDAL\STOCKUPDB.MDF;Integrated Security=True;Connect Timeout=30";
            // optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
