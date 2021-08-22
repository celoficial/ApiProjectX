using ApiProjectX.Domain.Entities;
using ApiProjectX.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
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
            IEnumerable<CategoryEntity> result = await _categoryService.GetAll();
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult> Get(Guid Id)
        {
            CategoryEntity result = await _categoryService.FindById(Id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CategoryEntity categoryEntity)
        {
            CategoryEntity result = await _categoryService.Create(categoryEntity);
            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> Put(CategoryEntity categoryEntity)
        {
            Task result = await _categoryService.Update(categoryEntity);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(CategoryEntity categoryEntity)
        {
            if (!String.IsNullOrEmpty(categoryEntity.Id.ToString()))
            {
                Task result = await _categoryService.Delete(categoryEntity.Id);
                return Ok(result);
            }
            else
            {
                return BadRequest("Id does not exist");
            }
        }
    }
}
