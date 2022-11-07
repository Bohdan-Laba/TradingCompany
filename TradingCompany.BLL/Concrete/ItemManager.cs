using System;
using System.Collections.Generic;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;
using DAL.Interfaces;

namespace TradingCompany.BLL.Concrete
{
    public class ItemManager : IItemManager
    {
        private readonly IItemDal _itemDal;

        public ItemManager(IItemDal itemDal)
        {
            _itemDal = itemDal;
        }

        public ItemDto AddItem(ItemDto item)
        {
            throw new NotImplementedException();
        }

        public void DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public ItemDto GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public List<ItemDto> GetListOfItems()
        {
            return _itemDal.GetAllItems();
        }

        public List<UserDto> GetListOfSellers()
        {
            throw new NotImplementedException();
        }

        public ItemDto UpdateItem(ItemDto item)
        {
            throw new NotImplementedException();
        }
    }
}
