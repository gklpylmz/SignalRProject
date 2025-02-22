using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBLL.ManagerServices.Abstracts;
using SignalRBLL.ManagerServices.Concretes;
using SignalRDto.NotificationDto;
using SignalREntites.Entites;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationManager _notificationManager;
        private readonly IMapper _mapper;

        public NotificationController(INotificationManager notificationManager, IMapper mapper)
        {
            _notificationManager = notificationManager;
            _mapper = mapper;
        }

        [HttpGet("PassiveNotificationCount")]
        public IActionResult GetPassiveNotificationCount()
        {
            var values = _notificationManager.GetPassiveNotificationCount();
            return Ok(values);
        }
        [HttpGet("PassiveNotificationList")]
        public IActionResult PassiveNotificationList()
        {
            var values = _mapper.Map<List<ResultNotificationDto>>(_notificationManager.GetPassiveNotifications());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            var notification = _mapper.Map<Notification>(createNotificationDto);
            _notificationManager.Add(notification);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            var notification = _mapper.Map<Notification>(updateNotificationDto);

            await _notificationManager.Update(notification);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteNotification(int id)
        {
            var value = await _notificationManager.FindAsync(id);
            _notificationManager.Delete(value);
            return Ok();
        }
        [HttpGet("ChangeNotificationStatusToTrue/{id}")]
        public IActionResult ChangeNotificationStatusToTrue(int id)
        {
            _notificationManager.ChangeNotificationStatusToTrue(id);
            return Ok("Güncelleme Yapıldı");
        }
        [HttpGet("ChangeNotificationStatusToFalse/{id}")]
        public IActionResult ChangeNotificationStatusToFalse(int id)
        {
            _notificationManager.ChangeNotificationStatusToFalse(id);
            return Ok("Güncelleme Yapıldı");
        }
    }
}
