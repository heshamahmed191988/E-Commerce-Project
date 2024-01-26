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
    public class ProductRepository : Repository<Product, int>, IProductRepository
    {
        E_CommerceContext context;
        public ProductRepository(E_CommerceContext _context) : base(_context) { context = _context; }
        public IQueryable<Product> SearchProduct(string item)
        {
            var products = context.Products.Where(i=>i.ProductName==item);
            return products; 
        }
        public IQueryable<Product> SearchProductByPrice(decimal item)
        {
            var products = context.Products.Where(i => i.Price == item);
            return products;
        }
    }
    }
