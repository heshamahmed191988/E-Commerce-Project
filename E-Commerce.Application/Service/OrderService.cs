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
    public class OrderService:IOrderService
    { 
      IOrderRepository _orderRepository;

         IMapper _mapper;
        public OrderService(IOrderRepository OrderRepository, IMapper mapper)
        {
            _orderRepository = OrderRepository;
            _mapper = mapper;
        }
        public void AddOrder(OrderDTO orderDTO)
        {
            _orderRepository.Add(AutoMapping.MapOrder(orderDTO));
            _orderRepository.save();
        }




        public IQueryable<OrderDTO> GetAll()
        {
            var p = _orderRepository.GetAll();

            return p.Select(i => AutoMapping.MapOrderDTO(i));
        }

       

        public void RemoveOrder(OrderDTO orderDTO)
        {
            _orderRepository.Delete(AutoMapping.MapOrder(orderDTO));
            _orderRepository.save();
        }

        public void UpdateOrder(OrderDTO orderDTO)
        {
            _orderRepository.Update(AutoMapping.MapOrder(orderDTO));
            _orderRepository.save();
        }
        public OrderDTO GetOrder(int id)
        {

            if (id != 0)
            {
                var p = AutoMapping.MapOrderDTO(_orderRepository.GetByID(id));
                return p;
            }
            else
                return null;
        }
    }
    
}
