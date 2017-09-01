using HyperMedia.SampleWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HyperMedia.SampleWebAPI.Controllers
{
    /// <summary>
    ///
    /// </summary>
    /// <remarks>ASP.NET Core MVC Attribute Routing: https://codeopinion.com/asp-net-core-mvc-attribute-routing/</remarks>
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id:int}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public async Task<IActionResult> Get(int id)
        {
            var m = new ProductModel();
            m.Id = 100;
            m.Name = "test";
            return await Task.FromResult(new OkObjectResult(m));
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="productname"></param>
        /// <returns></returns>
        /// <remarks>matches http://localhost:56778/api/products/GetByName?productname=soto </remarks>
        [HttpGet("GetByName")]
        public async Task<IActionResult> GetByName([FromQuery] string productname)
        {
            var m = new ProductModel();
            m.Id = 100;
            m.Name = productname;
            return await Task.FromResult(new OkObjectResult(m));
        }

        ///// <summary>
        /////
        ///// </summary>
        ///// <param name="productname"></param>
        ///// <returns></returns>
        ///// <remarks>Matches http://localhost:56778/api/products/soto
        ///// but not the http://localhost:56778/api/products?productname=soto </remarks>
        //[HttpGet("{productname:alpha}")]
        //public async Task<IActionResult> GetByName(string productname)
        //{
        //    var m = new ProductModel();
        //    m.Id = 100;
        //    m.Name = productname;
        //    return await Task.FromResult(new OkObjectResult(m));
        //}

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}