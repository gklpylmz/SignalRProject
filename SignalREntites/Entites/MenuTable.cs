using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalREntites.Entites
{
    public class MenuTable : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public virtual List<ShoppingCart> ShoppingCarts { get; set; }
    }
}
