using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingDemo.Models
{
    public class CategoryData
    {
        List<Category> categories = new List<Category>()
        {
            new Category{CategoryId=1,CategoryName="Electronic"},
            new Category{CategoryId=2,CategoryName="Shoe"}
        };

        public IEnumerable<Category> 
        CategoryList
        {
            get
            {
                return categories;
            }
        }
    }
}