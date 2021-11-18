using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Episode;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
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
            GenericResult result = await _episodeservice.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _episodeservice.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(EpisodeRequest episodeEntity)
        {
            GenericResult result = await _episodeservice.Create(episodeEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(EpisodeRequest episodeEntity)
        {
            GenericResult result = await _episodeservice.Update(episodeEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(EpisodeDeleteRequest episodeEntity)
        {
            if (!String.IsNullOrEmpty(episodeEntity.Id.ToString()))
            {
                GenericResult result = await _episodeservice.Delete(episodeEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }

        }

    }
}
