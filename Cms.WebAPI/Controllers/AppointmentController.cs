using Cms.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using Cms.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Cms.WebAPI.DTOs;
using Cms.Data.Entity.BaseEntites;

namespace Cms.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
       

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
            
        }

       

        [HttpPost("AddAsync")]
        public async Task<IActionResult> AddAsync(Appointment entity)
        {
            await _appointmentService.AddAsync(entity);
            return Ok(entity);
        }

        [HttpDelete("DeleteAsync/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var entity = await _appointmentService.FindAsync(id);
            if (entity == null) return NotFound();
            await _appointmentService.DeleteAsync(entity);
            return NoContent();
        }

        [HttpGet("FindAsync/{id}")]
        public async Task<ActionResult<Appointment>> FindAsync(int id)
        {
            var result = await _appointmentService.FindAsync(id);
            if (result == null) return NotFound();
            return result;
        }

        [HttpGet("GetAllAsync")]
        public async Task<ActionResult<List<Appointment>>> GetAllAsync()
        {
            return await _appointmentService.GetAllAsync();
        }

        
        [HttpGet("GetAllAsyncExpression")]
        public async Task<ActionResult<List<Appointment>>> GetAllAsync([FromQuery] Expression<Func<Appointment, bool>> expression)
        {
            return await _appointmentService.GetAllAsync(expression);
        }

        [HttpPut("UpdateAsync/{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] Appointment entity)
        {
            if (id != entity.Id)
                return BadRequest("ID mismatch");

            var existingEntity = await _appointmentService.FindAsync(id);
            if (existingEntity == null)
                return NotFound("Appointment not found.");

            await _appointmentService.UpdateAsync(entity);
            return NoContent(); // Başarılı bir güncelleme işlemi sonrası NoContent dönülür.
        }

        [HttpGet("GetAllAppointmentsByIncludeAsync")]
        public async Task<ActionResult<List<Appointment>>> GetAllAppointmentsByIncludeAsync()
        {
            return await _appointmentService.GetAllAppointmentsByIncludeAsync();
        }

        [HttpGet("GetAppointmentByIncludeAsync/{id}")]
        public async Task<ActionResult<Appointment>> GetAppointmentByIncludeAsync(int id)
        {
            return await _appointmentService.GetAppointmentByIncludeAsync(id);
        }
    }
}
