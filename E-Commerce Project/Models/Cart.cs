using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public ICollection <CartItem> cart { get; set; }
    }
}
