using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Context
{
    public class E_CommerceContext : DbContext
    {
        // public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
          public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<CartDetails> CartDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DELL-PC\\SQLEXPRESS;Initial Catalog=EC-Last;Integrated Security=True;Encrypt=False");//.UseLazyLoadingProxies();
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(Entity =>
            {
                Entity.HasKey(I => I.Id);

                Entity.Property(i => i.UserName)
                    .HasMaxLength(50).IsRequired(false);
                Entity.Property(i => i.type)
                    .HasDefaultValue(0);
               

            });
        }
    }
}
