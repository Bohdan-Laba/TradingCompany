using TradingCompany.Console.Commands;

namespace TradingCompany.Console.Menus
{
    public static class RoleMenu
    {
        public static void ShowMenu()
        {
            bool show = true;
            while (show)
            {
                //Console.Clear();
                menuInfo();
                string input = System.Console.ReadLine();
                switch (input)
                {
                    case "1":
                        RoleCommand.ShowAllRoles();
                        break;
                    case "2":
                        RoleCommand.ShowRole();
                        break;
                    case "3":
                        RoleCommand.AddRole();
                        break;
                    case "4":
                        RoleCommand.UpdateRole();
                        break;
                    case "5":
                        RoleCommand.DeleteRole();
                        break;
                    case "0":
                        show = false;
                        break;
                    default:
                        show = false;
                        break;

                }
            }

        }
        private static void menuInfo()
        {
            System.Console.WriteLine(@"Role Menu.
1. Show all Roles;
2. Show a role;
3. Add a role;
4. Update a role;
5. Delete a role;
0. Return to Main Menu;
Please choose an action: ");
        }
    }
}
