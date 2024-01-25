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
        public CartDetailsDTO AddCartItems(ProductDTO productDTO, CartDTO cartDTO);
    }
}
