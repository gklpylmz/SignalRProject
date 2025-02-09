using Microsoft.EntityFrameworkCore;
using SignalRDAL.Context;
using SignalRDAL.Repositories.Abstracts;
using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Concretes
{
    public class ShoppingCartRepository : BaseRepository<ShoppingCart>, IShoppingCartRepository
    {
        MyContext _db;
        public ShoppingCartRepository(MyContext db) : base(db)
        {
            _db = db;
        }

        public List<ShoppingCart> GetShoppingCartByTableNumber(int id)
        {
            var shoppingCarts = _db.ShoppingCarts
                .Include(x=>x.Product)
                .Where(x=>x.MenuTableId == id)
                .ToList();
            return shoppingCarts;
        }

        public List<ShoppingCart> GetShoppingCartByTableNumberWithProductName(int id)
        {
            var shoppinhCarts = _db.ShoppingCarts
                .Include(x=>x.Product)
                .Where(x=>x.MenuTableId ==id)
                .ToList();
            return shoppinhCarts;
        }
    }
}
