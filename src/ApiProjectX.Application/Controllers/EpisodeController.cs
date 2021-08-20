using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace ApiProjectX.Application.Controllers
{
    [Route("/episode")]
    [ApiController]
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeService _episodeservice;

        public EpisodeController(IEpisodeService episodeservice)
        {
            _episodeservice = episodeservice;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IEnumerable<EpisodeEntity> result = await _episodeservice.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            EpisodeEntity result = await _episodeservice.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(EpisodeEntity episodeEntity)
        {
            EpisodeEntity result = await _episodeservice.Create(episodeEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EpisodeEntity episodeEntity)
        {
            Task result = await _episodeservice.Update(episodeEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(EpisodeEntity episodeEntity)
        {
            if (!String.IsNullOrEmpty(episodeEntity.Id.ToString()))
            {
                Task result = await _episodeservice.Delete(episodeEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }

        }

    }
}
