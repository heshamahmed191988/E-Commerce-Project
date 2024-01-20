using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class CartDetails
    {
        public int Id { get; set; }
        [ForeignKey("Cart")]
        public int cartID { get; set; }
        [ForeignKey("Product")]
        public int productID { get; set; }
        public Cart cart { get; set; }
        public Product Product { get; set; }
    }
}
