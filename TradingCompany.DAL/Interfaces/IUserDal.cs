using System.Collections.Generic;
using TradingCompany.DTO;

namespace DAL.Interfaces
{
    public interface IUserDal
    {
        List<UserDto> GetAllUsers();
        UserDto CreateUser(string login, string email, string password, List<RoleDto> roles);
        UserDto GetUserById(int id);
        UserDto GetUserByLogin(string login);
        UserDto UpdateUser(int id, string login, string email, string password, List<RoleDto> roles);
        //void UpdateRoles(UserDto user, List<RoleDto> roles);
        void DeleteUser(int id);
        bool Login(string login, string password);
    }
}
