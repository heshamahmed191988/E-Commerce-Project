using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Contract
{
    public interface IProductRepository:Irepository<Product,int>
    {
        public IQueryable<Product> SearchProduct(string item);
        public IQueryable<Product> SearchProductByPrice(decimal item);
    }
}
