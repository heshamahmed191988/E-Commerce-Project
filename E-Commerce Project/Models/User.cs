using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Project.Models
{
    public class User
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public UserType Type { get; set; }
        public ICollection<Order>? Orders { get; set; }
        public virtual ICollection <CartItem> Carts { get; set; }
    }
    public enum UserType
    {
        admin=1,
        customer=2
    }
}
