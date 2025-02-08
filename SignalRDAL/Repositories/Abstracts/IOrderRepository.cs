using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Abstracts
{
    public interface IOrderRepository:IRepository<Order>
    {
        int TotalOrderCount();
        int ActiveTotalOrderCount();
        decimal LastOrderPrice();
        decimal TodayOrderPrice();
    }
}
