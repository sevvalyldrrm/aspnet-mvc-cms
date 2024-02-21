using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogCommentController : ControllerBase
    {
        private readonly IBlogCommentService _blogCommentService;

        public BlogCommentController(IBlogCommentService blogCommentService)
        {
            _blogCommentService = blogCommentService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(BlogComment entity)
        {
            await _blogCommentService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _blogCommentService.FindAsync(id);
            if (entity == null) return NotFound("BlogComment not found.");
            await _blogCommentService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<BlogComment>> FindAsync(int id)
        {
            var result = await _blogCommentService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<BlogComment>>> GetAllAsync()
        {
            return await _blogCommentService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<BlogComment>>> GetAllAsync([FromQuery] Expression<Func<BlogComment, bool>> expression)
        {
            return await _blogCommentService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] BlogComment entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _blogCommentService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("BlogComment not found.");

            await _blogCommentService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllBlogCommentsByIncludeAsync")]
        public async Task<ActionResult<List<BlogComment>>> GetAllBlogCommentsByIncludeAsync()
        {
            return await _blogCommentService.GetAllBlogCommentsByIncludeAsync();
        }

        [HttpGet("GetBlogCommentByIncludeAsync/{id}")]
        public async Task<ActionResult<BlogComment>> GetBlogCommentByIncludeAsync(int id)
        {
            return await _blogCommentService.GetBlogCommentByIncludeAsync(id);
        }

        [HttpGet("GetSomeBlogCommentsByIncludeAsync")]
        public async Task<ActionResult<List<BlogComment>>> GetSomeBlogCommentsByIncludeAsync([FromQuery] Expression<Func<BlogComment, bool>> expression)
        {
            return await _blogCommentService.GetSomeBlogCommentsByIncludeAsync(expression);
        }
    }
}
