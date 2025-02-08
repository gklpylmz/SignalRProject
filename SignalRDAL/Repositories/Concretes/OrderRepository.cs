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
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        MyContext _db;
        public OrderRepository(MyContext db) : base(db)
        {
            _db= db;    
        }

        public int ActiveTotalOrderCount()
        {
            return _db.Order.Where(x => x.Description == "Müşteri Masada").Count();
        }

        public decimal LastOrderPrice()
        {
            return _db.Order.OrderByDescending(x => x.ID).Take(1).Select(x=>x.TotalPrice).First();
        }

        public decimal TodayOrderPrice()
        {
            return _db.Order.Where(x=>x.Date.Day == DateTime.Now.Day && x.Date.Month == DateTime.Now.Month && x.Date.Year == DateTime.Now.Year)
                .Sum(x=>x.TotalPrice);
        }

        public int TotalOrderCount()
        {
            return _db.Order.Count();
        }
    }
}
