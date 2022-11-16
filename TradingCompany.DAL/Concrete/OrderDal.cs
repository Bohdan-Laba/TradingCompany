using AutoMapper;
using DAL.Interfaces;
using TradingCompany.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using TradingCompany.DAL;

namespace DAL.Concrete
{
    public class OrderDal : IOrderDal
    {
        private readonly IMapper _mapper;

        public OrderDal(IMapper mapper)
        {
            _mapper = mapper;
        }

        public OrderDto CreateOrder(OrderDto order)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var orderInDB = _mapper.Map<Order>(order);
                orderInDB.RowInsertTime = DateTime.UtcNow;
                entities.Orders.Add(orderInDB);
                entities.SaveChanges();
                return _mapper.Map<OrderDto>(orderInDB);
            }
        }

        public void DeleteOrder(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var orderf = entities.Orders.SingleOrDefault(obj => obj.OrderID == id);
                if (orderf != null)
                {
                    entities.Orders.Remove(orderf);
                    entities.SaveChanges();
                }
            }
        }

        public List<OrderDto> GetAllOrders()
        {
            using (var entities = new TradingCompanyEntities())
            {
                return _mapper.Map<List<OrderDto>>(entities.Orders);
            }
        }

        public OrderDto GetOrder(int id)
        {
            using (var entities = new TradingCompanyEntities())
            {
                var order = entities.Orders.SingleOrDefault(obj => obj.OrderID == id);
                return _mapper.Map<OrderDto>(order);
            }
        }

        public bool UpdateOrder(OrderDto order)
        {
            bool updated = false;
            using (var entities = new TradingCompanyEntities())
            {
                var orderf = entities.Orders.SingleOrDefault(obj => obj.OrderID == order.OrderID);
                if (orderf != null)
                {
                    orderf.UserID = order.UserID;
                    orderf.StatusID = order.StatusID;
                    orderf.Quantity = order.Quantity;
                    orderf.ItemID = order.ItemID;
                    orderf.RowInsertTime = DateTime.UtcNow;
                    entities.SaveChanges();

                    updated = true;
                }
            }
            return updated;
        }
    }
}
