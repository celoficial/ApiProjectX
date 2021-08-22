using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/anime")]
    [ApiController]
    public class AnimeController : ControllerBase
    {
        private readonly IAnimeService _animeservice;

        public AnimeController(IAnimeService animeservice)
        {
            _animeservice = animeservice;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _animeservice.GetAllResponse();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            AnimeEntity result = await _animeservice.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(AnimeEntity animeEntity)
        {
            AnimeEntity result = await _animeservice.Create(animeEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(AnimeEntity animeEntity)
        {
            Task result = await _animeservice.Update(animeEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(AnimeEntity animeEntity)
        {
            if (!String.IsNullOrEmpty(animeEntity.Id.ToString()))
            {
                Task result = await _animeservice.Delete(animeEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist.");
            }
        }
    }
}
