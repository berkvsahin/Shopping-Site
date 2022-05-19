using Microsoft.AspNetCore.Mvc;
using OL;
using System;
namespace SiparisSepetim.Controllers
{
    public class CartController : Controller
    {
        
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(ObjProduct obj)
        {

            return View();
        }
    }
}
