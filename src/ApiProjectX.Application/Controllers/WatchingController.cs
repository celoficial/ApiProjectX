using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/watching")]
    [ApiController]
    public class WatchingController : ControllerBase
    {
        private readonly IWatchingService _watchingService;

        public WatchingController(IWatchingService watchingService)
        {
            _watchingService = watchingService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IEnumerable<WatchingEntity> result = await _watchingService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid id)
        {
            WatchingEntity result = await _watchingService.FindById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(WatchingEntity watchingEntity)
        {
            WatchingEntity result = await _watchingService.Create(watchingEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(WatchingEntity watchingEntity)
        {
            Task result = await _watchingService.Update(watchingEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(WatchingEntity watchingEntity)
        {
            if (!String.IsNullOrEmpty(watchingEntity.Id.ToString()))
            {
                Task result = await _watchingService.Delete(watchingEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }

    }
}
