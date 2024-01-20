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
            CreateMap<User, UserDTO>().ReverseMap();

        }

    
    }
}
