using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{

    [Route("/author")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _authorService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _authorService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(AuthorRequest authorEntity)
        {
            GenericResult result = await _authorService.Create(authorEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(AuthorRequest authorEntity)
        {
            GenericResult result = await _authorService.Update(authorEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(AuthorRequest authorEntity)
        {
            if (!String.IsNullOrEmpty(authorEntity.Id.ToString())) 
            {
                GenericResult result = await _authorService.Delete(authorEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
