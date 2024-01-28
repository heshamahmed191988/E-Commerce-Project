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
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
        public UserDTO AddUser(UserDTO userDTO)
        {
            _userRepository.Add(AutoMapping.MapUser(userDTO));
            _userRepository.save();
            return userDTO;
        }

        public IQueryable<UserDTO> GetAllPagination(int page, int pageSize)
        {
            var U = _userRepository.GetAll().Skip(page * pageSize).Take(pageSize);
             var r= _mapper.Map<IQueryable<UserDTO>>(U);
            //return U.Select(i => AutoMapping.MapUserDto(i));
            return r;
        }
        public IQueryable<UserDTO> GetAll()
        {
            var U = _userRepository.GetAll();

            return U.Select(i => AutoMapping.MapUserDto(i));
        }
        public UserDTO GetUser(int id)
        {
            if (id != 0)
            {
                var user = AutoMapping.MapUserDto(_userRepository.GetByID(id));
                return user;
            }
            else
                return null;
        }

        public UserDTO GetUser(string username, string pass)
        { 
                
           var user = AutoMapping.MapUserDto(_userRepository.GetUser(username ,pass));
            return user;
             
        }

        public void RemoveUser(UserDTO userDTO)
        {
            _userRepository.Delete(AutoMapping.MapUser(userDTO));
            _userRepository.save();
        }

        public void UpdateUser(UserDTO userDTO)
        {
            _userRepository.Update(AutoMapping.MapUser(userDTO));
            _userRepository.save();
        }
        
    }
}
