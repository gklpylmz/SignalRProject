using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.AboutDto;
using SignalRDto.BookingDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingManager _bookingManager;
        private readonly IMapper _mapper;

        public BookingController(IBookingManager bookingManager, IMapper mapper)
        {
            _bookingManager = bookingManager;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _mapper.Map<List<ResultBookingDto>>(_bookingManager.GetAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            var booking = _mapper.Map<Booking>(createBookingDto);
            _bookingManager.Add(booking);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            var booking = _mapper.Map<Booking>(updateBookingDto);

            await _bookingManager.Update(booking);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBooking(int id)
        {
            var value = _mapper.Map<ResultBookingDto>(await _bookingManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var value = await _bookingManager.FindAsync(id);
            _bookingManager.Delete(value);
            return Ok();
        }
    }
}
