using NUnit.Framework;
using Moq;
using TradingCompany.BLL.Concrete;
using DAL.Interfaces;
using TradingCompany.DTO;
using System.Collections.Generic;

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
            string incorrectPassword = "qwertyu";


            userDal.Setup(d => d.Login(login, password)).Returns(true);
            userDal.Setup(d => d.Login(login, incorrectPassword)).Returns(false);
            var res = manager.Login(login, password);
            var resfalse = manager.Login(login, incorrectPassword);

            Assert.IsTrue(res);
            Assert.IsFalse(resfalse);
        }

        [Test]
        public void GetUserByLoginTest()
        {
            string login = "TestLogin";
            UserDto outUser = new UserDto { Login = login };

            userDal.Setup(d => d.GetUserByLogin(login)).Returns(outUser);

            var res = manager.GetUserByLogin(login);

            Assert.NotNull(res);
            Assert.AreEqual(outUser.Login, res.Login);
        }

        [Test]
        public void GetUserByIdTest()
        {
            int id = 1;
            UserDto outUser = new UserDto { UserID = id };

            userDal.Setup(d => d.GetUserById(id)).Returns(outUser);

            var res = manager.GetUserById(id);

            Assert.NotNull(res);
            Assert.AreEqual(outUser.UserID, res.UserID);
        }

        [Test]
        public void GetAllUsersTest()
        {
            int id1 = 1;
            int id2 = 2;

            UserDto outUser1 = new UserDto { UserID = id1 };
            UserDto outUser2 = new UserDto { UserID = id2 };
            List<UserDto> outUsers = new List<UserDto>();
            outUsers.Add(outUser1);
            outUsers.Add(outUser2);

            userDal.Setup(d => d.GetAllUsers()).Returns(outUsers);
            var res = manager.GetAllUsers();

            CollectionAssert.IsNotEmpty(res);
            Assert.AreEqual(outUsers.Count, res.Count);
            CollectionAssert.AreEqual(outUsers, res);
        }
    }
}
