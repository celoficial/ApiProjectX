using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Season;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/season")]
    [ApiController]
    public class SeasonController : ControllerBase
    {
        private readonly ISeasonService _seasonService;

        public SeasonController(ISeasonService seasonService)
        {
            _seasonService = seasonService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            GenericResult result = await _seasonService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _seasonService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(SeasonRequest seasonEntity)
        {
            GenericResult result = await _seasonService.Create(seasonEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(SeasonRequest seasonEntity)
        {
            GenericResult result = await _seasonService.Update(seasonEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(SeasonDeleteRequest seasonEntity)
        {
            if (!String.IsNullOrEmpty(seasonEntity.Id.ToString()))
            {
                GenericResult result = await _seasonService.Delete(seasonEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
