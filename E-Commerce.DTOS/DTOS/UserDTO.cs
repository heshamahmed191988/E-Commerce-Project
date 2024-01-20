using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DTOS.DTOS
{
    public class UserDTO
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public UserType Type { get; set; }
        public ICollection<OrderDTO>? Orders { get; set; }
        public virtual ICollection<CartItemDTO> Carts { get; set; }
    }
   
}
