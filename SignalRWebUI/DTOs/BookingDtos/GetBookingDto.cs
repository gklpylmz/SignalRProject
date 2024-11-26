namespace SignalRWebUI.DTOs.BookingDtos
{
    public class GetBookingDto
    {
        public int ID { get; set; }
        public string BookingName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
