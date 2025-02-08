using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.OrderDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderManager _orderManager;
        private readonly IMapper _mapper;

        public OrderController(IOrderManager orderManager, IMapper mapper)
        {
            _orderManager = orderManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var values = _mapper.Map<List<ResultOrderDto>>(_orderManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDto createOrderDto)
        {
            var order = _mapper.Map<Order>(createOrderDto);
            _orderManager.Add(order);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            var order = _mapper.Map<Order>(updateOrderDto);

            await _orderManager.Update(order);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(int id)
        {
            var value = _mapper.Map<ResultOrderDto>(await _orderManager.FindAsync(id));
            return Ok(value);
        }
        [HttpGet("OrderCount")]
        public IActionResult TotalOrderCount()
        {
            return Ok(_orderManager.TotalOrderCount());
        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveTotalOrderCount()
        {
            return Ok(_orderManager.ActiveTotalOrderCount());
        }
        [HttpGet("TodayTotalOrderPrie")]
        public IActionResult TodayOrderPrice()
        {
            return Ok(_orderManager.TodayOrderPrice());
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            return Ok(_orderManager.LastOrderPrice());
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var value = await _orderManager.FindAsync(id);
            _orderManager.Delete(value);
            return Ok();
        }

    }
}
