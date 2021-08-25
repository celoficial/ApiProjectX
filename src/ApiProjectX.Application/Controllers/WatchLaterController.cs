using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.WatchLater;
using ApiProjectX.Domain.Responses;
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
            var result = await _watchLaterService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _watchLaterService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(WatchLaterRequest watchLaterEntity)
        {
            GenericResult result = await _watchLaterService.Create(watchLaterEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(WatchLaterRequest watchLaterEntity)
        {
            GenericResult result = await _watchLaterService.Update(watchLaterEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(WatchLaterRequest watchLaterEntity)
        {
            if (!String.IsNullOrEmpty(watchLaterEntity.Id.ToString()))
            {
                GenericResult result = await _watchLaterService.Delete(watchLaterEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
