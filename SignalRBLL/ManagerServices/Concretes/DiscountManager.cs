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
    public class DiscountManager:BaseManager<Discount>,IDiscountManager
    {
        IDiscountRepository _discountRepository;

        public DiscountManager(IDiscountRepository discountRepository):base(discountRepository) 
        {
            _discountRepository = discountRepository;
        }
    }
}
