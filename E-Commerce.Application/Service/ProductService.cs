using E_Commerce.Application.Contract;
using E_Commerce.Application.Mapping;
using E_Commerce.DTOS.DTOS;
using E_Commerce_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
       // AutoMapping _mapper;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void AddProduct(ProductDTO productDTO)
        {
           _productRepository.Add(AutoMapping.MapProduct(productDTO));
            _productRepository.save();
        }

        public IQueryable<ProductDTO> GetAll()
        {
            var p = _productRepository.GetAll();

            return p.Select(i => AutoMapping.MapProductDTO(i));
        }

        public ProductDTO GetProduct(int id)
        {
            if (id != 0)
            {
                var p = AutoMapping.MapProductDTO(_productRepository.GetByID(id));
                return p;
            }
            else
                return null;
        }

        public void RemoveProduct(ProductDTO productDTO)
        {
            _productRepository.Delete(AutoMapping.MapProduct(productDTO));
            _productRepository.save();
        }

        public void UpdateProduct(ProductDTO productDTO)
        {
            _productRepository.Update(AutoMapping.MapProduct(productDTO));
            _productRepository.save();
        }
        public IQueryable<ProductDTO> SearchProduct(string item)
        {
            if (item != null)
            {
                var p = _productRepository.SearchProduct(item);

                return p.Select(i => AutoMapping.MapProductDTO(i));
            }
            else
                return null;

        }
        public IQueryable<ProductDTO> SearchProductByPrice(decimal item)
        {
            if (item != 0)
            {
                var p = _productRepository.SearchProductByPrice(item);

                return p.Select(i => AutoMapping.MapProductDTO(i));
            }
            else
                return null;
        }
    }
}
