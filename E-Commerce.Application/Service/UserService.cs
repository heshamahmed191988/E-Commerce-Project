using E_Commerce.Application.Contract;
using E_Commerce.Application.Mapping;
using AutoMapper;
using AutoMapper.Configuration;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public class UserService : IUserService
    {
        IUserRepository _userRepository;
        AutoMapping _mapper;
        public UserService(IUserRepository userRepository )
        {
            _userRepository = userRepository;
        }
        public void AddUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAllPagination(int page, int pageSize)
        {
            var U = _userRepository.GetAll().Skip(page * pageSize).Take(pageSize);
             
            return U.Select(i => AutoMapping.MapUserDto(i));
        }

        public UserDTO GetUser(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(UserDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }
}
