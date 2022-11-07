using NUnit.Framework;
using Moq;
using TradingCompany.BLL.Concrete;
using DAL.Interfaces;

namespace BLL.Tests
{
    [TestFixture]
    public class AuthManagerTests
    {
        private Mock<IUserDal> userDal;
        private AuthManager manager;

        [SetUp]
        public void Setup()
        {
            userDal = new Mock<IUserDal>(MockBehavior.Strict);
            manager = new AuthManager(userDal.Object);
        }


        [Test]
        public void LoginUserTest()
        {
            string login = "login";
            string password = "qwerty";

            userDal.Setup(d => d.Login(login, password)).Returns(true);
            var res = manager.Login(login, password);

            Assert.IsTrue(res);
        }

    }
}
