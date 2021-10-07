using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace INvasjonNorge.API.Models
{
    public class ShopContext : DbContext
    {

        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(c => c.Companies).WithOne(a => a.Category).HasForeignKey(a => a.CategoryId);


            modelBuilder.Seed();
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Category> Categories { get; set; }


    }
}

