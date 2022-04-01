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
    public class UserController : ControllerBase
    {
        private readonly IUserService service;
        public UserController(IUserService userService)
        {
            service = userService;
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser([FromBody] User user)
        {
            try
            {
                var users = service.GetUsers().Where(x => x.UserName.Equals(user.UserName)).Count();

                if (users > 0)
                    return BadRequest(new { message = "The username is already taken. Please enter a unique username." });

                service.AddUser(user);
                return Ok(new { message = "The user is saved successfully in the database." });
            }
            catch
            {
                return BadRequest(new { message = "The username is already taken. Please enter a unique username." });
            }
        }

        [HttpDelete("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                service.DeleteUser(id);
                return Ok(new { message = "The user having id " + id + " has been deleted from the database successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception as the user having id " + id + " does not exist in the database." });
            }
        }

        [HttpGet("GetUserById/{id}")]
        public IActionResult GetUserById(int id)
        {
            try
            {
                var user = service.GetUserById(id);
                return Ok(user);
            }
            catch
            {
                return BadRequest(new { message = "The user having id " + id + " does not exist in the database." });
            }
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            try
            {
                var users = service.GetUsers();
                return Ok(users);
            }
            catch
            {
                return BadRequest(new { message = "The MSSQL container of Docker is not operational." });
            }
        }

        [Authorize]
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser([FromBody] User user)
        {
            try
            {
                service.UpdateUser(user);
                return Ok(new { message = "The user has been updated successfully." });
            }
            catch(SystemException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
