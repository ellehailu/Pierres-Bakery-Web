using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
    [TestClass]

    public class OrderTest
    {

        [TestMethod]
        public void OrderConstructor_CreatesOrders_Order()
        {
            decimal orderPrice = 12.99m;
            Order newOrder = new Order("orderTitle", "orderDescription", orderPrice, "07/21/2023");
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}

//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()