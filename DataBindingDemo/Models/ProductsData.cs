using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingDemo.Models
{
    public class ProductsData
    {
        List<Product> Products = new List<Product>()
        {
            new Product{ProductId=1,Name="Samsung TV",Price=3400.53,Photo="~/Images/tv.jpg"},
            new Product{ProductId=2,Name="Nike Shoe",Price=4200.41,Photo="~/Images/shoe.png"}
        };

        public IEnumerable<Product>
         ProductList
        {
            get
            {
                return Products;
            }
        }
    }
}