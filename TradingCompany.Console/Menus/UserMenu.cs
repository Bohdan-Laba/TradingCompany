using TradingCompany.Console.Commands;

namespace TradingCompany.Console.Menus
{
    public static class UserMenu
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
                        UserCommand.ShowAllUsers();
                        break;
                    case "2":
                        UserCommand.ShowUser();
                        break;
                    case "3":
                        UserCommand.AddUser();
                        break;
                    case "4":
                        UserCommand.UpdateUser();
                        break;
                    case "5":
                        UserCommand.DeleteUser();
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
            System.Console.WriteLine(@"User Menu.
1. Show all Users;
2. Show a user;
3. Add a user;
4. Update a user;
5. Delete a user;
0. Return to Main Menu;
Please choose an action: ");
        }
    }
}
