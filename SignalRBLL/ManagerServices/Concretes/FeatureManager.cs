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
    public class FeatureManager:BaseManager<Feature>,IFeatureManager
    {
        IFeatureRepository _featureRepository;

        public FeatureManager(IFeatureRepository featureRepository):base(featureRepository) 
        {
            _featureRepository = featureRepository;
        }
    }
}
