using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingDemo.Models
{
    public class ProductsData
    {
        List<Product> products = new List<Product>()
        {
            new Product{ProductId=1,Name="Samsung TV",Price=3400.53,Photo="~/Images/tv.jpg",CategoryId=1},
            new Product{ProductId=2,Name="Nike Shoe",Price=4200.41,Photo="~/Images/shoe.png",CategoryId=1}
        };

        public IEnumerable<Product>
         ProductList
        {
            get
            {
                return products;
            }
        }
    }
}