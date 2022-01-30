#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Deliverycart2.Models;

    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Deliverycart2.Models.Order> Order { get; set; }
        public DbSet<Deliverycart2.Models.Vendor> Vendor { get; set; }
        public DbSet<Deliverycart2.Models.Manager> Manager { get; set; }
        public DbSet<Deliverycart2.Models.Shopper> Shopper { get; set; }
    }
