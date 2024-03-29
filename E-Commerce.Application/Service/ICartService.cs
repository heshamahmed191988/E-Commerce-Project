﻿using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface ICartService
    {
        public void AddCart(CartDTO cartDTO);
        public IQueryable<CartDTO> GetAll();
        public CartDTO GetCart(int id);
        public void UpdateCart(CartDTO cartDTO);
        public void RemoveProductFromCart(CartDTO cartDTO);

    }
}
