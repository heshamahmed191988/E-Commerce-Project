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
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public int type { get; set; }
        public IQueryable<Order>? orders { get; set; }
        public virtual Cart? Cart { get; set; }

      /*  public enum UserType:short
        {
            admin=0 ,
            customer=1 
        }*/
       /* public static int userTypeInt(UserType x)
        {
            int y = (int)x;
            return y;
        }*/
    }
}
