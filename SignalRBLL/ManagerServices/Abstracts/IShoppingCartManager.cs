using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Abstracts
{
    public interface IShoppingCartManager:IManager<ShoppingCart>
    {
        List<ShoppingCart> GetShoppingCartByTableNumber(int id);
        List<ShoppingCart> GetShoppingCartByTableNumberWithProductName(int id);
    }
}
