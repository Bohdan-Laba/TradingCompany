using TradingCompany.DTO;
using System.Collections.Generic;


namespace DAL.Interfaces
{
    public interface IItemDal
    {
        List<ItemDto> GetAllItems();
        ItemDto CreateItem(ItemDto Item);
        ItemDto GetItem(int id);
        ItemDto GetItem(string name);
        void UpdateItem(ItemDto Item);
        void DeleteItem(int id);
    }
}
