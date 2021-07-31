using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<ActionResult> GetAll()
        {
            var result = await _animeservice.GetAll();
            return Ok(result);
        }
    }
}
