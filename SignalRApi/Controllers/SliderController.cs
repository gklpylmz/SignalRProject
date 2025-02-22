using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRDto.SliderDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderManager _sliderManager;
        private readonly IMapper _mapper;

        public SliderController(ISliderManager sliderManager, IMapper mapper)
        {
            _sliderManager = sliderManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult SliderList()
        {
            var values = _mapper.Map<List<ResultSliderDto>>(_sliderManager.GetAll());
            return Ok(values);
        }
        
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var slider = _mapper.Map<Slider>(createSliderDto);
            _sliderManager.Add(slider);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var slider = _mapper.Map<Slider>(updateSliderDto);

            await _sliderManager.Update(slider);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSlider(int id)
        {
            var value = _mapper.Map<ResultSliderDto>(await _sliderManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteSlider(int id)
        {
            var value = await _sliderManager.FindAsync(id);
            _sliderManager.Delete(value);
            return Ok();
        }

    }
}
