using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentPostController : ControllerBase
    {
        private readonly IDepartmentPostService _departmentPostService;

        public DepartmentPostController(IDepartmentPostService departmentPostService)
        {
            _departmentPostService = departmentPostService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(DepartmentPost entity)
        {
            await _departmentPostService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _departmentPostService.FindAsync(id);
            if (entity == null) return NotFound("DepartmentPost not found.");
            await _departmentPostService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<DepartmentPost>> FindAsync(int id)
        {
            var result = await _departmentPostService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<DepartmentPost>>> GetAllAsync()
        {
            return await _departmentPostService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<DepartmentPost>>> GetAllAsync([FromQuery] Expression<Func<DepartmentPost, bool>> expression)
        {
            return await _departmentPostService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] DepartmentPost entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _departmentPostService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("DepartmentPost not found.");

            await _departmentPostService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllDepartmentPostByIncludeAsync")]
        public async Task<ActionResult<List<DepartmentPost>>> GetAllDepartmentPostByIncludeAsync()
        {
            return await _departmentPostService.GetAllDepartmentPostByIncludeAsync();
        }

        [HttpGet("GetDepartmentPostByIncludeAsync/{id}")]
        public async Task<ActionResult<DepartmentPost>> GetDepartmentPostByIncludeAsync(int id)
        {
            return await _departmentPostService.GetDepartmentPostByIncludeAsync(id);
        }

        [HttpGet("GetSomeDepartmentPostByIncludeAsync")]
        public async Task<ActionResult<List<DepartmentPost>>> GetSomeDepartmentPostByIncludeAsync([FromQuery] Expression<Func<DepartmentPost, bool>> expression)
        {
            return await _departmentPostService.GetSomeDepartmentPostByIncludeAsync(expression);
        }
    }
}
