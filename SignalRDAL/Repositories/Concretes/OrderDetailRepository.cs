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
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {
        MyContext _db;
        public OrderDetailRepository(MyContext db) : base(db)
        {
            _db = db;
        }

        public void AddOrderDetail(OrderDetail orderDetail, string table)
        {
            var value = _db.Order.Where(x=>x.ID== orderDetail.ID).FirstOrDefault();
            if (value == null)
            {
                Order order = new Order()
                {
                    Status = SignalREntites.Enums.DataStatus.Inserted,
                    TableNumber = "Masa1",
                    Description = table,
                    Date = DateTime.Now,
                    TotalPrice = 0,
                };
                _db.Order.Add(order);
            }
            else
            {
                _db.OrderDetail.Add(orderDetail);
                value.TotalPrice = value.TotalPrice + orderDetail.TotalPrice;
                _db.SaveChanges();
            }
            
        }
    }
}
