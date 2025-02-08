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
        
    }
}
