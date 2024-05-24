using Armut.Abstract;
using Armut.Entities;
using Armut.Management;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Armut.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NotiController : ControllerBase
  {
    private INotificationService _notificationService;
    public NotiController()
    {
      _notificationService = new NotificationManager();
    }

    [HttpPost]
    public Notification GiveNotification([FromBody] Notification notification)
    {
      return _notificationService.CreatNotification(notification);
    }

    [HttpGet("{companyId}")]
    public List<Notification> GetNotification(int companyId)
    {
      return _notificationService.GetAllNotificationsById(companyId);
    }
  }
}
