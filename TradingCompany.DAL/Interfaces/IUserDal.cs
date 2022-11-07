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
        void UpdateUser(UserDto user);
        //void UpdateRoles(string login, List<string> roles);????
        void DeleteUser(int id);
        bool Login(string login, string password);
    }
}
