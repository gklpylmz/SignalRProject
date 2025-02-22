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
    public class DiscountRepository : BaseRepository<Discount>, IDiscountRepository
    {
		MyContext _db;
        public DiscountRepository(MyContext db) : base(db)
        {
			_db = db;
        }

		public void ChangeDiscountStatusToFalse(int id)
		{
			var discount = _db.Discounts.Find(id);
			discount.Status = SignalREntites.Enums.DataStatus.Deleted;
			_db.SaveChanges();
		}

		public void ChangeDiscountStatusToTrue(int id)
		{
			var discount = _db.Discounts.Find(id);
			discount.Status = SignalREntites.Enums.DataStatus.Inserted;
			_db.SaveChanges();
		}
	}
}
