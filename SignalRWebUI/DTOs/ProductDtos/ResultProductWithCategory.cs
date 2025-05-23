﻿namespace SignalRWebUI.DTOs.ProductDtos
{
	public class ResultProductWithCategory
	{
		public int ID { get; set; }
		public string ProductName { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string ImageUrl { get; set; }
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}
