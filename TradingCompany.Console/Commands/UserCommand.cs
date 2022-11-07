using AutoMapper;
using TradingCompany.DAL;
using TradingCompany.DAL.Concrete;
using TradingCompany.DAL.Interfaces;
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
                System.Console.Write("Enter a user role or press: ");
                rolestr = System.Console.ReadLine();
                roles.Add(_roleDal.GetRoleByName(rolestr));
            } while (true);

            var newEntity = _dal.CreateUser(_name, _mail, _pass, roles);
            System.Console.WriteLine($"User added! ID:{newEntity.UserID}\t Login:{newEntity.Login};");
        }

        public static void ShowAllUsers()
        {
            var users = _dal.GetAllUsers();

            foreach (var entity in users)
            {
                System.Console.WriteLine($"ID:{entity.UserID}\t Login:{entity.Login}; User Email:{entity.Email}\n");
            }

        }

        public static void ShowUser()
        {
            System.Console.Write("Enter a user id: ");
            int id = int.Parse(System.Console.ReadLine());
            var entity = _dal.GetUserById(id);

            System.Console.WriteLine($"ID:{entity.UserID}\t Login:{entity.Login}; User Email:{entity.Email}\n");
        }


    }
}
