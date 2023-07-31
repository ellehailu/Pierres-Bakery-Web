using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PierresBakery.Models;

namespace PierresBakery.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{vendorsId}/orders/new")]
        public ActionResult New(int vendorsId)
        {
            Vendors vendor = Vendors.Find(vendorsId);
            return View(vendor);
        }

        [HttpGet("/vendors/{vendorsId}/orders/{orderId}")]
        public ActionResult Show(int vendorsId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendors vendor = Vendors.Find(vendorsId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", order);
            model.Add("vendor", vendor);
            return View(model);
        }
    }
}

