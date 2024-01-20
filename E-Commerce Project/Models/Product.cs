 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int  AvailableQuantity { get; set; }
        
        public virtual Category Category { get; set; }
        //cart details
        public virtual IQueryable<Cart> CartDetails { get; set; }

    }
}
