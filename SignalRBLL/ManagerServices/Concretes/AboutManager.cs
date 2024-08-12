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
    public class AboutManager:BaseManager<About>,IAboutManager
    {
        IAboutRepository _aboutRepository;

        public AboutManager(IAboutRepository aboutRepository):base(aboutRepository) 
        {
            _aboutRepository = aboutRepository;
        }
    }
}
