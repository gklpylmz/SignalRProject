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

        public CategoryController(ICategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        [HttpGet]
        public IActionResult CategeryList()
        {
            var values = _categoryManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                CategoryDescription = createCategoryDto.CategoryDescription,
            };
            _categoryManager.Add(category);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                ID= updateCategoryDto.ID,
                CategoryName = updateCategoryDto.CategoryName,
                CategoryDescription = updateCategoryDto.CategoryDescription,
            };
            await _categoryManager.Update(category);
            return Ok();
        }
        [HttpGet("GetAbout")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryManager.FindAsync(id);
            return Ok(value);
        }
    }
}
