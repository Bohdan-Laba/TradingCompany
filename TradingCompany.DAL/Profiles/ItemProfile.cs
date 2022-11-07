using AutoMapper;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace TradingCompany.DAL.Profiles

{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, ItemDto>().ReverseMap();
        }
    }
}