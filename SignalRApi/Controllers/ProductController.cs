using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
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
            var values = _productManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product product = new Product()
            {
                ProductName=createProductDto.ProductName,
                Description=createProductDto.Description,
                Price=createProductDto.Price,
                ImageUrl=createProductDto.ImageUrl,
            };
            _productManager.Add(product);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updatePrductDto)
        {
            Product product = new Product()
            {
                ID=updatePrductDto.ID,
                ProductName = updatePrductDto.ProductName,
                Description = updatePrductDto.Description,
                Price = updatePrductDto.Price,
                ImageUrl = updatePrductDto.ImageUrl,
            };
            await _productManager.Update(product);
            return Ok();
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _productManager.FindAsync(id);
            return Ok(value);
        }
        [HttpGet("GetProductWithCategoryies")]
        public IActionResult GetProductWithCategoryies()
        {
            var value = _mapper.Map<List<ResultProductWithCategory>>(_productManager.GetProductsWithCategories()); 
            return Ok(value);
        }
    }
}
