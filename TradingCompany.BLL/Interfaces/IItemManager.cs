using System.Collections.Generic;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IItemManager
    {
        ItemDto AddItem(ItemDto item);
        ItemDto GetItem(int id);
        List<ItemDto> GetListOfItems();
        List<UserDto> GetListOfSellers();
        ItemDto UpdateItem(ItemDto item);
        void DeleteItem(int id);
    }
}
