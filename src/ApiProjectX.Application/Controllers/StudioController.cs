using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{
    [Route("/studio")]
    [ApiController]
    public class StudioController : ControllerBase
    {
        private readonly IStudioService _studioservice;

        public StudioController(IStudioService studioservice)
        {
            _studioservice = studioservice;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            IEnumerable<StudioEntity> result = await _studioservice.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            StudioEntity result = await _studioservice.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(StudioEntity studioEntity)
        {
            StudioEntity result = await _studioservice.Create(studioEntity);
            return Ok(result);

        }

        [HttpPut]
        public async Task<ActionResult> Put(StudioEntity studioEntity)
        {
            Task result = await _studioservice.Update(studioEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(StudioEntity studioEntity)
        {
            if (!String.IsNullOrEmpty(studioEntity.Id.ToString()))
            {
                Task result = await _studioservice.Delete(studioEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }

    }
}
