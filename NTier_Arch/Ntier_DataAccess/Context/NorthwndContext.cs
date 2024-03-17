using Microsoft.EntityFrameworkCore;
using NtierModel.Models.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ntier_DataAccess.Context
{
    public class NorthwndContext :DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAB8-OGRETMEN\SQLEXPRESS;Database=NORTHWND;Trusted_Connection=True;");
        }
    }
}
