using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Services;

namespace User_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateCartController : ControllerBase
    {
        private readonly ICartService service;
        public UpdateCartController(ICartService cartService)
        {
            service = cartService;
        }

        [AllowAnonymous]
        [HttpGet("UpdateCart/{CartId}")]
        public IActionResult UpdateCart(int CartId)
        {
            try
            {
                var cart = service.GetCartById(CartId);
                if(cart.Status.ToLower().Equals("delivered"))
                {
                    cart.Status = "Not Delivered";
                }
                else
                {
                    cart.Status = "Delivered";
                }
                service.UpdateCart(cart);
                return Ok(new { message = "The cart has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception." });
            }
        }

        [HttpDelete("DeleteCartsByProductId/{ProductId}")]
        public IActionResult DeleteCartsByProductId(int ProductId)
        {
            try
            {
                var carts = service.GetCarts().Where(x => x.ProductId == ProductId).ToList();
                foreach(var cart in carts)
                {
                    service.DeleteCart(cart.Id);
                }
                return Ok(new { message = "The carts having product id " + ProductId + " have been deleted successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception." });
            }
        }
    }
}
