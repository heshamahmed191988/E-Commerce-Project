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
    public class OrderItemService:IOrderItemService
    {
        IOrderItemRepository _orderItemService;
        AutoMapping _mapper;
        public OrderItemService(IOrderItemRepository orderItemService)
        {
            _orderItemService = orderItemService;
        }
        public void AddOrderItems(OrderItemDTO orderItemDTO)
        {
            _orderItemService.Add(AutoMapping.MapOrderItem(orderItemDTO));
            _orderItemService.save();
        }
    }
}
