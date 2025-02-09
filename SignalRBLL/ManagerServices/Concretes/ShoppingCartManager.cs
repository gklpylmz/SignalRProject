using SignalRBLL.ManagerServices.Abstracts;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Concretes
{
    public class ShoppingCartManager:BaseManager<ShoppingCart>,IShoppingCartManager
    {
        IShoppingCartRepository _shoppingCartRepository;

        public ShoppingCartManager(IShoppingCartRepository shoppingCartRepository):base(shoppingCartRepository)
        {
            _shoppingCartRepository = shoppingCartRepository;
        }

        public List<ShoppingCart> GetShoppingCartByTableNumber(int id)
        {
            return _shoppingCartRepository.GetShoppingCartByTableNumber(id);
        }

        public List<ShoppingCart> GetShoppingCartByTableNumberWithProductName(int id)
        {
            return _shoppingCartRepository.GetShoppingCartByTableNumberWithProductName(id);
        }
    }
}
