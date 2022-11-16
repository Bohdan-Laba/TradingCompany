using AutoMapper;
using System;
using System.Linq;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Role, RoleDto>();

            CreateMap<User, UserDto>()
                .ForMember(dest => dest.Roles,
                s => s.MapFrom(u => u.UserRoles.Select(ur => ur.Role)));

            CreateMap<UserDto, User>()
                .ForMember(dest => dest.UserRoles,
                s => s.MapFrom(u => u.Roles.Select(p => new UserRole
                {
                    UserID = u.UserID,
                    RoleID = p.RoleID,
                    RowInsertTime = DateTime.UtcNow
                })));
        }
    }
}