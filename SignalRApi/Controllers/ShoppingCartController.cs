using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRDto.ShoppingCartDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private readonly IShoppingCartManager _shoppingCartManager;
        private readonly IProductManager _productManager;
        private readonly IMapper _mapper;

        public ShoppingCartController(IShoppingCartManager shoppingCartManager, IMapper mapper, IProductManager productManager)
        {
            _shoppingCartManager = shoppingCartManager;
            _mapper = mapper;
            _productManager = productManager;
        }

        [HttpGet]
        public IActionResult ShoppingCartList()
        {
            var values = _mapper.Map<List<ResultShoppingCartDto>>(_shoppingCartManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateShoppingCart(CreateShoppingCartDto createShoppingCartDto)
        {
            var shoppingCart = _mapper.Map<ShoppingCart>(createShoppingCartDto);
            var productPrice = _productManager.FindAsync(shoppingCart.ProductId).Result;
            shoppingCart.Price = productPrice.Price;
            shoppingCart.TotalCount = createShoppingCartDto.Count + shoppingCart.Price;
            _shoppingCartManager.Add(shoppingCart);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateShoppingCart(UpdateShoppingCartDto updateShoppingCartDto)
        {
            var shoppingCart = _mapper.Map<ShoppingCart>(updateShoppingCartDto);

            await _shoppingCartManager.Update(shoppingCart);
            return Ok();
        }
        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetShoppingCart(int id)
        //{
        //    var value = _mapper.Map<ResultShoppingCartDto>(await _shoppingCartManager.FindAsync(id));
        //    return Ok(value);
        //}
        [HttpDelete]
        public async Task<IActionResult> DeleteShoppingCart(int id)
        {
            var value = await _shoppingCartManager.FindAsync(id);
            _shoppingCartManager.Delete(value);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetShoppingCartByTableNumber(int id)
        {
            var values = _mapper.Map<List<ResultShoppingCartDto>>(_shoppingCartManager.GetShoppingCartByTableNumber(id));
            return Ok(values);
        }
        [HttpGet("GetShoppingCartByTableNumberWithProductName")]
        public IActionResult GetShoppingCartByTableNumberWithProductName(int id)
        {
            var values = _mapper.Map<List<ResultShoppingCartWithProductNameDto>>(_shoppingCartManager.GetShoppingCartByTableNumber(id));
            return Ok(values);
        }
    }
}
