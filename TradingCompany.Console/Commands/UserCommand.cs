using AutoMapper;
using TradingCompany.DAL;
using DAL.Concrete;
using DAL.Interfaces;
using TradingCompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TradingCompany.Console.Commands
{
    public static class UserCommand
    {
        static IMapper _mapper = setupMapper();
        static IUserDal _dal = new UserDal(_mapper);
        static IRoleDal _roleDal = new RoleDal(_mapper);

        private static IMapper setupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(UserDal).Assembly)
                );
            return config.CreateMapper();
        }

        public static void AddUser()
        {
            System.Console.Write("Enter a login/username: ");
            string _name = System.Console.ReadLine();

            System.Console.Write("Enter a password: ");
            string _pass = System.Console.ReadLine();

            System.Console.Write("Enter an email: ");
            string _mail = System.Console.ReadLine();


            string rolestr;
            List<RoleDto> roles = new List<RoleDto>();
            roles.Add(_roleDal.GetRoleByName("User"));
            do
            {
                System.Console.Write("User is a common role!\nEnter a custom role or leave a blank space: ");
                rolestr = System.Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rolestr))
                {
                    break;
                }
                roles.Add(_roleDal.GetRoleByName(rolestr));
            } while (true);

            var newEntity = _dal.CreateUser(_name, _mail, _pass, roles);
            System.Console.Write($"User updated!\nUser ID:{newEntity.UserID};" +
                 $"Login:{newEntity.Login}; Email:{newEntity.Email}\n Roles:");
            foreach (var role in newEntity.Roles)
            {
                System.Console.Write($" {role.Name};");
            }
            System.Console.WriteLine();

        }

        public static void ShowAllUsers()
        {
            var users = _dal.GetAllUsers();

            foreach (var entity in users)
            {
                System.Console.WriteLine($"ID:{entity.UserID}\t Login:{entity.Login}; Email:{entity.Email}\n");
            }

        }

        public static void ShowUser()
        {
            System.Console.Write("Enter a user id: ");
            int id = int.Parse(System.Console.ReadLine());
            var entity = _dal.GetUserById(id);

            System.Console.Write($"\nUser ID:{entity.UserID}; " +
                $"Login:{entity.Login}; Email:{entity.Email}\nRoles:");
            foreach (var role in entity.Roles)
            {
                System.Console.Write($" {role.Name};");
            }
            System.Console.WriteLine();
        }
        public static void UpdateUser()
        {
            System.Console.Write("Enter a user id: ");
            int _id = int.Parse(System.Console.ReadLine());

            var thisItem = _dal.GetUserById(_id);
            System.Console.WriteLine();
            System.Console.WriteLine("Leave an empty field if you do not want to change the row!");
            System.Console.WriteLine();

            System.Console.Write("Enter a user login: ");
            string loginStr = System.Console.ReadLine();
            string _login = string.IsNullOrWhiteSpace(loginStr) ? thisItem.Login : loginStr;

            System.Console.Write("Enter a user email: ");
            var emailStr = System.Console.ReadLine();
            string _email = string.IsNullOrWhiteSpace(emailStr) ? thisItem.Email : emailStr;

            System.Console.Write("Enter a user password: ");
            var _password = System.Console.ReadLine();

            string rolestr;
            List<RoleDto> _roles = new List<RoleDto>();
            _roles.Add(_roleDal.GetRoleByName("User"));
            do
            {
                System.Console.Write("User is a common role!\nEnter new custom roles or leave a blank space: ");
                rolestr = System.Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rolestr))
                {
                    break;
                }
                _roles.Add(_roleDal.GetRoleByName(rolestr));
            } while (true);

            var updUser = _dal.UpdateUser(_id,_login,_email,_password,_roles);

            System.Console.Write($"User updated!\nUser ID:{updUser.UserID};" +
                $"Login:{updUser.Login}; Email:{updUser.Email}\n Roles:");
            foreach (var role in updUser.Roles)
            {
                System.Console.Write($" {role.Name};");
            }
            System.Console.WriteLine();
        }

        public static void DeleteUser()
        {
            System.Console.Write("Enter a user id: ");
            int id = int.Parse(System.Console.ReadLine());
            _dal.DeleteUser(id);
            System.Console.WriteLine("User deleted successfully!");
        }
    }
}
