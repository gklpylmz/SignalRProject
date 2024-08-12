using SignalRBLL.ManagerServices.Abstracts;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Concretes
{
    public class BookingManager:BaseManager<Booking>,IBookingManager
    {
        IBookingRepository _bookingRepository;

        public BookingManager(IBookingRepository bookingRepository):base(bookingRepository) 
        {
            _bookingRepository = bookingRepository;
        }
    }
}
