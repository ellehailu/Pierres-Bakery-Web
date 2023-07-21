using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
    [TestClass]

    public class VendorsTest
    {

        [TestMethod]
        public void VendorsConstructor_CreatesVendorObject_Vendor()
        {

            Vendors newVendor = new Vendors("vendorName", "vendorDescription");
            Assert.AreEqual(typeof(Vendors), newVendor.GetType());

        }
    }
}
//public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()