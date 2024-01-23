using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.DTOS.DTOS;
using E_Commerce.Infrustructure.Repository;

namespace ConsoleTest
{
    internal class Program
    {
        static IUserService _userService;
        static void Main(string[] args)
        {
            _userService = new UserService(new UserRepository(new E_CommerceContext()));
            UserDTO u1 = new UserDTO()
            { UserName = "Ahmed", Email = "ahmed@mail.com", Address = "sohag", Password = "1234567", type = false };
            //_userService.AddUser(u1);   
         //  var x = _userService.GetUser(1).UserName;
         //   Console.WriteLine(x);
        }
    }
}
