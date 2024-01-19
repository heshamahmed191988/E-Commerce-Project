using E_Commerce.Application.Service;
using E_Commerce.Context;
using E_Commerce.Infrustructure.Repository;

namespace ConsoleTest
{
    internal class Program
    {
        static IUserService _userService;
        static void Main(string[] args)
        {
            _userService = new UserService(new UserRepository(new E_CommerceContext()));
        }
    }
}
