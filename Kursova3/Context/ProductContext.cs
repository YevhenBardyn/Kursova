using Kursova3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Kursova3.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("MainContext")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}