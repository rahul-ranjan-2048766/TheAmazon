using Authorization_Microservice.Models;
using Authorization_Microservice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Authorization_Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MetaController : ControllerBase
    {
        private readonly IMetaDataService service;
        public MetaController(IMetaDataService metaDataService)
        {
            service = metaDataService;
        }

        [HttpPost("AddMeta")]
        public IActionResult AddMeta([FromBody] MetaData data)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44368/api/UpdateCart/");
                    var responseTask = client.GetAsync("UpdateCart/" + data.CartId);
                    responseTask.Wait();
                }

                var cart = new Cart();
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:44368/api/Cart/");
                    var responseTask = client.GetAsync("GetCartById/" + data.CartId);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var reader = result.Content.ReadAsAsync<Cart>();
                        reader.Wait();
                        cart = reader.Result;
                    }
                }

                if(cart.Status.ToLower().Equals("delivered"))
                {
                    service.AddMeta(data);
                }
                else
                {
                    var meta = service.GetMetas().FirstOrDefault(x => x.CartId == data.CartId);
                    service.DeleteMeta(meta.Id);
                }

                return Ok(new { message = "The database successfully reflects the change." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised not to define the property id of the JSON body." });
            }
        }

        [HttpDelete("DeleteMeta/{id}")]
        public IActionResult DeleteMeta(int id)
        {
            try
            {
                service.DeleteMeta(id);
                return Ok(new { message = "The meta data has been deleted successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. The meta data does not exist." });
            }
        }

        [HttpGet("GetMetaById/{id}")]
        public IActionResult GetMetaById(int id)
        {
            try
            {
                var data = service.GetMetaById(id);
                return Ok(data);
            }
            catch
            {
                return BadRequest(new { message = "The meta data does not exist in the database and the system has thrown an exception." });
            }
        }

        [AllowAnonymous]
        [HttpGet("GetMetas")]
        public IActionResult GetMetas()
        {
            try
            {
                var data = service.GetMetas();
                return Ok(data);
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception." });
            }
        }

        [HttpPut]
        public IActionResult UpdateMeta([FromBody] MetaData data)
        {
            try
            {
                service.UpdateMeta(data);
                return Ok(new { message = "The data has been updated successfully." });
            }
            catch
            {
                return BadRequest(new { message = "The system has thrown an exception. It is advised to properly define the property id of the JSON body." });
            }
        }
    }
}
