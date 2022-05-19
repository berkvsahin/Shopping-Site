using Microsoft.AspNetCore.Mvc;
using SiparisSepetim.Models;


namespace SiparisSepetim.Controllers
{
    public class CategoryController : Controller
    {
        
        public IActionResult Index()
        {
            Models.ModelViewCategories model = new ModelViewCategories();
            BL.CategoryManager _categoryManager = new BL.CategoryManager();

            model.Category = _categoryManager.GetCategories();
            

            //View İçine gönderiliyor
            return View(model);
        }
    }
}
