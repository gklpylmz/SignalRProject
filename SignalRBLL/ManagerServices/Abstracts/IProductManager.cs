using SignalREntites.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBLL.ManagerServices.Abstracts
{
    public interface IProductManager:IManager<Product>
    {
        List<Product> GetProductsWithCategories();
        public int GetProductCount();
    }
}
