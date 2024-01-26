using E_Commerce.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Application.Service
{
    public interface IOrderService
    {
     public IQueryable<OrderDTO> GetAll();
        public void AddOrder(OrderDTO orderDTO);
        public void UpdateOrder(OrderDTO orderDTO);
        public void RemoveOrder(OrderDTO orderDTO);
        public  OrderDTO GetOrder(int id);
    }
}
