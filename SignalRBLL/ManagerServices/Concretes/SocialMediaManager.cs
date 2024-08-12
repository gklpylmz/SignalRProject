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
    public class SocialMediaManager:BaseManager<SocialMedia>,ISocialMediaManager
    {
        ISocialMediaRepository _socialMediaRepository;

        public SocialMediaManager(ISocialMediaRepository socialMediaRepository) : base(socialMediaRepository)
        {
            _socialMediaRepository = socialMediaRepository;
        }
    }
}
