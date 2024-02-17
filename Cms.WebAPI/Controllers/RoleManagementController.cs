using Cms.Data.Entity;
using Cms.WebAPI.DTOs;
using Cms.WebAPI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")] // Sadece Admin kullanıcılar erişebilir
    public class RoleManagementController : ControllerBase
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleManagementController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateRole(string roleName)
        {
            if (string.IsNullOrWhiteSpace(roleName))
                return BadRequest("Role name is required.");

            var roleExist = await _roleManager.RoleExistsAsync(roleName);
            if (roleExist)
                return BadRequest("Role already exists.");

            var result = await _roleManager.CreateAsync(new AppRole { Name = roleName });
            if (result.Succeeded)
                return Ok($"Role {roleName} created successfully.");

            return BadRequest(result.Errors);
        }
        [HttpPost("assign")]
        public async Task<IActionResult> AssignRoleToUser(UserRoleUpdateModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
                return NotFound($"User with ID {model.UserId} not found.");

            var roleExist = await _roleManager.RoleExistsAsync(model.Role);
            if (!roleExist)
                return BadRequest($"Role {model.Role} does not exist.");

            var userRoles = await _userManager.GetRolesAsync(user);
            if (userRoles.Contains(model.Role))
                return BadRequest($"User {user.UserName} is already in role {model.Role}.");

            //Kullanicinin sadece tek bir rolu olabilir diyorsan burayi ac.
            //var removeResult = await _userManager.RemoveFromRolesAsync(user, userRoles);
            //if (!removeResult.Succeeded)
            //	return BadRequest(removeResult.Errors);

            var addResult = await _userManager.AddToRoleAsync(user, model.Role);
            if (addResult.Succeeded)
                return Ok($"User {user.UserName} has been assigned to role {model.Role}.");

            return BadRequest(addResult.Errors);
        }
        [HttpGet("list-roles")]
        public IActionResult ListRoles()
        {
            var roles = _roleManager.Roles.ToList();
            return Ok(roles);
        }
        [HttpDelete("delete-role/{roleName}")]
        public async Task<IActionResult> DeleteRole(string roleName)
        {
            var role = await _roleManager.FindByNameAsync(roleName);
            if (role == null)
            {
                return NotFound($"Role  {roleName} not found.");
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return Ok($"Role {role.Name} deleted successfully.");
            }

            return BadRequest(result.Errors);
        }
        [HttpGet("list-users")]
        public IActionResult ListUser()
        {
            var users = _userManager.Users.ToList();
            if (users == null) return NotFound();
            return Ok(users);
        }
        [HttpPost("removeRole")]
        public async Task<IActionResult> RemoveRoleFromUser(UserRoleUpdateModel model)
        {
            var user = await _userManager.FindByIdAsync(model.UserId);
            if (user == null)
                return NotFound($"User with ID {model.UserId} not found.");

            var roleExist = await _roleManager.RoleExistsAsync(model.Role);
            if (!roleExist)
                return BadRequest($"Role {model.Role} does not exist.");

            var isInRole = await _userManager.IsInRoleAsync(user, model.Role);
            if (!isInRole)
                return BadRequest($"User {user.UserName} is not in role {model.Role}.");

            var result = await _userManager.RemoveFromRoleAsync(user, model.Role);
            if (result.Succeeded)
                return Ok($"Role {model.Role} has been removed from user {user.UserName}.");

            return BadRequest(result.Errors);
        }
    }
}
