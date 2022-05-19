using Microsoft.AspNetCore.Mvc;

namespace SiparisSepetim.Controllers
{
    public class SignController : Controller
    {
        BL.UserManager _userManager = new BL.UserManager();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(OL.ObjUser model) // Ol.Db.ObjUser sınıfından nesne oluşturdum ve kayıt nesnesi sign formundan verileri tuttu.
        {
            _userManager.SetSign(model);
            return View();
        }
    }
}
