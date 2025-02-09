using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntites.Entites
{
    public class ShoppingCart:BaseEntity
    {
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalCount { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int MenuTableId { get; set; }
        public virtual MenuTable MenuTable { get; set; }
    }
}
