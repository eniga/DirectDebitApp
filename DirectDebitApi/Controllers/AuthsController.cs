using DirectDebitApi.Entities;
using DirectDebitApi.Helpers;
using DirectDebitApi.Models;
using DirectDebitApi.Services.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DirectDebitApi.Controllers
{
    [Route("api/[controller]")]
    public class AuthsController : Controller
    {
        private IUserService service;
        private IEncryptor encryptor;
        private JwtUtil jwtUtil;

        public AuthsController(IUserService service, IEncryptor _encryptor, JwtUtil _jwtUtil)
        {
            this.service = service;
            encryptor = _encryptor;
            jwtUtil = _jwtUtil;
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Users))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Login([FromBody] LoginRequest request)
        {
            if (request == null)
                return BadRequest(new { Status = false, Description = "Kindly provide email and password" });
            var pwd = encryptor.EncryptAes(request.password);
            var result = service.GetAsync(x => x.email == request.email && x.password == pwd).Result;
            if(result.id > 0)
            {
                //result.token = jwtUtil.GenerateJwtToken(result.id, result.fullname);
                return Ok(result);
            }
            else
            {
                return Unauthorized(new { Status = false, Description = "Invalid Email / Password" });
            }
        }
    }
}
