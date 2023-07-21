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
    }
}
//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()