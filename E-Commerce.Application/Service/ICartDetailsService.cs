using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface ICartDetailsService
    {
        public void AddCartItems(CartDetailsDTO cartDetailsDTO);
        public IQueryable<CartDetailsDTO> GetCartItems();
        public void UpdateCart(CartDetailsDTO cartDetailsDTO);
        public void RemoveProductFromCart(CartDetailsDTO cartDetailsDTO);
        public IQueryable<CartDetailsDTO> getAll(int cartId);
    }
}
