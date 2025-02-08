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
    public class MenuTableManager:BaseManager<MenuTable>,IMenuTableManager
    {
        IMenuTableRepository _menuTableRepository;

        public MenuTableManager(IMenuTableRepository menuTableRepository) :base(menuTableRepository) 
        {
            _menuTableRepository = menuTableRepository;
        }
    }
}
