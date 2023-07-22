using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
    public class Vendors
    {


        public string VendorName { get; set; }
        public string VendorDescription { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }
        public static List<Vendors> _vendorsList = new List<Vendors> { };

        public Vendors(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            _vendorsList.Add(this);
            Id = _vendorsList.Count;
            Orders = new List<Order> { };
        }

        public static List<Vendors> GetAll()
        {
            return _vendorsList;
        }

        public static void ClearAll()
        {
            _vendorsList.Clear();
        }

        public static Vendors Find(int searchId)
        {
            return _vendorsList[searchId - 1];
        }
        public void AddOrder(Order newOrder)
        {
            Orders.Add(newOrder);
        }
    }
}