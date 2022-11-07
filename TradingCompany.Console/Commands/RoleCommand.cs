using AutoMapper;
using TradingCompany.DAL.Concrete;
using TradingCompany.DAL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.Console.Commands
{
    public static class RoleCommand
    {
        static IMapper _mapper = setupMapper();
        static IRoleDal _dal = new RoleDal(_mapper);

        private static IMapper setupMapper()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(RoleDal).Assembly)
                );
            return config.CreateMapper();
        }

        public static void AddRole()
        {
            System.Console.Write("Enter a role name: ");
            string _name = System.Console.ReadLine();

            var newItem = new RoleDto
            {
                Name = _name,
            };

            newItem = _dal.CreateRole(newItem);

            System.Console.WriteLine($"Role added! ID:{newItem.RoleID}");
        }

        public static void ShowAllRoles()
        {
            var roles = _dal.GetAllRoles();

            foreach (var item in roles)
            {
                System.Console.WriteLine($"ID:{item.RoleID}\t Role Name:{item.Name}\n");
            }

        }

        public static void ShowRole()
        {
            System.Console.Write("Enter a role id: ");
            int id = int.Parse(System.Console.ReadLine());
            var item = _dal.GetRoleById(id);

            System.Console.WriteLine($"ID:{item.RoleID}\t Role Name:{item.Name}\n");
        }

        public static void UpdateRole()
        {
            System.Console.Write("Enter a role id: ");
            int _id = int.Parse(System.Console.ReadLine());
            System.Console.Write("Enter a new role name: ");
            string _name = System.Console.ReadLine();

            var newItem = new RoleDto
            {
                RoleID = _id,
                Name = _name,
            };

            _dal.UpdateRole(newItem);

            System.Console.WriteLine($"Role updated! ID:{newItem.RoleID}");
        }

        public static void DeleteRole()
        {
            System.Console.Write("Enter a role id: ");
            int id = int.Parse(System.Console.ReadLine());

            _dal.DeleteRole(id);
            System.Console.WriteLine("Item deleted successfully!");

        }
    }
}
