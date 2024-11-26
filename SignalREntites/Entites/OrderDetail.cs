using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntites.Entites
{
    public class OrderDetail:BaseEntity
    {
        public int Count { get; set; }
        public string? Description { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
