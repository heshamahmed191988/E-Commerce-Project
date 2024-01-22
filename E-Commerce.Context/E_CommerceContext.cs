using E_Commerce_Project.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Context
{
    public class E_CommerceContext:DbContext
    {
       // public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
      //  public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<CartDetails> CartDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ECommerce4;Integrated Security=True;Encrypt=False");
        }

    }
}
