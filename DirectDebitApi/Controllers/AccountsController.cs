using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using DirectDebitApi.Services.Account;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectDebitApi.Controllers
{
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private IAccountService service;

        public AccountsController(IAccountService _service)
        {
            service = _service;
        }

        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Accounts>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public ActionResult Get()
        {
            var result = service.GetAllAsync().Result;

            if (result.Any())
                return Ok(result);
            else
                return NoContent();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accounts))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult Get(int id)
        {
            var result = service.GetByIdAsync(id).Result;
            if (result.id.Equals(id))
                return Ok(result);
            else
                return NotFound();
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Accounts))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Post([FromBody] Accounts item)
        {
            var result = service.AddAsync(item).Result;
            if (result)
                return CreatedAtAction(nameof(Get), new { id = item.id }, item);
            else
                return BadRequest();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accounts))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Put(int id, [FromBody] Accounts item)
        {
            var exist = service.GetByIdAsync(id).Result;
            if (exist.id > 0)
            {
                var result = service.UpdateAsync(item).Result;
                return result ? Ok() : StatusCode(500);
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Accounts))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult Delete(int id)
        {
            var exist = service.GetByIdAsync(id).Result;
            if (exist.id > 0)
            {
                var result = service.DeleteAsync(id).Result;
                return result ? Ok() : StatusCode(500);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
