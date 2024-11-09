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

        public BookingController(IBookingManager bookingManager)
        {
            _bookingManager = bookingManager;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                BookingName=createBookingDto.BookingName,
                Phone=createBookingDto.Phone,
                Mail=createBookingDto.Mail,
                PersonCount=createBookingDto.PersonCount,
                Date=createBookingDto.Date,
            };
            _bookingManager.Add(booking);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                ID=updateBookingDto.ID,
                BookingName = updateBookingDto.BookingName,
                Phone = updateBookingDto.Phone,
                Mail = updateBookingDto.Mail,
                PersonCount = updateBookingDto.PersonCount,
                Date = updateBookingDto.Date,
            };
            await _bookingManager.Update(booking);
            return Ok();
        }
        [HttpGet("GetAbout")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingManager.FindAsync(id);
            return Ok(value);
        }
    }
}
