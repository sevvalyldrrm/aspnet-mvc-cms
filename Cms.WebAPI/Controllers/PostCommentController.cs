using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostCommentController : ControllerBase
    {
        private readonly IPostCommentService _postCommentService;

        public PostCommentController(IPostCommentService postCommentService)
        {
            _postCommentService = postCommentService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(PostComment entity)
        {
            await _postCommentService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _postCommentService.FindAsync(id);
            if (entity == null) return NotFound("PostComment not found.");
            await _postCommentService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<PostComment>> FindAsync(int id)
        {
            var result = await _postCommentService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<PostComment>>> GetAllAsync()
        {
            return await _postCommentService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<PostComment>>> GetAllAsync([FromQuery] Expression<Func<PostComment, bool>> expression)
        {
            return await _postCommentService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] PostComment entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _postCommentService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("PostComment not found.");

            await _postCommentService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllPostCommentsByIncludeAsync")]
        public async Task<ActionResult<List<PostComment>>> GetAllPostCommentsByIncludeAsync()
        {
            return await _postCommentService.GetAllPostCommentsByIncludeAsync();
        }

        [HttpGet("GetPostCommentByIncludeAsync/{id}")]
        public async Task<ActionResult<PostComment>> GetPostCommentByIncludeAsync(int id)
        {
            return await _postCommentService.GetPostCommentByIncludeAsync(id);
        }

        [HttpGet("GetSomePostCommentsByIncludeAsync")]
        public async Task<ActionResult<List<PostComment>>> GetSomePostCommentsByIncludeAsync([FromQuery] Expression<Func<PostComment, bool>> expression)
        {
            return await _postCommentService.GetSomePostCommentsByIncludeAsync(expression);
        }
    }
}
