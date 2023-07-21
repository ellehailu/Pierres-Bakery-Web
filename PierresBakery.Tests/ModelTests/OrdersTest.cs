using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
    [TestClass]

    public class OrdersTest
    {

        [TestMethod]
        public void OrdersConstructor_CreatesOrders_Orders()
        {
            decimal orderPrice = 12.99m;
            Orders newOrders = new Orders("orderTitle", "orderDescription", orderPrice, "07/21/2023");
            Assert.AreEqual(typeof(Orders), newOrders.GetType());
        }
    }
}

//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()