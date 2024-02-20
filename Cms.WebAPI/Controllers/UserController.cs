using Cms.Data.Entity;
using Cms.WebAPI.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        public UserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile(UpdateProfileModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Kullanıcı bilgilerini güncelle
            user.FullName = model.FullName;
            //user.FirstName = model.FirstName;
            //user.LastName = model.LastName;
            
            // Diğer alanlar...

            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return Ok("Profile updated successfully.");
            }

            return BadRequest(result.Errors);
        }
        [Authorize]
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound("User not found.");
            }

            // Şifre değiştirme işlemini gerçekleştir
            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (changePasswordResult.Succeeded)
            {
                return Ok("Password changed successfully.");
            }

            return BadRequest(changePasswordResult.Errors);
        }
    }
}
