using AutoMapper;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using TradingCompany.DAL;
using TradingCompany.DTO;

namespace DAL.Concrete
{
    public class UserDal : IUserDal
    {
        private readonly IMapper _mapper;

        public UserDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserDto CreateUser(string login, string email, string password, List<RoleDto> roles)
        {
            using (var entities = new TradingCompanyEntities())
            {
                if (entities.Users.Any(usr => usr.Login == login))
                {
                    throw new Exception("This login is already taken!");
                }

                Guid salt = Guid.NewGuid();
                var user = new User
                {
                    Login = login,
                    Email = email,
                    Password = hash(password, salt.ToString()),
                    Salt = salt,
                    RowInsertTime = DateTime.UtcNow,
                    RowUpdateTime = DateTime.UtcNow
                };

                entities.Users.Add(user);
                entities.SaveChanges();

                return _mapper.Map<UserDto>(user);
            }
        }

        public void DeleteUser(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var userf = entities.Users/*.Include(db => db.UserRoles.Select(c=>c.Role))*/
                    .SingleOrDefault(obj => obj.UserID == id);
                if (userf != null)
                {
                    entities.Users.Remove(userf);
                    entities.SaveChanges();
                }
            }
        }

        public List<UserDto> GetAllUsers()
        {
            using (var entities = new TradingCompanyEntities())
            {
                return _mapper.Map<List<UserDto>>(entities.Users
                    .Include(db => db.UserRoles.Select(c => c.Role)));
            }
        }

        public UserDto GetUserById(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                return _mapper.Map<UserDto>(entities.Users.
                    Include(db => db.UserRoles.Select(c => c.Role))
                    .SingleOrDefault(obj => obj.UserID == id));
            }
        }

        public UserDto GetUserByLogin(string login)
        {
            using (var entities = new TradingCompanyEntities())
            {
                return _mapper.Map<UserDto>(entities.Users
                    .Include(db => db.UserRoles.Select(c => c.Role))
                    .SingleOrDefault(obj => obj.Login == login));
            }
        }


        public void UpdateUser(UserDto user)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var userf = entities.Users.SingleOrDefault(obj => obj.UserID == user.UserID);
                if (userf != null)
                {
                    userf.Login = user.Login;
                    userf.Email = user.Email;
                    userf.Password = user.Password;
                    userf.RowUpdateTime = DateTime.UtcNow;
                    entities.SaveChanges();
                }
            }
        }
        public bool Login(string login, string password)
        {
            using (var entities = new TradingCompanyEntities())
            {

                User user = entities.Users.SingleOrDefault(u => u.Login == login);
                return user != null && user.Password.SequenceEqual(hash(password, user.Salt.ToString())); ;
            }
        }

        private byte[] hash(string password, string salt)
        {
            var alg = SHA512.Create();
            return alg.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
        }

    }
}
