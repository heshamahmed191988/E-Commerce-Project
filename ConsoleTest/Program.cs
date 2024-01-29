using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Infrustructure.Repository;

namespace ConsoleTest
{
    internal class Program
    {
        static IUserService _userService;
        static IProductService _productService;
        static ICategoryService _categoryService;
        static void Main(string[] args)
        {
           // var container = AutoFact.Inject();

            UserDTO u1 = new UserDTO()
            { UserName = "Ahmed", Email = "ahmed@mail.com", Address = "sohag", Password = "1234567", type = 1 };
            _userService.AddUser(u1);   
        }
    }
}
