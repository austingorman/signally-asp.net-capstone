using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Signally.Models;

namespace Signally.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<CSR> CSR { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Status> Status { get; set; }
        public DbSet<Models.Type> Type { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            modelBuilder.Entity<Order>()
                .Property(o => o.DatePlaced)
                .HasDefaultValueSql("GETDATE()");

            modelBuilder.Entity<Order>()
                .Property(o => o.DateDue)
                .HasDefaultValueSql("GETDATE()");

            //Restrict deletion of related order when OrderProducts entry is removed
           modelBuilder.Entity<Customer>()
               .HasMany(o => o.Order)
               .WithOne(l => l.Customer)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Order>()
                 .HasMany(o => o.OrderItem)
                 .WithOne(l => l.Order)
                 .OnDelete(DeleteBehavior.Cascade);

            IdentityUser user = new IdentityUser
            {
                Email = "110@signs.com",
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString("D")
            };
            var passwordHash = new PasswordHasher<IdentityUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Admin8*");
            modelBuilder.Entity<IdentityUser>().HasData(user);


            modelBuilder.Entity<CSR>().HasData(
               new CSR()
                {
                   CSRId = 1,
                   FirstName = "Walt",
                   LastName = "Bergey"
               },
               new CSR()
               {
                   CSRId = 2,
                   FirstName = "Hailey",
                   LastName = "Welker"
               }
           );
            modelBuilder.Entity<Status>().HasData(
                new Status()
                {
                    StatusId = 1,
                    StatusName = "Estimate",
                },
                new Status()
                {
                    StatusId = 2,
                    StatusName = "Order",
                },
                new Status()
                {
                    StatusId = 3,
                    StatusName = "Built",
                },
                new Status()
                {
                    StatusId = 4,
                    StatusName = "Picked-Up",
                }
            );

            modelBuilder.Entity<Models.Type>().HasData(
               new Models.Type()
               {
                   TypeId = 1,
                   TypeName = "Vinyl Letters",
                   PricePerUnit = (decimal)3.00
               },
               new Models.Type()
               {
                   TypeId = 2,
                   TypeName = "Coroplast",
                   PricePerUnit = (decimal)0.10
               },
               new Models.Type()
               {
                   TypeId = 3,
                   TypeName = "Aluminum",
                   PricePerUnit = (decimal)0.20
               },
               new Models.Type()
               {
                   TypeId = 4,
                   TypeName = "Banner",
                   PricePerUnit = (decimal)0.15
               }
           );
        }
    }
}
