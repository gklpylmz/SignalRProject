﻿namespace SignalRWebUI.DTOs.BookingDtos
{
    public class CreateBookingDto
    {
        public string BookingName { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
