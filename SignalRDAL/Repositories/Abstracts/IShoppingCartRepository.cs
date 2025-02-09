using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Abstracts
{
    public interface IShoppingCartRepository:IRepository<ShoppingCart>
    {
        List<ShoppingCart> GetShoppingCartByTableNumber(int id);
        List<ShoppingCart> GetShoppingCartByTableNumberWithProductName(int id);
    }
}
