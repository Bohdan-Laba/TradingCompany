using AutoMapper;
using DAL.Concrete;
using DAL.Interfaces;
using System;
using System.Configuration;
using System.Windows.Forms;
using TradingCompany.BLL.Concrete;
using TradingCompany.BLL.Interfaces;
using Unity;

namespace TradingCompany.WF
{
    static class Program
    {
        //public static AppDataManager
        public static UnityContainer Container;

        //save current user!!!! userdto

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureUnity();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm lf = Container.Resolve<LoginForm>();

            if (lf.ShowDialog() == DialogResult.OK)
            {
                Application.Run(Container.Resolve<ItemList>());
            }
            else
            {
                Application.Exit();
            }
        }

        private static void ConfigureUnity()
        {
            MapperConfiguration config = new MapperConfiguration(
                cfg => cfg.AddMaps(typeof(ItemDal).Assembly)
                );

            Container = new UnityContainer();
            Container.RegisterInstance<IMapper>(config.CreateMapper());
            Container.RegisterType<IUserDal, UserDal>()
                     .RegisterType<IItemDal, ItemDal>()
                     .RegisterType<IOrderDal, OrderDal>()
                     .RegisterType<IRoleDal, RoleDal>()
                     .RegisterType<IStatusDal, StatusDal>()
                     .RegisterType<IManager, Manager>()
                     .RegisterType<IAuthManager, AuthManager>();
        }
    }
}
