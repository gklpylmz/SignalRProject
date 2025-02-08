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
    public class MoneyCasesManager:BaseManager<MoneyCase>,IMoneyCasesManager
    {
        IMoneyCase _moneyCasesRepository;

        public MoneyCasesManager(IMoneyCase moneyCasesRepository) : base(moneyCasesRepository) 
        {
            _moneyCasesRepository = moneyCasesRepository;
        }

        public decimal TotalMoneyCaseAmount()
        {
            return _moneyCasesRepository.TotalMoneyCaseAmount();
        }
    }
}
