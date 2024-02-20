using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Cms.Data.Entity;
using System.Linq.Expressions;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(Department entity)
        {
            await _departmentService.AddAsync(entity);
            return CreatedAtAction(nameof(FindAsync), new { id = entity.Id }, entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _departmentService.FindAsync(id);
            if (entity == null) return NotFound("Department not found.");
            await _departmentService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<Department>> FindAsync(int id)
        {
            var result = await _departmentService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<Department>>> GetAllAsync()
        {
            return await _departmentService.GetAllAsync();
        }

        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Department>>> GetAllAsync([FromQuery] Expression<Func<Department, bool>> expression)
        {
            return await _departmentService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Department entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _departmentService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("Department not found.");

            await _departmentService.UpdateAsync(entity);
            return NoContent();
        }

        [HttpGet("GetAllDepartmentByIncludeAsync")]
        public async Task<ActionResult<List<Department>>> GetAllDepartmentByIncludeAsync()
        {
            return await _departmentService.GetAllDepartmentByIncludeAsync();
        }

        [HttpGet("GetDepartmentByIncludeAsync/{id}")]
        public async Task<ActionResult<Department>> GetDepartmentByIncludeAsync(int id)
        {
            return await _departmentService.GetDepartmentByIncludeAsync(id);
        }

        [HttpGet("GetSomeDepartmentByIncludeAsync")]
        public async Task<ActionResult<List<Department>>> GetSomeDepartmentByIncludeAsync([FromQuery] Expression<Func<Department, bool>> expression)
        {
            return await _departmentService.GetSomeDepartmentByIncludeAsync(expression);
        }
    }
}
