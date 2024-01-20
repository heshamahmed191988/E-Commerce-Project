using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        //[ForeignKey("User")]
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
