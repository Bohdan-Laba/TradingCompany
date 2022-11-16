using System;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;
using DAL.Interfaces;
using System.Linq;
using TradingCompany.DAL;

namespace TradingCompany.BLL.Concrete
{
    public class Manager : IManager
    {
        private readonly IItemDal _itemDal;
        private readonly IUserDal _userDal;
        private readonly IOrderDal _orderDal;
        private readonly IStatusDal _statusDal;
        private readonly IRoleDal _roleDal;

        public Manager(IItemDal itemDal, IUserDal userDal, IOrderDal orderDal, IStatusDal statusDal, IRoleDal roleDal)
        {
            _itemDal = itemDal;
            _userDal = userDal;
            _orderDal = orderDal;
            _statusDal = statusDal;
            _roleDal = roleDal;
        }

        public List<ItemDto> GetItemsList()
        {
            return _itemDal.GetAllItems();
        }

        public List<ItemDto> GetSellerItemsList(int sellerId)
        {
            return _itemDal.GetAllItems().FindAll(itms => itms.SellerID == sellerId);
        }

        public List<OrderDto> GetSellerOrdersList(int sellerId)
        {
            //var allOrders = _orderDal.GetAllOrders();
            //var allItems = _itemDal.GetAllItems();
            //var result = new List<OrderDto>();
            //foreach (var ord in allOrders)
            //{
            //    if (ord.ItemID == allItems))
            //    {

            //    }
            //}
            return _orderDal.GetAllOrders().FindAll(
                ord => _itemDal.GetItem(ord.ItemID).SellerID == sellerId);
               
        }

        //public List<int> GetSellersList()
        //{
        //    //hardcode
        //    var list = _userDal.GetAllUsers().FindAll(o => o);
        //    var ids =
        //}

        public List<OrderDto> GetOrdersList()
        {
            return _orderDal.GetAllOrders();
        }

        public OrderDto Add(OrderDto order)
        {
            return _orderDal.CreateOrder(order);
        }

        public bool Update(OrderDto order)
        {
            return _orderDal.UpdateOrder(order);
        }


        public void Delete(int orderId)
        {
            _orderDal.DeleteOrder(orderId);
        }

        public List<StatusDto> GetStatusesList()
        {
            return _statusDal.GetAllStatuses();
        }

        public ItemDto GetItem(string itemName)
        {
            return _itemDal.GetItem(itemName);
        }

        public RoleDto GetRole(string roleName)
        {
            return _roleDal.GetRoleByName(roleName);
        }

        public ItemDto GetItem(int itemId)
        {
            return _itemDal.GetItem(itemId);
        }

        public RoleDto GetRole(int roleId)
        {
            return _roleDal.GetRoleById(roleId);
        }

        public UserDto GetUser(int userId)
        {
            return _userDal.GetUserById(userId);
        }

        public StatusDto GetStatus(int statusId)
        {
            return _statusDal.GetStatus(statusId);
        }
    }
}
