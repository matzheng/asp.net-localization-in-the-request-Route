using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.OData;

namespace ODataAPITest.Controllers
{
    public class ProductsController : ODataController
    {
        public List<Models.Product> Get()
        {
            return new List<Models.Product> {
                    new Models.Product { ID = 1, Name="AAA" },
                    new Models.Product { ID = 2, Name="BBB" }
            };
        }
    }
}
