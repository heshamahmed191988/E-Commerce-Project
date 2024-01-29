using AutoMapper;
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
        private readonly IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public void AddProduct(ProductDTO productDTO)
        {
            var AddedData = _mapper.Map<Product>(productDTO);
            var Data = _productRepository.Add(AddedData);
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
            var AddedData = _mapper.Map<Product>(productDTO);

             _productRepository.Delete(AddedData);
            _productRepository.save();
        }

        public void UpdateProduct(ProductDTO productDTO)
        {
            var AddedData = _mapper.Map<Product>(productDTO);

            _productRepository.Update(AddedData);
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
