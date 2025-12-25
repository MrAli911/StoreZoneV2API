using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using StoreZoneV2API.Domain.Entities;

namespace StoreZoneV2API.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    
        public DbSet<Product> Products => Set<Product>(); // same as : public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(builder =>
            {
                builder.HasKey(p=>p.Id);
                builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
                builder.Property(n => n.Price).IsRequired().HasPrecision(18, 2);
            });
        }
    }
}
