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
    public class ProductManager:BaseManager<Product>,IProductManager
    {
        IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository):base(productRepository) 
        {
            _productRepository = productRepository;
        }

        public int GetProductCount()
        {
            return _productRepository.GetProductCount();
        }

        public List<Product> GetProductsWithCategories()
        {
            return _productRepository.GetProductsWithCategories();
        }
    }
}
