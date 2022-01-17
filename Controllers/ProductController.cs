using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using NetCoreApi.Models;
using NetCoreApi.Services;

namespace NetCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductService productService = null;
        public ProductController([FromServices] ProductService productService)
        {
            this.productService = productService;
        }

        // GET api/product
        [HttpGet]
        public ActionResult<List<Product>> Get() => Ok(this.productService.GetProducts());

        // GET api/product{idProduct}
        [HttpGet("{idProduct}")]
        public ActionResult<Product> Get(string idProduct) => Ok(this.productService.GetProduct(idProduct));

        // POST api/product
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            this.productService.AddProduct(product);
            return Ok();
        }

        // PUT api/product
        [HttpPut("{idProduct}")]
        public ActionResult Put(string idProduct, [FromBody] Product product)
        {
            this.productService.UpdateProduct(idProduct, product);
            return Ok();
        }

        // DELETE api/product/{idProduct}
        [HttpDelete("{idProduct}")]
        public ActionResult Delete(string idProduct)
        {
            this.productService.DeleteProduct(idProduct);
            return Ok();
        }
    }
}
