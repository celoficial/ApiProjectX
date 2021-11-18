using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.User;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            GenericResult result = await _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid id)
        {
            GenericResult result = await _userService.FindById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserRequest userEntity)
        {
            GenericResult result = await _userService.Create(userEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(UserRequest userEntity)
        {
            GenericResult result = await _userService.Update(userEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(UserDeleteRequest userEntity)
        {
            if (!String.IsNullOrEmpty(userEntity.Id.ToString()))
            {
                GenericResult result = await _userService.Delete(userEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }

    }
}
