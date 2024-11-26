using Microsoft.EntityFrameworkCore;
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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        MyContext _db;
        public ProductRepository(MyContext db) : base(db)
        {
            _db = db;
        }

        public int GetProductCount()
        {
            return _db.Products.Count();
        }

        public List<Product> GetProductsWithCategories()
        {
            var values =_db.Products.Include(x=>x.Category).ToList();   
            return values;
        }
    }
}
