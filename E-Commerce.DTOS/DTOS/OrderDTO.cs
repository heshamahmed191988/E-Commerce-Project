using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int NoOfProducts { get; set; }
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }

        //Order details
       // public virtual IQueryable<OrderDetails> OrderDetails { get; set; }
    }
}
