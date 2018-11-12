using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataBindingDemo.Models;

namespace DataBindingDemo.Controllers
{
    public class TestCategoryProductController : Controller
    {
        CategoryData cd = new CategoryData();
        ProductsData pd = new ProductsData();
       
        public ViewResult Category()
        {
            List<Category> categories = cd.CategoryList.ToList();
            return View(categories);
        }

        public ViewResult Products(int id)
        {
            List<Product> products = pd.ProductList.Where(x => x.CategoryId == id).ToList();
            return View(products);
        }
    }
}