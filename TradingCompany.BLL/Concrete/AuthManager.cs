using DAL.Interfaces;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Concrete
{
    public class AuthManager : IAuthManager
    {
        private readonly IUserDal _userDal;

        public AuthManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public UserDto GetUserById(int id)
        {
            return _userDal.GetUserById(id);
        }

        public UserDto GetUserByLogin(string login)
        {
            return _userDal.GetUserByLogin(login);
        }

        public List<UserDto> GetAllUsers()
        {
            return _userDal.GetAllUsers();
        }

        public bool Login(string login, string password)
        {
            return _userDal.Login(login, password);
        }
    }
}
