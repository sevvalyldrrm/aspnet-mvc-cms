using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(Category entity)
        {
            await _categoryService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _categoryService.FindAsync(id);
            if (entity == null) return NotFound("Category not found.");
            await _categoryService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<Category>> FindAsync(int id)
        {
            var result = await _categoryService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<Category>>> GetAllAsync()
        {
            return await _categoryService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Category>>> GetAllAsync([FromQuery] Expression<Func<Category, bool>> expression)
        {
            return await _categoryService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Category entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _categoryService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("Category not found.");

            await _categoryService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllCategoryByIncludeAsync")]
        public async Task<ActionResult<List<Category>>> GetAllCategoryByIncludeAsync()
        {
            return await _categoryService.GetAllCategoryByIncludeAsync();
        }

        [HttpGet("GetCategoryByIncludeAsync/{id}")]
        public async Task<ActionResult<Category>> GetCategoryByIncludeAsync(int id)
        {
            return await _categoryService.GetCategoryByIncludeAsync(id);
        }

        [HttpGet("GetSomeCategoryByIncludeAsync")]
        public async Task<ActionResult<List<Category>>> GetSomeCategoryByIncludeAsync([FromQuery] Expression<Func<Category, bool>> expression)
        {
            return await _categoryService.GetSomeCategoryByIncludeAsync(expression);
        }
    }
}
