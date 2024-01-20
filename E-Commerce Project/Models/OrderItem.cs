using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class OrderItem
    {
        public long Id { get; set;}
        public int Quantity { get; set;}
        public decimal Price { get; set;}

        public Product Product { get; set;}

    }
}
