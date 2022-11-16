using System.Collections.Generic;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IAuthManager
    {
        bool Login(string login, string password);
        UserDto GetUserByLogin(string login);
        UserDto GetUserById(int id);
        List<UserDto> GetAllUsers();
    }
}
