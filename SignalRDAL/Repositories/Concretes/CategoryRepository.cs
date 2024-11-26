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
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        MyContext _db;
        public CategoryRepository(MyContext db) : base(db)
        {
            _db = db;
        }

        public int GetCategoryCount()
        {
            return _db.Categories.Count();
        }
    }
}
