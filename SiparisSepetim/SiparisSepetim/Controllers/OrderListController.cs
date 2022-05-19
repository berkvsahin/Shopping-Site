using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using OL;
using System;

namespace SiparisSepetim.Controllers
{
    public class OrderListController : Controller
    {
        BL.OrderListManager _orderListManager = new BL.OrderListManager();  // Manager içindeki fonksiyonları kullanabilmek için
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] 
        public IActionResult Index(ObjOrderList model) //ObjOrderListteki properertyleri girdi olarak alıyor
        {
            model.UserId = Int32.Parse(HttpContext.Session.GetString("UserId"));
            _orderListManager.SetOrderList(model);

            if (model.UserId > 0)
            {
                return RedirectToAction("Index", "Product");
            }
            else
                return RedirectToAction("Index", "OrderList");
            
        }
    }
}
