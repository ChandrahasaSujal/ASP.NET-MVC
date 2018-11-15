using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBindingDemo.Models;

namespace DataBindingDemo.Controllers
{
    public class JsonDemoController : Controller
    {
        AmazonData ad = new AmazonData();
        public JsonResult Index()
        {
            return Json(ad.ProductsList(),JsonRequestBehavior.AllowGet);
        }
    }
}