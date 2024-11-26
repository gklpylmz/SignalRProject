using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDAL.Repositories.Abstracts
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetProductsWithCategories();
        public int GetProductCount();
    }
}
