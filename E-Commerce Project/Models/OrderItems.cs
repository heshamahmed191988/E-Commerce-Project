using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class OrderItems
    {
        public int id {  get; set; }
        [ForeignKey("Product")]
        public int productId { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Product product { get; set; }
        public virtual Order Order { get; set; }
    }
}
