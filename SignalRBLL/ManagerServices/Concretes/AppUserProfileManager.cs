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
    public class AppUserProfileManager:BaseManager<AppUserProfile>,IAppUserProfileManager
    {
        IAppUserProfileRepository _appUserProfileRepository;

        public AppUserProfileManager(IAppUserProfileRepository appUserProfileRepository):base(appUserProfileRepository) 
        {
            _appUserProfileRepository = appUserProfileRepository;
        }
    }
}
