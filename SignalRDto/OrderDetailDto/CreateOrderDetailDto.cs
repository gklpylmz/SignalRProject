using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDto.OrderDetailDto
{
    public class CreateOrderDetailDto
    {
        public int Count { get; set; }
        public string? Description { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
    }
}
