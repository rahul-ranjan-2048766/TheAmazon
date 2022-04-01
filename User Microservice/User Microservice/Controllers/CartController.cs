using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Models;
using User_Microservice.Services;

namespace User_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService service;
        public CartController(ICartService cartService)
        {
            service = cartService;
        }

        [Authorize]
        [HttpPost("AddCart")]
        public IActionResult AddCart([FromBody] Cart cart)
        {
            try
            {
                cart.Status = "Not Delivered";
                service.AddCart(cart);
                return Ok(new { message = "The cart is successfully added to the database." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised not to define the property id of the JSON body." });
            }
        }

        [AllowAnonymous]
        [HttpDelete("DeleteCart/{id}")]
        public IActionResult DeleteCart(int id)
        {
            try
            {
                service.DeleteCart(id);
                return Ok(new { message = "The cart has been deleted successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception as the cart having id " + id + " does not exist in the database." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetCartById/{id}")]
        public IActionResult GetCartById(int id)
        {
            try
            {
                var cart = service.GetCartById(id);
                return Ok(cart);
            }
            catch
            {
                return BadRequest(new { message = "The cart having id " + id + " does not exist in the databse." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetCarts")]
        public IActionResult GetCarts()
        {
            try
            {
                var carts = service.GetCarts();
                return Ok(carts);
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. Perhaps MSSQL image/container of docker is not working properly." });
            }
        }

        [HttpPut("UpdateCart")]
        public IActionResult UpdateCart([FromBody] Cart cart)
        {
            try
            {
                service.UpdateCart(cart);
                return Ok(new { message = "The cart having id " + cart.Id + " has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The cart having id " + cart.Id + " does not exist in the database and the system has thrown an exception." });
            }
        }
    }
}
