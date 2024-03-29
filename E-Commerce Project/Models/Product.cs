﻿ using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
       // public int Price { get; set; }
        public string image { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public int categoryID { get; set; }
        
        public virtual Category category { get; set; }
        public virtual IQueryable<OrderItems> OrderItems { get; set; }
        //cart details
        public virtual IQueryable<CartDetails> CartDetails { get; set; }

    }
}
