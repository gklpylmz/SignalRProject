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
    public class OrderDetailManager:BaseManager<OrderDetail>,IOrderDetailManager
    {
        IOrderDetailRepository _orderDetailRepository;

        public OrderDetailManager(IOrderDetailRepository orderDetailRepository):base(orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }
    }
}
