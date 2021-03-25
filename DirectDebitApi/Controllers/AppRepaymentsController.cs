using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using DirectDebitApi.Models;
using DirectDebitApi.Services.AppRepayment;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectDebitApi.Controllers
{
    [Route("api/[controller]")]
    public class AppRepaymentsController : Controller
    {
        private IAppRepaymentService service;
        private ILogger<AppRepaymentsController> logger;

        public AppRepaymentsController(IAppRepaymentService service, ILogger<AppRepaymentsController> logger)
        {
            this.service = service;
            this.logger = logger;
        }

        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> ListAsync()
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
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }

        [HttpGet("loan")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> ListAsync(string loanid, string repaymentcycle = null)
        {
            try
            {
                if(repaymentcycle == null)
                {
                    var result = await service.GetAllAsync(x => x.loanid == loanid);

                    if (result.Any())
                        return Ok(result);
                    else
                        return NoContent();
                }
                else
                {
                    var result = await service.GetAllAsync(x => x.loanid == loanid && x.repaymentcycle == repaymentcycle);

                    if (result.Any())
                        return Ok(result);
                    else
                        return NoContent();
                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppRepayments))]
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
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(AppRepayments))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PostAsync([FromBody] AppRepayments item)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var result = await service.AddAsync(item);
                if (result)
                {
                    return StatusCode(201, item);
                }
                else
                    return BadRequest();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(AppRepayments))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PutAsync(int id, [FromBody] AppRepayments item)
        {
            if (!ModelState.IsValid || id != item.id)
                return BadRequest();
            try
            {
                var exist = await service.GetByIdAsync(id);
                if (exist != null)
                {
                    var result = await service.UpdateAsync(item);
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
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
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
                    var result = await service.DeleteAsync(id);
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
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }
    }
}
