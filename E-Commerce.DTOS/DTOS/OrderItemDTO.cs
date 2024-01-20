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
        [ForeignKey("Product")]
        public int productId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Product product { get; set; }
        public Order Order { get; set; }
    }
}
