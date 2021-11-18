using ApiProjectX.Domain.Interfaces.Services;
using ApiProjectX.Domain.Requests.Category;
using ApiProjectX.Domain.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace ApiProjectX.Application.Controllers
{

    [Route("/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            GenericResult result = await _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            GenericResult result = await _categoryService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CategoryRequest categoryEntity)
        {
            GenericResult result = await _categoryService.Create(categoryEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CategoryRequest categoryEntity)
        {
            GenericResult result = await _categoryService.Update(categoryEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(CategoryDeleteRequest categoryEntity)
        {
            if (!String.IsNullOrEmpty(categoryEntity.Id.ToString()))
            {
                GenericResult result = await _categoryService.Delete(categoryEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
