using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace E_Commerce_Project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate  { get; set; }
        public int NoOfProducts { get; set; }
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        public virtual User User { get; set; }

        //Order details
        public virtual IQueryable<OrderDetails> OrderDetails { get; set; }
    }
}
