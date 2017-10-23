using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.OData;

namespace API_Test.Controllers
{
    public class ProductsController : ODataController
    {
        // GET: Products
        public List<Product> Index()
        {
            return new List<Product> {
                new Product { Id= 1, Name = "AAA" },
                new Product { Id= 2, Name = "AAA" }
            };
        }
    }
}