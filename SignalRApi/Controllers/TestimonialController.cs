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

        public TestimonialController(ITestimonialManager testimonialManager)
        {
            _testimonialManager = testimonialManager;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _testimonialManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                Name = createTestimonialDto.Name,
                Title= createTestimonialDto.Title,
                Description= createTestimonialDto.Description,
                ImageUrl= createTestimonialDto.ImageUrl,
            };
            _testimonialManager.Add(testimonial);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial testimonial = new Testimonial()
            {
                ID= updateTestimonialDto.ID,
                Name = updateTestimonialDto.Name,
                Title = updateTestimonialDto.Title,
                Description = updateTestimonialDto.Description,
                ImageUrl = updateTestimonialDto.ImageUrl,
            };
            await _testimonialManager.Update(testimonial);
            return Ok();
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _testimonialManager.FindAsync(id);
            return Ok(value);
        }
    }
}
