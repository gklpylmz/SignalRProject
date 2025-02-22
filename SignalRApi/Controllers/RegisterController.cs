using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRDto.IdentityDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public RegisterController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDto registerDto)
        {
            var appUser = new AppUser
            {
                CreatedDate = DateTime.Now,
                Status = SignalREntites.Enums.DataStatus.Inserted,
                Email = registerDto.Mail,
                UserName = registerDto.UserName,

            };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            return Ok(result);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDto loginDto)
        {
           
            var result = await _signInManager.PasswordSignInAsync(loginDto.UserName,loginDto.Password,false,false);
            if (result == Microsoft.AspNetCore.Identity.SignInResult.Failed)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
