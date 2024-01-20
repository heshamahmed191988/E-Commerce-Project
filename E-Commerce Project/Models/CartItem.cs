using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public long ProductId {  get; set; }
        public Product Product { get; set; }
        //cart details
        public virtual IEnumerable<Cart>? Carts { get; set; }

    }
}
