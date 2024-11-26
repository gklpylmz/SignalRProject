namespace SignalRWebUI.DTOs.DiscountDtos
{
    public class UpdateDiscountDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
