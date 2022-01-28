using System;
using Microsoft.EntityFrameworkCore;

namespace Deliverycart.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Billing> Billing {get; set;}
        public DbSet<Customer> Customer{get; set;}
        public DbSet<Item> Item {get; set;}
        public DbSet<Manager> Manager {get; set;}
        public DbSet<Order> Order{get; set;}
        public DbSet<Shopper> Shopper {get; set;}
        public DbSet<User> User {get; set;}
        public DbSet<Vendor> Vendor {get; set;}
    }
}