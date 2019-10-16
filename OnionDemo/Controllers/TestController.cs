using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using OA.Service;
using OA.Data;
using Microsoft.AspNetCore.Http;

namespace OnionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IProductService _productService;

        public TestController(IProductService productService )
        {
            try
            {
                _productService = productService;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            
            return new string[] { "value1", "value2", "value3", "value4" };
        }
    }
}