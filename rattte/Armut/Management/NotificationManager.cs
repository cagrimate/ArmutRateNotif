using Armut.Abstract;
using Armut.Entities;
using Armut.Repos;

namespace Armut.Management
{
  public class NotificationManager : INotificationService
  {
    private INotificationService _notificationService;
    public NotificationManager()
    {
      _notificationService = new NotificationRepository();
    }
    public Notification CreatNotification(Notification notification)
    {
      return _notificationService.CreatNotification(notification);
    }
    public List<Notification> GetAllNotificationsById(int companyId)
    {
      return _notificationService.GetAllNotificationsById(companyId);
    }
  }
}
