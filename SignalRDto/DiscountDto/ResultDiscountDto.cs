using SignalREntites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDto.DiscountDto
{
    public class ResultDiscountDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
		public DataStatus Status { get; set; }
	}
}
