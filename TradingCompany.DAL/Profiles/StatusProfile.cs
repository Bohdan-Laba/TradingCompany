using AutoMapper;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class StatusProfile : Profile
    {
        public StatusProfile()
        {
            CreateMap<Status, StatusDto>().ReverseMap();
        }
    }
}