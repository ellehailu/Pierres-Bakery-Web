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
        public List<Order> OrderList { get; set; }

        public Vendors(string vendorName, string vendorDescription)
        {
            VendorName = vendorName;
            VendorDescription = vendorDescription;
            _vendorsList.Add(this);
            Id = _vendorsList.Count;
            OrderList = new List<Order> { };
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
        public void AddOrder(Order order)
        {
            OrderList.Add(order);
        }
    }
}