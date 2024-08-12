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
    public class AppUserManager:BaseManager<AppUser>,IAppUserManager
    {
        IAppUserRepository _apRep;

        public AppUserManager(IAppUserRepository apRep):base (apRep) 
        {
            _apRep = apRep;
        }

        public async Task<bool> CreateUser(AppUser item)
        {
            return await _apRep.AddUser(item);
        }
    }
}
