using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class OrderItemDTO
    {
        public int id { get; set; }
        public int productId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public ProductDTO product { get; set; }
        public Order Order { get; set; }
    }
}
