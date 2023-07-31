using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet("/vendors/{vendorsId}/orders/new")]
        public ActionResult New(int id)
        {
            Vendors vendor = Vendors.Find(id);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorsId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendors vendor = Vendors.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", order);
            model.Add("vendor s", vendor);
            return View(model);
        }
    }
}

