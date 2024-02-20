using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(Post entity)
        {
            await _postService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _postService.FindAsync(id);
            if (entity == null) return NotFound("Post not found.");
            await _postService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<Post>> FindAsync(int id)
        {
            var result = await _postService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Post>>> GetAllAsync()
        {
            return await _postService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Post>>> GetAllAsync([FromQuery] Expression<Func<Post, bool>> expression)
        {
            return await _postService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Post entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _postService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("Post not found.");

            await _postService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllPostsByIncludeAsync")]
        public async Task<ActionResult<List<Post>>> GetAllPostsByIncludeAsync()
        {
            return await _postService.GetAllPostsByIncludeAsync();
        }

        [HttpGet("GetPostByIncludeAsync/{id}")]
        public async Task<ActionResult<Post>> GetPostByIncludeAsync(int id)
        {
            return await _postService.GetPostByIncludeAsync(id);
        }

        [HttpGet("GetSomePostsByIncludeAsync")]
        public async Task<ActionResult<List<Post>>> GetSomePostsByIncludeAsync([FromQuery] Expression<Func<Post, bool>> expression)
        {
            return await _postService.GetSomePostsByIncludeAsync(expression);
        }
    }
}
