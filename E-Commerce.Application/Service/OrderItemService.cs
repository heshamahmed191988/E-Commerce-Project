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
    public class OrderItemService:IOrderItemService
    {
        IOrderItemRepository _orderItemService;
        IMapper _mapper;
        public OrderItemService(IOrderItemRepository orderItemService, IMapper mapper)
        {
            _orderItemService = orderItemService;
            _mapper = mapper;
        }
        public void AddOrderItems(OrderItemDTO orderItemDTO)
        {
            _orderItemService.Add(AutoMapping.MapOrderItem(orderItemDTO));
            _orderItemService.save();
        }
    }
}
