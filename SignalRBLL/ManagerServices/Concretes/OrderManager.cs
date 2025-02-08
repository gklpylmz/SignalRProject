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

        public int ActiveTotalOrderCount()
        {
            return _orderRepository.ActiveTotalOrderCount();
        }

        public decimal LastOrderPrice()
        {
            return _orderRepository.LastOrderPrice();
        }

        public decimal TodayOrderPrice()
        {
            return _orderRepository.TodayOrderPrice();
        }

        public int TotalOrderCount()
        {
            return _orderRepository.TotalOrderCount();
        }
    }
}
