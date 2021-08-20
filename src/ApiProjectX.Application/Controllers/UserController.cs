using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IEnumerable<UserEntity> result = await _userService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid id)
        {
            UserEntity result = await _userService.FindById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(UserEntity userEntity)
        {
            UserEntity result = await _userService.Create(userEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(UserEntity userEntity)
        {
            Task result = await _userService.Update(userEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(UserEntity userEntity)
        {
            if (!String.IsNullOrEmpty(userEntity.Id.ToString()))
            {
                Task result = await _userService.Delete(userEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }

    }
}
