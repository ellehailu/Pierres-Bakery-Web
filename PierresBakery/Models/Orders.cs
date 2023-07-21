using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Orders
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public decimal OrderPrice { get; set; }
        public string OrderDate { get; set; }

        public int Id { get; }

        private static List<Orders> _ordersList = new List<Orders> { };

        public Orders(string orderTitle, string orderDescription, decimal orderPrice, string orderDate)
        {
            OrderTitle = orderTitle;
            OrderDescription = orderDescription;
            OrderPrice = orderPrice;
            OrderDate = orderDate;
            _ordersList.Add(this);
            Id = _ordersList.Count;
        }
    }
}