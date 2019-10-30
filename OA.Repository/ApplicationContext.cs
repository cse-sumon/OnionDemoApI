using Microsoft.EntityFrameworkCore;
using OA.Data;

using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public ApplicationContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new ProductMap(modelBuilder.Entity<Product>());
        }
        public DbSet<Course> Courses { get; set; }
        //public DbSet<Product> Products { get; set; }
    }
}
