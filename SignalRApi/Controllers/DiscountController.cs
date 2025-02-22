using AutoMapper;
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
        private readonly IMapper _mapper;

        public DiscountController(IDiscountManager discountManager, IMapper mapper)
        {
            _discountManager = discountManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _mapper.Map<List<ResultDiscountDto>>(_discountManager.GetAll().Where(x=>x.Status !=SignalREntites.Enums.DataStatus.Deleted));
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            var discount = _mapper.Map<Discount>(createDiscountDto);
            _discountManager.Add(discount);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            var discount = _mapper.Map<Discount>(updateDiscountDto);

            await _discountManager.Update(discount);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscount(int id)
        {
            var value = _mapper.Map<ResultDiscountDto>(await _discountManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var value = await _discountManager.FindAsync(id);
            _discountManager.Delete(value);
            return Ok();
        }
		[HttpGet("ChangeDiscountStatusToTrue/{id}")]
		public IActionResult ChangeDiscountStatusToTrue(int id)
		{
            _discountManager.ChangeDiscountStatusToTrue(id);
            return Ok();
		}
		[HttpGet("ChangeDiscountStatusToFalse/{id}")]
		public IActionResult ChangeDiscountStatusToFalse(int id)
		{
			_discountManager.ChangeDiscountStatusToFalse(id);
			return Ok();
		}
	}
}
