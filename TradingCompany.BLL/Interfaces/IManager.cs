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
        RoleDto GetRole(string roleName);
        ItemDto GetItem(int itemId);
        RoleDto GetRole(int roleId);
        UserDto GetUser(int userId);
        StatusDto GetStatus(int statusId);
        List<ItemDto> GetItemsList();
        List<ItemDto> GetSellerItemsList(int sellerId);
        List<OrderDto> GetSellerOrdersList(int sellerId);
        List<OrderDto> GetOrdersList();
        List<StatusDto> GetStatusesList();
    }
}
