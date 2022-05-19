using Microsoft.AspNetCore.Mvc;

namespace SiparisSepetim.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
