using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Orders
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public decimal OrderList { get; set; }
        public string OrderDate { get; set; }

        public Orders(string orderTitle, string orderDescription, decimal orderPrice, string orderDate)
        {
            OrderTitle = orderTitle;
            OrderDescription = orderDescription;
            OrderPrice = orderPrice;
            OrderDate = orderDate;
        }
    }
}