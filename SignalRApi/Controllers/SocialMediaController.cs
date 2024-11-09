using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.SocialMediaDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaManager _socialMediaManager;

        public SocialMediaController(ISocialMediaManager socialMediaManager)
        {
            _socialMediaManager = socialMediaManager;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _socialMediaManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            SocialMedia socialMedia = new SocialMedia()
            {
                Title= createSocialMediaDto.Title,
                Url= createSocialMediaDto.Url,
            };
            _socialMediaManager.Add(socialMedia);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            SocialMedia socialMedia = new SocialMedia()
            {
                ID= updateSocialMediaDto.ID,
                Title = updateSocialMediaDto.Title,
                Url = updateSocialMediaDto.Url,
            };
            await _socialMediaManager.Update(socialMedia);
            return Ok();
        }
        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _socialMediaManager.FindAsync(id);
            return Ok(value);
        }
    }
}
