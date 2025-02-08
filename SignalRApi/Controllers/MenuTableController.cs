using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : ControllerBase
    {
        private readonly IMenuTableManager _menuTableManager;

        public MenuTableController(IMenuTableManager menuTableManager)
        {
            _menuTableManager = menuTableManager;
        }
    }
}
