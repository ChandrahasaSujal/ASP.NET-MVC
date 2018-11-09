using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBindingDemo.Models;

namespace DataBindingDemo.Controllers
{
    public class ProductsController : Controller
    {
        ProductsData db = new ProductsData();

        public ViewResult Index()
        {
           List<Product> products= db.ProductList.ToList();
            return View(products);
        }

        public ViewResult Details(int id)
        {
           Product product= db.ProductList.Single(x => x.ProductId == id);
            return View(product);
        }
    }
}