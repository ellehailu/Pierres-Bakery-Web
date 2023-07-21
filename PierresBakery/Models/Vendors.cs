using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Vendors
    {

        private static List<Vendors> _vendorsList = new List<Vendors> { };
        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        public List<Orders> OrderList { get; set; }

        public Vendors(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            Id = _vendorsList.Count;
            OrderList = new List<Orders> { };
        }
    }
}