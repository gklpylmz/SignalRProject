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
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryManager _categoryManager;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryManager categoryManager, IMapper mapper)
        {
            _mapper = mapper;
            _categoryManager = categoryManager;
        }
        [HttpGet]
        public IActionResult CategeryList()
        {
            var values = _mapper.Map<List<ResultCategoryDto>>(_categoryManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var category = _mapper.Map<Category>(createCategoryDto);
            _categoryManager.Add(category);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            var category = _mapper.Map<Category>(updateCategoryDto);

            await _categoryManager.Update(category);
            return Ok();
        }
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategory(int id)
        {
            var value = _mapper.Map<ResultCategoryDto>(await _categoryManager.FindAsync(id));
			return Ok(value);
        }
		[HttpDelete]
		public async Task<IActionResult> DeleteCategory(int id)
        {
            var value = await _categoryManager.FindAsync(id);
            _categoryManager.Delete(value);
            return Ok();
        }
    }
}
