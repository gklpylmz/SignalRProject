using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.MenuTableDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTableController : ControllerBase
    {
        private readonly IMenuTableManager _menuTableManager;
        private readonly IMapper _mapper;
        public MenuTableController(IMenuTableManager menuTableManager)
        {
            _menuTableManager = menuTableManager;
        }

        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableManager.GetAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTable)
        {
            var menuTable = _mapper.Map<MenuTable>(createMenuTable);
            _menuTableManager.Add(menuTable);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMenuTable(UpdateMenuTableDto updateMenuTable)
        {
            var menuTable = _mapper.Map<MenuTable>(updateMenuTable);

            await _menuTableManager.Update(menuTable);
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenuTable(int id)
        {
            var value = _mapper.Map<GetMenuTableDto>(await _menuTableManager.FindAsync(id));
            return Ok(value);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteMenuTable(int id)
        {
            var value = await _menuTableManager.FindAsync(id);
            _menuTableManager.Delete(value);
            return Ok();
        }
    }
}

