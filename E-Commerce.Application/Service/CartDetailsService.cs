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
    public class CartDetailsService:ICartDetailsService
    {
        ICartDetailsRepository _cartDetailsRepository;

        public CartDetailsService(ICartDetailsRepository cartDetailsRepository)
        {
            _cartDetailsRepository = cartDetailsRepository;
        }
      /*  public CartDetailsDTO AddCartItems(ProductDTO productDTO, CartDTO cartDTO)
        {
            CartDetailsDTO cartDetailsDTO = new CartDetailsDTO() { cartID = cartDTO.Id, productID = productDTO.Id };
            _cartDetailsRepository.Add(AutoMapping.MapCartDetails(cartDetailsDTO));
            _cartDetailsRepository.save();
            return cartDetailsDTO;
        }*/

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
    }
}
