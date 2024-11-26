using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.TestimonialDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialManager _testimonialManager;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialManager testimonialManager, IMapper mapper)
        {
            _testimonialManager = testimonialManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(createTestimonialDto);
            _testimonialManager.Add(testimonial);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            var testimonial = _mapper.Map<Testimonial>(updateTestimonialDto);

            await _testimonialManager.Update(testimonial);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonial(int id)
        {
            var value = _mapper.Map<ResultTestimonialDto>(await _testimonialManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var value = await _testimonialManager.FindAsync(id);
            _testimonialManager.Delete(value);
            return Ok();
        }
    }
}
