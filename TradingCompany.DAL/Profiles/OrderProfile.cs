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
            CreateMap<Order, OrderDto>().ReverseMap();
        }
    }
}
