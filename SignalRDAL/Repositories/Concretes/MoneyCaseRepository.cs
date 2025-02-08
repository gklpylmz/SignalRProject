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
    public class MoneyCaseRepository : BaseRepository<MoneyCase>, IMoneyCase
    {
        MyContext _context;
        public MoneyCaseRepository(MyContext db) : base(db)
        {
            _context = db;
        }

        public decimal TotalMoneyCaseAmount()
        {
            return _context.MoneyCases.Select(x => x.TotalAmount).First();
        }
    }
}
