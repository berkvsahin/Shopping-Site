using Microsoft.AspNetCore.Mvc;
using OL;
using System;

namespace SiparisSepetim.Controllers
{
    public class ProductController : Controller
    {


        
        public IActionResult Index()
        {   

            BL.ProductManager _ProductManager = new BL.ProductManager();
            BL.CategoryManager _CategoryManager=new BL.CategoryManager();
            Models.ModelViewProducts model = new Models.ModelViewProducts();

             
            model.Product = _ProductManager.GetProducts(); // Tüm ürünleri getiri
            /*  model.List = manager.GetList();*/ // Ürünler arasında kategoriye göre listelemek için 
            model.Categories = _CategoryManager.GetCategories();
            //View İçine gönderiliyor
            return View(model);
        }

        //public IActionResult List(string categoryName)
        //{
        //    BL.ProductManager _ProductManager = new BL.ProductManager();
        //    Models.ModelViewProducts model = new Models.ModelViewProducts();
        //    model.Product = _ProductManager.GetProducts();
        //    return View("Index", model);
        //}

    }
}
