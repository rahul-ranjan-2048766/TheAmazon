using Authorization_Microservice.Models;
using Authorization_Microservice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductService service;
        public ProductController(IProductService productService)
        {
            service = productService;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            try
            {
                service.AddProduct(product);
                return Ok(new { message = "The product is successfully added to the database." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised not to define the property id of the JSON body." });
            }
        }

        [HttpDelete("DeleteProduct/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                service.DeleteProduct(id);
                return Ok(new { message = "The product has been deleted from the database successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The product having id " + id + " does not exist in the database." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetProductsById/{id}")]
        public IActionResult GetProductsById(int id)
        {
            try
            {
                var product = service.GetProductById(id);
                return Ok(product);
            }
            catch
            {
                return BadRequest(new { message = "The product having id " + id + " does not exist in the database." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetProducts")]
        public IActionResult GetProducts()
        {
            try
            {
                var products = service.GetProducts();
                return Ok(products);
            }
            catch
            {
                return BadRequest(new { message = "The MSSQL image of docker is not operational." });
            }
        }

        [HttpPut("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            try
            {
                service.UpdateProduct(product);
                return Ok(new { message = "The product is updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised to properly define the property id of the JSON body." });
            }
        }
    }
}
