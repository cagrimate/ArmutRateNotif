using Armut.Entities;

namespace Armut.Abstract
{
  public interface INotificationService
  {
    List<Notification> GetAllNotificationsById(int companyId);
    Notification CreatNotification(Notification notification);

  }
}
