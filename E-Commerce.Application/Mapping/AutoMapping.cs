using AutoMapper;
using AutoMapper.Configuration;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Mapping
{
    public class AutoMapping:Profile
    {
        public AutoMapping(){
           // CreateMap<UserDTO, User>().ReverseMap();
        }

    public static UserDTO MapUserDto(User user)
            {
                if (user == null)
                {
                    return null;
                }
                return new UserDTO
                { Id = user.Id, UserName=user.UserName,Email=user.Email,Password=user.Password,Address=user.Address };
            }
    public static CategoryDTO MapCatDTO(Category category)
        {
           if (category == null)
           {
               return null;
           }
           return new CategoryDTO
           { Id = category.Id, CategoryName=category.CategoryName,Description=category.Description  };
        }

    }
}
