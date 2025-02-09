using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDto.ShoppingCartDto
{
    public class ResultShoppingCartWithProductNameDto
    {
        public int ID { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalCount { get; set; }
        public int ProductId { get; set; }
        public int MenuTableId { get; set; }
        public string ProductName { get; set; }
    }
}
