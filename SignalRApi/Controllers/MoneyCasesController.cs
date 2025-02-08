using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCasesManager _moneyCasesManager;

        public MoneyCasesController(IMoneyCasesManager moneyCasesManager)
        {
            _moneyCasesManager = moneyCasesManager;
        }
        [HttpGet]
        public IActionResult GetTotalAmountPrice()
        {
            return Ok(_moneyCasesManager.TotalMoneyCaseAmount());
        }
    }
}
