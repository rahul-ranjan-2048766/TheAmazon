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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService service;
        public CategoryController(ICategoryService categoryService)
        {
            service = categoryService;
        }

        [HttpPost("AddCategory")]
        public IActionResult AddCategory([FromBody] Category category)
        {
            try
            {
                category.CategoryName = category.CategoryName.ToUpper();
                service.AddCategory(category);
                return Ok(new { message = "The category has been added to the datbase successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised not to define the property id of the JSON body." });
            }
        }

        [HttpDelete("DeleteCategory/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            try
            {
                service.DeleteCategory(id);
                return Ok(new { message = "The category has been deleted successfully from the database." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception as the category having id " + id + " does not exist in the database." });
            }
        }

        [HttpGet("GetCategoryById/{id}")]
        public IActionResult GetCategoryById(int id)
        {
            try
            {
                var category = service.GetCategoryById(id);
                return Ok(category);
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception as the property having id " + id + " does not exist in the database." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetCategories")]
        public IActionResult GetCategories()
        {
            try
            {
                var categories = service.GetCategories();
                return Ok(categories);
            }
            catch
            {
                return BadRequest(new { message = "The MSSQL image of docker is not operational." });
            }
        }

        [HttpPut("UpdateCategory")]
        public IActionResult UpdateCategory([FromBody] Category category)
        {
            try
            {
                service.UpdateCategory(category);
                return Ok(new { message = "The category having id " + category.Id + " has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception as the category having property id " + category.Id + " does not exist in the database." });
            }
        }
    }
}
