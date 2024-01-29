using AutoMapper;
using E_Commerce.Application.Contract;
using E_Commerce.Application.Mapping;
using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public class CartDetailsService : ICartDetailsService
    {
        ICartDetailsRepository _cartDetailsRepository;
        private readonly IMapper _mapper;
        public CartDetailsService(ICartDetailsRepository cartDetailsRepository,IMapper mapper)
        {
            _cartDetailsRepository = cartDetailsRepository;
            _mapper = mapper;
        }
        public void AddCartItems(CartDetailsDTO cartDetailsDTO)
        {
            _cartDetailsRepository.Add(AutoMapping.MapCartDetails(cartDetailsDTO));
            _cartDetailsRepository.save();
        }
        public IQueryable<CartDetailsDTO> GetCartItems()
        {
            var C = _cartDetailsRepository.GetAll();

            return C.Select(i => AutoMapping.MapCartDetailsDTO(i));
        }

        public void RemoveProductFromCart(CartDetailsDTO cartDetailsDTO)
        {
            _cartDetailsRepository.Delete(AutoMapping.MapCartDetails(cartDetailsDTO));
            _cartDetailsRepository.save();
        }

        public void UpdateCart(CartDetailsDTO cartDetailsDTO)
        {
            _cartDetailsRepository.Update(AutoMapping.MapCartDetails(cartDetailsDTO));
            _cartDetailsRepository.save();
        }
        public IQueryable<CartDetailsDTO> getAll(int cartId)
        {
            var C = _cartDetailsRepository.GetAll().Where(i=>i.cartID==cartId);

            return C.Select(i => AutoMapping.MapCartDetailsDTO(i));
        }
    }
}
