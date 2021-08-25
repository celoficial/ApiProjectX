using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Watch;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{

    [Route("/watch-later")]
    [ApiController]
    public class WatchController : ControllerBase
    {
        private readonly IWatchService _watchService;

        public WatchController(IWatchService watchService)
        {
            _watchService = watchService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var result = await _watchService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _watchService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(WatchRequest watchEntity)
        {
            GenericResult result = await _watchService.Create(watchEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(WatchRequest watchEntity)
        {
            GenericResult result = await _watchService.Update(watchEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(WatchRequest watchEntity)
        {
            if (!String.IsNullOrEmpty(watchEntity.Id.ToString()))
            {
                GenericResult result = await _watchService.Delete(watchEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
