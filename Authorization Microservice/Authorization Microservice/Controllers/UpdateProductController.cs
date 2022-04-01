using Authorization_Microservice.Services;
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
    public class UpdateProductController : ControllerBase
    {
        private readonly IProductService service;
        public UpdateProductController(IProductService productService)
        {
            service = productService;
        }

        [HttpGet("UpdateCount/{ProductId}")]
        public IActionResult UpdateCount(int ProductId)
        {
            try
            {
                var product = service.GetProductById(ProductId);
                if(product.Count > 0)
                    product.Count -= 1;
                service.UpdateProduct(product);
                return Ok(new { message = "The product has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. The MSSQL image of docker is not operational." });
            }
        }
    }
}
