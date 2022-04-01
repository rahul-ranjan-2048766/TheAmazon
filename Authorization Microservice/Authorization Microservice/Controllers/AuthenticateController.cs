using Authorization_Microservice.Helpers;
using Authorization_Microservice.Models;
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
    public class AuthenticateController : ControllerBase
    {
        private readonly IJwtAuthenticateManager manager;
        public AuthenticateController(IJwtAuthenticateManager jwtAuthenticateManager)
        {
            manager = jwtAuthenticateManager;
        }

        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCred userCred)
        {
            try
            {
                var response = manager.Authenticate(userCred);
                if (response == null)
                    return BadRequest(new { message = "Authentication failed!!!! Please check your user credentials...." });
                return Ok(response);
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception...." });
            }
        }
    }
}
