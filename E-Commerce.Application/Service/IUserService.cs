using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface IUserService
    {
        public IQueryable<UserDTO> GetAllPagination(int page, int pageSize);
        public IQueryable<UserDTO> GetAll();
       //public UserDTO GetUser(int id);
        public UserDTO GetUser(string username, string pass);
        public void AddUser(UserDTO userDTO);
        public void UpdateUser(UserDTO userDTO);
        public void RemoveUser(UserDTO userDTO);
        
    }
}
