using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.CategoryDto;
using SignalRDto.ProductDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductManager _productManager;
        private readonly IMapper _mapper;

        public ProductController(IProductManager productManager, IMapper mapper)
        {
            _productManager = productManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
			
			var values = _mapper.Map<List<ResultProductDto>>(_productManager.GetAll());
			return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
			var product = _mapper.Map<Product>(createProductDto);
			_productManager.Add(product);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updatePrductDto)
        {
			var product = _mapper.Map<Product>(updatePrductDto);

			await _productManager.Update(product);
			return Ok();
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetProduct(int id)
        {
			var product = _mapper.Map<ResultProductDto>(await _productManager.FindAsync(id));
			return Ok(product);
        }
        [HttpGet("ProductCount")]
        public IActionResult GetProductCount()
        {
            return Ok(_productManager.GetProductCount());
        }
        [HttpGet("GetProductWithCategoryies")]
        public IActionResult GetProductWithCategoryies()
        {
            var value = _mapper.Map<List<ResultProductWithCategory>>(_productManager.GetProductsWithCategories()); 
            return Ok(value);
        }
		[HttpDelete]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			var value = await _productManager.FindAsync(id);
			_productManager.Delete(value);
			return Ok();
		}
		[HttpGet("GetRandomNineProduct")]
		public IActionResult GetRandomNineProduct()
		{
			var product = _mapper.Map<List<ResultProductDto>>(_productManager.GetRandomNineProduct());
			return Ok(product);
		}
	}
}
