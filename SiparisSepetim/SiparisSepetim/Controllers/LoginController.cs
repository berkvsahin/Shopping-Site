using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OL;
using SiparisSepetim.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace SiparisSepetim.Controllers
{
   
    public class LoginController : Controller
    {
        BL.UserManager _userManager = new BL.UserManager();


        public IActionResult Index()
        {
                return View();
        }

        
        public IActionResult Submit(Models.ModelViewUsers model)  //ModelViewUserın içinden ObjDbUser daki mail ve şifreyi çekiyor.
        {

            var bilgiler = _userManager.Getlogin(model.User.eMail, model.User.pass);

            //ClaimsIdentity identity = new ClaimsIdentity((bilgiler, CookieAuthenticationDefaults.AuthenticationScheme);
            //ClaimsPrincipal principal = new ClaimsPrincipal(identity);
            if (bilgiler.UserId > 0) // Tabloda böyle bir User var mı
            {
                
                HttpContext.Session.SetString("UserId", bilgiler.UserId.ToString()); //Liste oluştururken hangi kullanıcının id si ile oluştuğu
                //HttpContext.SignInAsync(principal, new AuthenticationProperties() { IsPersistent = true });
                return RedirectToAction("Index", "OrderList" );
            }
            else
                return RedirectToAction("Index", "Login");

      
        }

        
        
        
            

           
        

    }
}
