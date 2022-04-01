using Authorization_Microservice.Models;
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
    public class AdminController : ControllerBase
    {
        private readonly IAdminService service;
        public AdminController(IAdminService adminService)
        {
            service = adminService;
        }

        [HttpPost("AddAdmin")]
        public IActionResult AddAdmin([FromBody] Admin admin)
        {
            try
            {
                service.AddAdmin(admin);
                return Ok(new { message = "The admin is successfully added to the database." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised not to define the property id of the JSON body." });
            }
        }

        [HttpDelete("DeleteAdmin/{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            try
            {
                service.DeleteAdmin(id);
                return Ok(new { message = "The admin having id " + id  + " has been deleted from the database successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The admin having id " + id + " does not exist in the database and the system has thrown an exception." });
            }
        }

        [HttpGet("GetAdminById/{id}")]
        public IActionResult GetAdminById(int id)
        {
            try
            {
                var admin = service.GetAdminById(id);
                return Ok(admin);
            }
            catch
            {
                return BadRequest(new { message = "The admin having id " + id + " does not exist in the database." });
            }
        }

        [HttpGet("GetAdmins")]
        public IActionResult GetAdmins()
        {
            try
            {
                var admins = service.GetAdmins();
                return Ok(admins);
            }
            catch
            {
                return BadRequest(new { message = "The MSSQL image of docker is not operational." });
            }
        }

        [HttpPut("UpdateAdmin")]
        public IActionResult UpdateAdmin([FromBody] Admin admin)
        {
            try
            {
                service.UpdateAdmin(admin);
                return Ok(new { message = "The admin has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The admin having id " + admin.Id + " does not exist in the database." });
            }
        }
    }
}
