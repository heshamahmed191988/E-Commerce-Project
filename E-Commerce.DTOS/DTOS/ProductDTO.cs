using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string image { get; set; }

        public int Quantity { get; set; }
        //[ForeignKey("Category")]
        public int categoryID { get; set; }
        public virtual CategoryDTO Category { get; set; }
        public virtual IQueryable<CartDetailsDTO> CartDetails { get; set; }
    }
}
