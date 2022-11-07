using AutoMapper;
using System;
using System.Linq;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Item, ItemDto>();

            CreateMap<OrderItem, OrderItemDto>();

            //Idk how to map from Order to OrderDto correctly
            CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.OrderedItem,
                s => s.MapFrom(r => r.OrderItems.Select(o => o.OrderID))
                );

            CreateMap<OrderDto, Order>()
                .ForMember(dest => dest.OrderItems,
                s => s.MapFrom(o => o.OrderedItem.Select(p => new OrderItem
                {
                    OrderID = o.OrderID,
                    ItemID = p.ItemID,
                    Quantity = p.Quantity,
                    RowInsertTime = DateTime.UtcNow
                })));

            //CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
