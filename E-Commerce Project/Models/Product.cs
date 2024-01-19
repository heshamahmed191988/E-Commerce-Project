 using System;
using System.Collections.Generic;
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
        public int Quantity { get; set; }
        public virtual Category Category { get; set; }
        public virtual IQueryable<OrderDetails> OrderDetails { get; set; }
        //cart details
        public virtual IQueryable<CartDetails> CartDetails { get; set; }

    }
}
