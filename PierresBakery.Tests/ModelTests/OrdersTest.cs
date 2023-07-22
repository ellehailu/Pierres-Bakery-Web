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
    }
}

//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()