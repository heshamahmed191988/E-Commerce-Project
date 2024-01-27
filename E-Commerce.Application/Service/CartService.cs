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
    public class CartService:ICartService
    {
        ICartRepository _cartRepository;
        
        public CartService(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }
        public void AddCart(CartDTO cartDTO)
        {
            _cartRepository.Add(AutoMapping.MapCart(cartDTO));
            _cartRepository.save();
        }

        public CartDTO GetCart(int id)
        {
            if (id != 0)
            {
                var c = AutoMapping.MapCartDTO(_cartRepository.GetByID(id));
                return c;
            }
            else
                return null;
        }

        public IQueryable<CartDTO> GetAll()
        {
            var C = _cartRepository.GetAll();

            return C.Select(i => AutoMapping.MapCartDTO(i));
        }

        public void UpdateCart(CartDTO cartDTO)
        {
            _cartRepository.Update(AutoMapping.MapCart(cartDTO));
            _cartRepository.save();
        }

        public void RemoveProductFromCart(CartDTO cartDTO)
        {
            _cartRepository.Delete(AutoMapping.MapCart(cartDTO));
            _cartRepository.save();
        }
    }  
}

