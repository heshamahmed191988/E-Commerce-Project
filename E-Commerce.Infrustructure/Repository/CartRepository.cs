using E_Commerce.Application.Contract;
using E_Commerce.Context;
using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrustructure.Repository
{
    public class CartRepository:Repository<Cart,int>,ICartRepository
    {
        E_CommerceContext context;
        public CartRepository(E_CommerceContext _context) : base(_context) { context = _context; }

    }
}
