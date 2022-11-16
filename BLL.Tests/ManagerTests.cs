using NUnit.Framework;
using Moq;
using TradingCompany.BLL.Concrete;
using DAL.Interfaces;
using TradingCompany.DTO;
using System.Collections.Generic;
using System;


namespace BLL.Tests
{
    public class ManagerTests
    {

        private Mock<IItemDal> itemDal;
        private Mock<IUserDal> userDal;
        private Mock<IOrderDal> orderDal;
        private Mock<IStatusDal> statusDal;
        private Mock<IRoleDal> roleDal;
        private Manager manager;

        [SetUp]
        public void Setup()
        {
            itemDal = new Mock<IItemDal>(MockBehavior.Strict);
            userDal = new Mock<IUserDal>(MockBehavior.Strict);
            orderDal = new Mock<IOrderDal>(MockBehavior.Strict);
            statusDal = new Mock<IStatusDal>(MockBehavior.Strict);
            roleDal = new Mock<IRoleDal>(MockBehavior.Strict);

            manager = new Manager(itemDal.Object, userDal.Object, orderDal.Object, statusDal.Object, roleDal.Object);

        }

        [Test]
        public void AddOrderTest()
        {
            OrderDto inOrder = new OrderDto
            {
                UserID = 1,
                ItemID = 1,
                Quantity = 1,
                StatusID = 1,
            };
            OrderDto outOrder = new OrderDto { OrderID = 1 };

            orderDal.Setup(d => d.CreateOrder(inOrder)).Returns(outOrder);
            var res = manager.Add(inOrder);

            Assert.NotNull(res);
            Assert.AreEqual(outOrder.OrderID, res.OrderID);
        }

        [Test]
        public void GetSellerItemsListTest()
        {
            int selllerId = 1;

            ItemDto item1 = new ItemDto
            {
                ItemID = 1,
                SellerID = 1,
            };
            ItemDto item2 = new ItemDto
            {
                ItemID = 2,
                SellerID = 1,

            };
            ItemDto item3 = new ItemDto
            {
                ItemID = 3,
                SellerID = 2,
            };
            List<ItemDto> allItems = new List<ItemDto>();
            allItems.Add(item1);
            allItems.Add(item2);
            allItems.Add(item3);

            List<ItemDto> outItems = new List<ItemDto>();
            outItems.Add(item1);
            outItems.Add(item2);

            itemDal.Setup(d => d.GetAllItems()).Returns(allItems);


            var res = manager.GetSellerItemsList(selllerId);

            CollectionAssert.IsNotEmpty(res);
            CollectionAssert.AreEqual(res,outItems);
        }

        [Test]
        public void GetSellerOrderList()
        {
            int sellerId = 2;
            OrderDto order1 = new OrderDto
            {
                ItemID = 1,
                Quantity = 1,

            };
            OrderDto order2 = new OrderDto
            {
                ItemID = 2,
                Quantity = 2,
            };
            OrderDto order3 = new OrderDto
            {
                ItemID = 2,
                Quantity = 1,
            };
            OrderDto order4 = new OrderDto
            {
                ItemID = 3,
                Quantity = 5,
            };

            List<OrderDto> allOrders = new List<OrderDto>();
            allOrders.Add(order1);
            allOrders.Add(order2);
            allOrders.Add(order3);
            allOrders.Add(order4);


            List<OrderDto> outOrders = new List<OrderDto>();
            outOrders.Add(order2);
            outOrders.Add(order3);
            outOrders.Add(order4);

            ItemDto item1 = new ItemDto
            {
                ItemID = 1,
                SellerID = 1,
            };
            ItemDto item2 = new ItemDto
            {
                ItemID = 2,
                SellerID = 2,
            };
            ItemDto item3 = new ItemDto
            {
                ItemID = 3,
                SellerID = 2,
            };


            orderDal.Setup(d => d.GetAllOrders()).Returns(allOrders);
            itemDal.Setup(d => d.GetItem(item1.ItemID)).Returns(item1);
            itemDal.Setup(d => d.GetItem(item2.ItemID)).Returns(item2);
            itemDal.Setup(d => d.GetItem(item3.ItemID)).Returns(item3);


            var res = manager.GetSellerOrdersList(sellerId);


            CollectionAssert.IsNotEmpty(res);
            CollectionAssert.AreEqual(res, outOrders);
        }
    }
}
