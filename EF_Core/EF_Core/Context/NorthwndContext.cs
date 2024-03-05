using EF_Core.Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EF_Core.Context
{
    public class NorthwndContext : DbContext
    {
        public NorthwndContext()
        {

        }


        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-N7D463BN\SQLEXPRESS;Database=northwind;Trusted_Connection=True;");
        }
    }
}
