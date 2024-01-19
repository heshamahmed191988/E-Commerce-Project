using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface IProductService
    {
        public IQueryable<ProductDTO> GetAllPagination(int page, int pageSize);
        public ProductDTO GetProduct(int id);
        public void AddProduct(ProductDTO productDTO);
        public void UpdateProduct(ProductDTO productDTO);
        public void RemoveProduct(ProductDTO productDTO);
    }
}
