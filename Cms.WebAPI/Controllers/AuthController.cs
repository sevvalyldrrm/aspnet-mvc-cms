using Cms.Data.Entity;
using Cms.WebAPI.DTOs;
using Cms.WebAPI.Services.Abstract;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cms.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IJwtTokenGenerator _jwtTokenGenerator;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailSender _emailSender;

        public AuthController(
            UserManager<AppUser> userManager,
            IJwtTokenGenerator jwtTokenGenerator,
            SignInManager<AppUser> signInManager,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _jwtTokenGenerator = jwtTokenGenerator;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            var user = await _userManager.FindByEmailAsync(loginModel.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginModel.Password))
            {
                var token = _jwtTokenGenerator.GenerateToken(user);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var user = new AppUser
            {
                UserName = model.Email,
                Email = model.Email
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
            {
                // E-posta onay token'ı oluştur
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                // E-posta gönderme işlemi
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "Auth", new { userId = user.Id, token = token }, Request.Scheme);
                await _emailSender.SendEmailAsync(user.Email, "Please confirm your email", $"Please confirm your account by <a href=\"{confirmationLink}\">clicking here</a>.");
                return Ok(); // ya da kullanıcıya bir geri dönüş bilgisi
            }

            return BadRequest(result.Errors);
        }
        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            if (userId == null || token == null)
            {
                return RedirectToPage("/Index");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            var result = await _userManager.ConfirmEmailAsync(user, token);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException($"Error confirming email for user with ID '{userId}':");
            }

            return Ok("Email confirmed successfully");
        }
        [HttpPost("Logout")]
        public async Task<IActionResult> Logout()
        {
            // Kullanıcının oturumunu kapat
            await _signInManager.SignOutAsync();
            return Ok();
        }
        [HttpPost("PasswordResetRequest")]
        public async Task<IActionResult> PasswordResetRequest([FromBody] PasswordResetRequestModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !(await _userManager.IsEmailConfirmedAsync(user)))
            {
                // Kullanıcı bulunamazsa veya e-posta onaylanmamışsa dahi başarılı yanıt verilir.
                return NotFound();
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var resetLink = Url.Action("ResetPassword", "Auth", new { token, email = user.Email }, Request.Scheme);

            // E-posta gönderme işlemi
            await _emailSender.SendEmailAsync(
                user.Email,
                "Reset Password",
                $"Please reset your password by clicking here: <a href=\"{resetLink}\">link</a>"
            );

            return Ok();
        }
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordModel model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Kullanıcı bulunamazsa dahi başarılı yanıt verilir.
                return NotFound();
            }

            var resetPassResult = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
            if (!resetPassResult.Succeeded)
            {
                // Hataları döndür
                return BadRequest(resetPassResult.Errors);
            }

            return Ok();
        }

    }
}
