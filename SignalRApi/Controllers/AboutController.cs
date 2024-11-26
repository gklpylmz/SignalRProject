using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.CategoryDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutManager _aboutManager;
        private readonly IMapper _mapper;

        public AboutController(IAboutManager aboutManager, IMapper mapper)
        {
            _aboutManager = aboutManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutLis()
        {
            var values = _mapper.Map<List<ResultAboutDto>>(_aboutManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            var about = _mapper.Map<About>(createAboutDto);
            _aboutManager.Add(about);
            return Ok();
        }
 
        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            var about = _mapper.Map<About>(updateAboutDto);

            await _aboutManager.Update(about);
            return Ok();
        }
		[HttpGet("{id}")]
		public async Task<IActionResult> GetAbout(int id)
        {
            var value = _mapper.Map<ResultAboutDto>(await _aboutManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public  async Task<IActionResult> DeleteAbout(int id)
        {
            var value = await _aboutManager.FindAsync(id);
            _aboutManager.Delete(value);
            return Ok();
        }
    }
}
