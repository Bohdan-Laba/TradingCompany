using System.Collections.Generic;
using TradingCompany.DTO;

namespace TradingCompany.BLL.Interfaces
{
    public interface IManager
    {
        OrderDto Add(OrderDto order);
        bool Update(OrderDto order);
        void Delete(int orderId);
        ItemDto GetItem(string itemName);
        ItemDto GetItem(int itemId);
        List<ItemDto> GetItemsList();
        List<ItemDto> GetSellerItemsList(int sellerId);
        List<OrderDto> GetSellerOrdersList(int sellerId);
        List<StatusDto> GetStatusesList();
    }
}
