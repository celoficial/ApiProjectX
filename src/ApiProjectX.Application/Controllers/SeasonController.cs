using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            IEnumerable<SeasonEntity> result = await _seasonService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            var result = await _seasonService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(SeasonEntity seasonEntity)
        {
            var result = await _seasonService.Create(seasonEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(SeasonEntity seasonEntity)
        {
            var result = await _seasonService.Update(seasonEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(SeasonEntity seasonEntity)
        {
            if (!String.IsNullOrEmpty(seasonEntity.Id.ToString()))
            {
                var result = await _seasonService.Delete(seasonEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
