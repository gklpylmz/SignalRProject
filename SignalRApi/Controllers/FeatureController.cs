using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.FeatureDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureManager _featureManager;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureManager featureManager, IMapper mapper)
        {
            _featureManager = featureManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var feature = _mapper.Map<Feature>(createFeatureDto);
            _featureManager.Add(feature);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var feature = _mapper.Map<Feature>(updateFeatureDto);

            await _featureManager.Update(feature);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeature(int id)
        {
            var value = _mapper.Map<ResultFeatureDto>(await _featureManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFeature(int id)
        {
            var value = await _featureManager.FindAsync(id);
            _featureManager.Delete(value);
            return Ok();
        }
    }
}
