using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentBlogController : ControllerBase
    {
        private readonly IDepartmentBlogService _departmentBlogService;

        public DepartmentBlogController(IDepartmentBlogService departmentBlogService)
        {
            _departmentBlogService = departmentBlogService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(DepartmentBlog entity)
        {
            await _departmentBlogService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _departmentBlogService.FindAsync(id);
            if (entity == null) return NotFound("DepartmentBlog not found.");
            await _departmentBlogService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<DepartmentBlog>> FindAsync(int id)
        {
            var result = await _departmentBlogService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<DepartmentBlog>>> GetAllAsync()
        {
            return await _departmentBlogService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<DepartmentBlog>>> GetAllAsync([FromQuery] Expression<Func<DepartmentBlog, bool>> expression)
        {
            return await _departmentBlogService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] DepartmentBlog entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _departmentBlogService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("DepartmentBlog not found.");

            await _departmentBlogService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllDepartmentBlogByIncludeAsync")]
        public async Task<ActionResult<List<DepartmentBlog>>> GetAllDepartmentBlogByIncludeAsync()
        {
            return await _departmentBlogService.GetAllDepartmentBlogByIncludeAsync();
        }

        [HttpGet("GetDepartmentBlogByIncludeAsync/{id}")]
        public async Task<ActionResult<DepartmentBlog>> GetDepartmentBlogByIncludeAsync(int id)
        {
            return await _departmentBlogService.GetDepartmentBlogByIncludeAsync(id);
        }

        [HttpGet("GetSomeDepartmentBlogByIncludeAsync")]
        public async Task<ActionResult<List<DepartmentBlog>>> GetSomeDepartmentBlogByIncludeAsync([FromQuery] Expression<Func<DepartmentBlog, bool>> expression)
        {
            return await _departmentBlogService.GetSomeDepartmentBlogByIncludeAsync(expression);
        }
    }
}
