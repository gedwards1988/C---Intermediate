using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared
{
    // manage connection to database
    public class Northwind : DbContext
    {

        // map tables to database
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }    

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            string connection = "Data Source=LAPTOP-GE;Initial Catalog=Northwind;Integrated Security=true;MultipleActiveResultSets=true;";

            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(Category => Category.CategoryName)
                .IsRequired()
                .HasMaxLength(15);
        }


    }


}
