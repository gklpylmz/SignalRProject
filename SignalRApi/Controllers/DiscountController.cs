using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.DiscountDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountManager _discountManager;

        public DiscountController(IDiscountManager discountManager)
        {
            _discountManager = discountManager;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _discountManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            Discount discount = new Discount()
            {
               Title= createDiscountDto.Title,
               Amount= createDiscountDto.Amount,
               Description= createDiscountDto.Description,
               ImageUrl= createDiscountDto.ImageUrl,
            };
            _discountManager.Add(discount);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            Discount discount = new Discount()
            {
                ID= updateDiscountDto.ID,
                Title = updateDiscountDto.Title,
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description,
                ImageUrl = updateDiscountDto.ImageUrl,
            };
            await _discountManager.Update(discount);
            return Ok();
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountManager.FindAsync(id);
            return Ok(value);
        }
    }
}
