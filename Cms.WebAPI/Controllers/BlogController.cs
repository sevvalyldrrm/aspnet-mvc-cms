using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(Blog entity)
        {
            await _blogService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _blogService.FindAsync(id);
            if (entity == null) return NotFound("Blog not found.");
            await _blogService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<Blog>> FindAsync(int id)
        {
            var result = await _blogService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Blog>>> GetAllAsync()
        {
            return await _blogService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Blog>>> GetAllAsync([FromQuery] Expression<Func<Blog, bool>> expression)
        {
            return await _blogService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Blog entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _blogService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("Blog not found.");

            await _blogService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllBlogsByIncludeAsync")]
        public async Task<ActionResult<List<Blog>>> GetAllBlogsByIncludeAsync()
        {
            return await _blogService.GetAllBlogsByIncludeAsync();
        }

        [HttpGet("GetBlogByIncludeAsync/{id}")]
        public async Task<ActionResult<Blog>> GetBlogByIncludeAsync(int id)
        {
            return await _blogService.GetBlogByIncludeAsync(id);
        }

        [HttpGet("GetSomeBlogsByIncludeAsync")]
        public async Task<ActionResult<List<Blog>>> GetSomeBlogsByIncludeAsync([FromQuery] Expression<Func<Blog, bool>> expression)
        {
            return await _blogService.GetSomeBlogsByIncludeAsync(expression);
        }
    }
}
