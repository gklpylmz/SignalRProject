using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalRDto.IdentityDto;
using SignalREntites.Entites;

namespace SignalRWebUI.Controllers
{
    public class SettingController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditDto userEditDto = new UserEditDto
            {
                UserName = value.UserName,
                Mail = value.Email,
            };
            return View(userEditDto);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditDto userEditDto)
        {
            if (userEditDto.Password == userEditDto.ConfirmPassword)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.UserName = userEditDto.UserName;
                user.Email = userEditDto.Mail;
                user.PasswordHash=_userManager.PasswordHasher.HashPassword(user,userEditDto.Password);
                var result = await _userManager.UpdateAsync(user);
                return RedirectToAction("Index","Category");
            }
            return View();
        }
    }
}
