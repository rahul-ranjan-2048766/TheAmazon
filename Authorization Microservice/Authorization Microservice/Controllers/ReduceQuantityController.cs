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
    public class ReduceQuantityController : ControllerBase
    {
        private readonly IProductService service;
        public ReduceQuantityController(IProductService productService)
        {
            service = productService;
        }

        [AllowAnonymous]
        [HttpDelete("ReduceQuantity/{ProductId}/{Quantity}")]
        public IActionResult ReduceQuantity(int ProductId, int Quantity)
        {
            try
            {
                var product = service.GetProducts().FirstOrDefault(x => x.Id == ProductId);
                product.Quantity = product.Quantity - Quantity;
                product.Count += 1;
                service.UpdateProduct(product);
                return Ok(new { message = "The product quantity has been reduced successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. The MSSQL image of docker is not operational." });
            }
        }

        [AllowAnonymous]
        [HttpGet("IncreaseQuantity/{ProductId}/{Quantity}")]
        public IActionResult IncreaseQuantity(int ProductId, int Quantity)
        {
            try
            {
                var product = service.GetProductById(ProductId);
                product.Quantity += Quantity;
                service.UpdateProduct(product);
                return Ok(new { message = "The product quantity has been increased successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. The MSSQL image of docker is not operational." });
            }
        }
    }
}
