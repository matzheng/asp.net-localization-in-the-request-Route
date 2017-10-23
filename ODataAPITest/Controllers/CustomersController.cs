using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using ODataAPITest.Models;
using Microsoft.Data.OData;

namespace ODataAPITest.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using ODataAPITest.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Customer>("Customers");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class CustomersController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Customers
        public List<Customer> Get()
        {
            // validate the query.            

            return new List<Customer> {
                new Customer { ID=1, Addr="shanghai", Name="Jack"},
                new Customer {ID=2, Addr="beijing", Name="Ron" }
            };
        }

        // GET: odata/Customers(5)
        //public IHttpActionResult GetCustomer([FromODataUri] int key, ODataQueryOptions<Customer> queryOptions)
        //{
        //    // validate the query.
        //    try
        //    {
        //        queryOptions.Validate(_validationSettings);
        //    }
        //    catch (ODataException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //    // return Ok<Customer>(customer);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// PUT: odata/Customers(5)
        //public IHttpActionResult Put([FromODataUri] int key, Delta<Customer> delta)
        //{
        //    Validate(delta.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Get the entity here.

        //    // delta.Put(customer);

        //    // TODO: Save the patched entity.

        //    // return Updated(customer);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// POST: odata/Customers
        //public IHttpActionResult Post(Customer customer)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Add create logic here.

        //    // return Created(customer);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// PATCH: odata/Customers(5)
        //[AcceptVerbs("PATCH", "MERGE")]
        //public IHttpActionResult Patch([FromODataUri] int key, Delta<Customer> delta)
        //{
        //    Validate(delta.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    // TODO: Get the entity here.

        //    // delta.Patch(customer);

        //    // TODO: Save the patched entity.

        //    // return Updated(customer);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}

        //// DELETE: odata/Customers(5)
        //public IHttpActionResult Delete([FromODataUri] int key)
        //{
        //    // TODO: Add delete logic here.

        //    // return StatusCode(HttpStatusCode.NoContent);
        //    return StatusCode(HttpStatusCode.NotImplemented);
        //}
    }
}
