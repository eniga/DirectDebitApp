using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using DirectDebitApi.Models;
using DirectDebitApi.Services.AppBUnit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectDebitApi.Controllers
{
    [Route("api/[controller]")]
    public class AppBUnitsController : Controller
    {
        private IAppBUnitService service;
        private ILogger<AppBUnitsController> logger;

        public AppBUnitsController(IAppBUnitService service, ILogger<AppBUnitsController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<AppBUnits>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> GetAllAsync()
        {
            try
            {
                var result = await service.GetAllAsync();

                if (result.Any())
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "Database error" });
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppBUnits))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> GetAsync(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var result = await service.GetByIdAsync(id);
                if (result != null)
                    return Ok(result);
                else
                    return NotFound(new Response() { Status = false, Description = "No record found" });
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "Database error" });
            }
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AppBUnits))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PostAsync([FromBody] AppBUnits item)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var exist = await service.GetAsync(x => x.unitname == item.unitname);
                if (exist != null)
                    return Conflict(new Response() { Status = false, Description = "Duplicate record" });
                var result = service.AddAsync(item).Result;
                if (result)
                {
                    var newitem = service.GetAsync(x => x.unitname == item.unitname).Result;
                    return StatusCode(201, newitem);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "Database error" });
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppBUnits))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PutAsync(int id, [FromBody] AppBUnits item)
        {
            if (!ModelState.IsValid || id != item.id)
                return BadRequest();
            try
            {
                var exist = await service.GetByIdAsync(id);
                if (exist != null)
                {
                    var result = service.UpdateAsync(item).Result;
                    return result ? Ok(item) : StatusCode(500, new Response() { Status = false, Description = "Error updating record" });
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "Database error" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            if (!ModelState.IsValid || id < 1)
                return BadRequest();
            try
            {
                var exist = await service.GetByIdAsync(id);
                if (exist != null)
                {
                    var result = service.DeleteAsync(id).Result;
                    return result ? Ok(new Response { Status = true, Description = "Record deleted successfully" })
                        : StatusCode(500, new Response { Status = false, Description = "Error deleting the record" });
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "Database error" });
            }
        }
    }
}
