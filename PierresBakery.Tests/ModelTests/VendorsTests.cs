using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
    [TestClass]

    public class VendorsTest : IDisposable
    {
        public void Dispose()
        {
            Vendors.ClearAll();
        }

        [TestMethod]
        public void VendorsConstructor_CreatesVendorObject_Vendor()
        {

            Vendors newVendor = new Vendors("vendorName", "vendorDescription");
            Assert.AreEqual(typeof(Vendors), newVendor.GetType());
        }

        [TestMethod]
        public void GetId_ReturnsVendorsId_Int()
        {
            Vendors newVendor = new Vendors("IslandBages", "Bagel shop");
            int actualId = newVendor.Id;
            Assert.AreEqual(1, actualId);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            Vendors newVendor1 = new Vendors("IslandBages", "Bagel shop");
            Vendors newVendor2 = new Vendors("vendorName", "vendorDescription");
            List<Vendors> newVendorList = new List<Vendors> { newVendor1, newVendor2 };

            List<Vendors> result = Vendors.GetAll();

            CollectionAssert.AreEqual(newVendorList, result);
        }

        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            Vendors newVendor1 = new Vendors("IslandBages", "Bagel shop");
            Vendors newVendor2 = new Vendors("vendorName", "vendorDescription");

            Vendors result = Vendors.Find(1);

            Assert.AreEqual(newVendor1, result);
        }

        [TestMethod]
        public void AddOrder_AssociatesOrderWithCategory_OrderList()
        {
            decimal orderPrice = 12.99m;
            Order newOrder = new Order("orderTitle", "orderDescription", orderPrice, "07/21/2023");
            List<Order> newList = new List<Order> { newOrder };
            Vendors newVendor = new Vendors("IslandBages", "Bagel shop");
            newVendor.AddOrder(newOrder);

            List<Order> result = newVendor.Orders;

            CollectionAssert.AreEqual(newList, result);
        }
    }
}
//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()