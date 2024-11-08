using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrderProcessing;
namespace ECommerceWeb.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            IOrderService orderService = new OrderService();
            List<Order> orders = orderService.GetAll();
            
            return View(orders);
        }
    }
}