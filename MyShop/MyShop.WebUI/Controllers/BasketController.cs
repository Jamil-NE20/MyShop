using MyShop.Core.Contracts;
using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{

    public class BasketController : Controller
    {

        IRepository<Product> context;
        IRepository<ProductCategory> productCategories;

        // GET: Basket
        public ActionResult Index()
        {
            return View();
        }
    }
}