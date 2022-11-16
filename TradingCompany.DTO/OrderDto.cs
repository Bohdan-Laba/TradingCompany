using System;
using System.Collections.Generic;

namespace TradingCompany.DTO
{
    public class OrderDto
    {
        public int OrderID { get; set; }
        public int UserID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public int StatusID { get; set; }
        public DateTime RowInsertDate { get; set; }
    }
}
