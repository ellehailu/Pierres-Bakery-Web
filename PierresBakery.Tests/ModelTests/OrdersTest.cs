using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
    [TestClass]

    public class OrderTests : IDisposable
    {

        public void Dispose()
        {
            Order.ClearAll();
        }


        [TestMethod]
        public void OrderConstructor_CreatesOrders_Order()
        {
            decimal orderPrice = 12.99m;
            Order newOrder = new Order("orderTitle", "orderDescription", orderPrice, "07/21/2023");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetOrderDetails_ReturnOrderDetails_StringAndDecimal()
        {
            string orderTitle = "weekend order";
            string orderDescription = "Saturday and Sunday Order";
            decimal orderPrice = 12.99m;
            string orderDate = "07/22/2023";
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
        }

        [TestMethod]
        public void GetAll_ReturnOrders_OrderList()
        {
            decimal orderPrice1 = 12.99m;
            decimal orderPrice2 = 24.99m;
            Order newOrder1 = new Order("weekend order", "Saturday and Sunday Order", orderPrice1, "07/22/2023");
            Order newOrder2 = new Order("weekeday order", "Monday through friday order", orderPrice2, "07/23/2023");
            List<Order> newOrderList = new List<Order> { newOrder1, newOrder2 };

            List<Order> result = Order.GetAll();
            CollectionAssert.AreEqual(result, newOrderList);
        }
    }
}

//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()