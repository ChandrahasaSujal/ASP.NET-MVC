using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBindingDemo.Models;

namespace DataBindingDemo.Controllers
{
    public class PartialController : Controller
    {
        AmazonData ad = new AmazonData();   
        public PartialViewResult Category()
        {
            return PartialView(ad.CategoryList());
        }

        public PartialViewResult Product()
        {
            return PartialView(ad.ProductsList());
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}