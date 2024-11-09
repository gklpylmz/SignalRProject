using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRDto.AboutDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutManager _aboutManager;

        public AboutController(IAboutManager aboutManager)
        {
            _aboutManager = aboutManager;
        }

        [HttpGet]
        public IActionResult AboutLis()
        {
            var values = _aboutManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            About about = new About()
            {
                Title = createAboutDto.Title,
                ImageUrl = createAboutDto.ImageUrl,
                Description = createAboutDto.Description,
            };
            _aboutManager.Add(about);
            return Ok();
        }
 
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            About about = new About()
            {
                ID = updateAboutDto.ID,
                Title = updateAboutDto.Title,
                ImageUrl = updateAboutDto.ImageUrl,
                Description = updateAboutDto.Description,
            };
            await _aboutManager.Update(about);
            return Ok();
        }
        [HttpGet("GetAbout")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutManager.FindAsync(id);
            return Ok(value);
        }
    }
}
