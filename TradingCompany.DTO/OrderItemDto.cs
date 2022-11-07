﻿
using System;

namespace TradingCompany.DTO
{
    public class OrderItemDto
    {
        public int OrderID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public DateTime RowInsertTime { get; set; }
    }
}
