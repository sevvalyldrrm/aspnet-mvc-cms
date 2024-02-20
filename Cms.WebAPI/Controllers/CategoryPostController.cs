using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryPostController : ControllerBase
    {
        private readonly ICategoryPostService _categoryPostService;

        public CategoryPostController(ICategoryPostService categoryPostService)
        {
            _categoryPostService = categoryPostService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(CategoryPost entity)
        {
            await _categoryPostService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _categoryPostService.FindAsync(id);
            if (entity == null) return NotFound("CategoryPost not found.");
            await _categoryPostService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<CategoryPost>> FindAsync(int id)
        {
            var result = await _categoryPostService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<CategoryPost>>> GetAllAsync()
        {
            return await _categoryPostService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<CategoryPost>>> GetAllAsync([FromQuery] Expression<Func<CategoryPost, bool>> expression)
        {
            return await _categoryPostService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] CategoryPost entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _categoryPostService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("CategoryPost not found.");

            await _categoryPostService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllCategoryPostByIncludeAsync")]
        public async Task<ActionResult<List<CategoryPost>>> GetAllCategoryPostByIncludeAsync()
        {
            return await _categoryPostService.GetAllCategoryPostByIncludeAsync();
        }

        [HttpGet("GetCategoryPostByIncludeAsync/{id}")]
        public async Task<ActionResult<CategoryPost>> GetCategoryPostByIncludeAsync(int id)
        {
            return await _categoryPostService.GetCategoryPostByIncludeAsync(id);
        }

        [HttpGet("GetSomeCategoryPostByIncludeAsync")]
        public async Task<ActionResult<List<CategoryPost>>> GetSomeCategoryPostByIncludeAsync([FromQuery] Expression<Func<CategoryPost, bool>> expression)
        {
            return await _categoryPostService.GetSomeCategoryPostByIncludeAsync(expression);
        }
    }
}
