using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class CartDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; }
        public string Status { get; set; }
        public virtual User User { get; set; }
        //cart details
        public virtual IQueryable<CartDetailsDTO> CartDetails { get; set; }
    }
}
