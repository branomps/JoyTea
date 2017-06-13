using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JoyTea.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("JoyTea")
        {

        }

        public DbSet<Category> Categories { get; set;  }
        public DbSet<Product> Products { get; set; }

    }
}