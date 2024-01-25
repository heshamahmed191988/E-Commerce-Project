using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class CartDetailsDTO
    {
        public int Id { get; set; }
       // [ForeignKey("CartDTO")]
        public int cartID { get; set; }
       // [ForeignKey("ProductDTO")]
        public int productID { get; set; }
        public Cart? cart { get; set; }
        public Product? Product { get; set; }
    }
}
