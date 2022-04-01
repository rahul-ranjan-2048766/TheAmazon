using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User_Microservice.Helpers;
using User_Microservice.Models;
using User_Microservice.Services;

namespace User_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IJwtAuthenticateManager manager;
        private readonly ICartService service;

        public AuthenticateController(IJwtAuthenticateManager authenticateManager, ICartService cartService)
        {
            manager = authenticateManager;
            service = cartService;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            try
            {
                var response = manager.Authenticate(userCred);
                if(response == null)
                {
                    return BadRequest(new { message = "Please check your user credentials...." });
                }
                return Ok(response);
            }
            catch
            {
                return BadRequest("The system has thrown an exception.");
            }
        }

        [HttpDelete("DeleteCartsByUserId/{UserId}")]
        public IActionResult DeleteCartsByUserId(int UserId)
        {
            try
            {
                var carts = service.GetCarts().Where(x => x.UserId == UserId).ToList();
                
                foreach(var cart in carts)
                {
                    service.DeleteCart(cart.Id);
                }
                return Ok(new { message = "The carts are deleted successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception." });
            }
        }
    }
}
