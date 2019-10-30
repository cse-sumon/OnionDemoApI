using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OnionDemo.Models;

namespace OnionDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
                _productService = productService;
        }

        public ProductController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ProductViewModel> model = new List<ProductViewModel>();
            _productService.GetProducts().ToList().ForEach(u =>
            {
                ProductViewModel product = new ProductViewModel
                {
                    Id = u.Id,
                    Name = u.Name,
                    Price = u.Price,
                };
                model.Add(product);
            });

            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            List<ProductViewModel> model = new List<ProductViewModel>();
            return Ok(_productService.GetProduct(id));
        }

        [HttpPost]
        public ActionResult Post(ProductViewModel model)
        {
            Product productEntity = new Product
            {
                Name = model.Name,
                Price = model.Price,
            };
            _productService.InsertProduct(productEntity);
            return Ok();
        }

        [HttpPut]
        public ActionResult Put(ProductViewModel model)
        {
            Product productEntity = _productService.GetProduct(model.Id);
            productEntity.Name = model.Name;
            productEntity.Price = model.Price;
            
            _productService.UpdateProduct(productEntity);
            if (productEntity.Id > 0)
            {
                return Ok();
            }
            return BadRequest(model);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return Ok();
        }
    }
}