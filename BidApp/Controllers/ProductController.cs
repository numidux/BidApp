using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BidApp.Models;

namespace BidApp.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var firstProduct = new Product(1, "PES 2017", 20);
            var secondProduct = new Product(2, "FIFA 17", 22);

            var products = new List<Product>();
            products.Add(firstProduct);
            products.Add(secondProduct);

            var model = new ProductsViewModel
            {
                Products = products
            };

            return View("List", model);
        }
    }
}