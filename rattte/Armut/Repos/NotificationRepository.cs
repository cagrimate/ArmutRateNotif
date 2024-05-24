using Armut.Abstract;
using Armut.Context;
using Armut.Entities;

namespace Armut.Repos
{
  public class NotificationRepository : INotificationService
  {
    public Notification CreatNotification(Notification notification)
    {
      using (var _appDbContext = new AppDbContext())
      {
        _appDbContext.Notifications.Add(notification);
        _appDbContext.SaveChanges();
        return notification;
      }
    }

    public List<Notification> GetAllNotificationsById(int CompanyId)
    {
      using (var _appDbContext = new AppDbContext())
      {
        return _appDbContext.Notifications.Where(c=>c.companyId== CompanyId).ToList();

      }
    }
  }
}
