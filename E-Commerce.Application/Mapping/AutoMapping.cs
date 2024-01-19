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
    public static CategoryDTO MapCategoryDTO(Category category)
        {
           if (category == null)
           {
               return null;
           }
           return new CategoryDTO
           { Id = category.Id,
             CategoryName=category.CategoryName,
             Description=category.Description  };
        }
    public static ProductDTO MapProductDTO(Product product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductDTO
            {
                Id = product.Id,
                ProductName=product.ProductName,
                Price=product.Price,
                Quantity=product.Quantity,
                categoryID = product.categoryID
            };
        }

        public static Product MapProduct(ProductDTO productDto)
        {
            if (productDto == null)
            {
                return null;
            }
            return new Product
            {
                Id = productDto.Id,
                ProductName = productDto.ProductName,
                Price = productDto.Price,
                Quantity = productDto.Quantity,
                categoryID = productDto.categoryID
            };
        }
        public static User MapUser(UserDTO userDTO)
        {
            if (userDTO == null)
            {
                return null;
            }
            return new User
            {
                Id = userDTO.Id,
                UserName=userDTO.UserName,
                Email=userDTO.Email,
                Password=userDTO.Password,
                Address=userDTO.Address

            };

        }
    public static Category MapCategory(CategoryDTO categoryDTO)
        {
            if (categoryDTO == null)
            {
                return null;
            }
            return new Category
            {
                Id = categoryDTO.Id,
                CategoryName=categoryDTO.CategoryName,
                Description=categoryDTO.Description
            };

        }

    }
}
