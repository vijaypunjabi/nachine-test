using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataTableSample2.IService;
using DataTableSample2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataTableSample2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService = null;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _productService.GetProducts();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productService.GetById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void SaveOrUpdate([FromForm] Product product)
        {
            if (product.ProductId == 0) _productService.Save(product);
            else _productService.Update(product);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return _productService.Delete(id);
        }
    }
}
