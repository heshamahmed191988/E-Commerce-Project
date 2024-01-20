using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class CartItemDTO
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public long ProductId { get; set; }
        public ProductDTO Product { get; set; }
        //cart details
        public virtual IEnumerable<CartDTO>? CartDetails { get; set; }

    }
}
