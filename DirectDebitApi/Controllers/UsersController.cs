using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DirectDebitApi.Entities;
using DirectDebitApi.Helpers;
using DirectDebitApi.Models;
using DirectDebitApi.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectDebitApi.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IUserService service;
        private ILogger<UsersController> logger;
        private IEncryptor encryptor;
        private readonly IMapper _mapper;

        public UsersController(IUserService service, ILogger<UsersController> logger, IEncryptor encryptor, IMapper mapper)
        {
            this.service = service;
            this.logger = logger;
            this.encryptor = encryptor;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<Users>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> ListAsync()
        {
            try
            {
                var result = await service.GetAllAsync();

                if (result.Any())
                {
                    var response = _mapper.Map<IEnumerable<Users>, IEnumerable<UserDTO>>(result);
                    return Ok(response);
                }
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                return StatusCode(500, new Response() { Status = false, Description = "System error" });
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Users))]
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
                {
                    var response = _mapper.Map<Users, UserDTO>(result);
                    return Ok(response);
                }
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
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Users))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(Response))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PostAsync([FromBody] Users item)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            try
            {
                var exist = await service.GetAsync(x => x.email == item.email);
                if (exist != null)
                    return Conflict(new Response() { Status = false, Description = "Duplicate record" });
                // encrypt password before database scan
                item.password = encryptor.EncryptAes(item.password);
                var result = await service.AddAsync(item);
                if (result)
                {
                    var newitem = await service.GetAsync(x => x.email == item.email);
                    var response = _mapper.Map<Users, UserDTO>(newitem);
                    return StatusCode(201, response);
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
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Users))]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Response))]
        public async Task<ActionResult> PutAsync(int id, [FromBody] Users item)
        {
            if (!ModelState.IsValid || id != item.id)
                return BadRequest();
            try
            {
                var exist = await service.GetByIdAsync(id);
                if (exist != null)
                {
                    item.password = exist.password;
                    var result = await service.UpdateAsync(item);
                    var response = _mapper.Map<Users, UserDTO>(item);
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
