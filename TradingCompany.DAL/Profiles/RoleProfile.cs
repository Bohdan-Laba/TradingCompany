﻿using AutoMapper;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}