using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingDemo.Models
{
    public class AmazonData
    {
        List<CategoryPartialDemo> categories = new List<CategoryPartialDemo>()
        {
            new CategoryPartialDemo{CategoryId=1,CategoryName="Electronics"},
            new CategoryPartialDemo{CategoryId=2,CategoryName="Shoes"}
        };

        List<ProductPartialDemo> products = new List<ProductPartialDemo>()
        {
            new ProductPartialDemo{ProductId=1,ProductName="Samsung TV"},
            new ProductPartialDemo{ProductId=2,ProductName="Nike Shoe"},
            new ProductPartialDemo{ProductId=3,ProductName="Mobile"},
            new ProductPartialDemo{ProductId=4,ProductName="Lee Cooper Boots"}
        };

        public IEnumerable<CategoryPartialDemo> CategoryList()
        {
            return categories;
        }

        public IEnumerable<ProductPartialDemo> ProductsList()
        {
            return products;
        }

    }
}