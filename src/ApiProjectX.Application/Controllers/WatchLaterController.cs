using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{

    [Route("/watch-later")]
    [ApiController]
    public class WatchLaterController : ControllerBase
    {
        private readonly IWatchLaterService _watchLaterService;

        public WatchLaterController(IWatchLaterService watchLaterService)
        {
            _watchLaterService = watchLaterService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IEnumerable<WatchLaterEntity> result = await _watchLaterService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            WatchLaterEntity result = await _watchLaterService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(WatchLaterEntity watchLaterEntity)
        {
            WatchLaterEntity result = await _watchLaterService.Create(watchLaterEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(WatchLaterEntity watchLaterEntity)
        {
            Task result = await _watchLaterService.Update(watchLaterEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(WatchLaterEntity watchLaterEntity)
        {
            if (!String.IsNullOrEmpty(watchLaterEntity.Id.ToString()))
            {
                Task result = await _watchLaterService.Delete(watchLaterEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
