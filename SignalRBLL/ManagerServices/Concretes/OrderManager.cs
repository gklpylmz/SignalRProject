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
    public class OrderManager:BaseManager<Order>,IOrderManager
    {
        IOrderRepository _orderRepository;

        public OrderManager(IOrderRepository orderRepository):base(orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}
