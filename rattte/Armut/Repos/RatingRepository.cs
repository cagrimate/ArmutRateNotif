using Armut.Abstract;
using Armut.Context;
using Armut.Controllers;
using Armut.Entities;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Armut.Repos
{
  public class RatingRepository : IRatingService
  {
    public double GetAverageRating(int companyId)
    {
      using (var _appDbContext = new AppDbContext())
      {
        var avg = _appDbContext.Ratings
          .Where(r => r.CompanyId == companyId).Average(r => r.Score);
        return avg;
      }
    }

    public bool GetRateDateByUser(int UserId)
    {
      using (var _appDbContext = new AppDbContext())
      {
        var ret = _appDbContext.Ratings.Where(s => s.UserId == UserId).OrderByDescending(r => r.Date).FirstOrDefault();
        int voteNumber = _appDbContext.Ratings.Where(s => s.UserId == UserId).Count();

        if ((ret.Date.AddMinutes(5).Minute > DateTime.Now.Minute)&& voteNumber > 5)
        {
            throw new Exception("too much attemption");   
        }
        return true;
      }
    }

    public List<Rating> GetRatingListByCompanyId(int CompanyId)  
    {
      using (var _appDbContext = new AppDbContext())
      {
        return _appDbContext.Ratings.Where(c => c.CompanyId == CompanyId).ToList();
      }
    }

    public Rating GiveRating(Rating rating)
    {
      using (var _appDbContext = new AppDbContext())
      {
        _appDbContext.Ratings.Add(rating);

        GetRateDateByUser(rating.UserId);

        _appDbContext.SaveChanges();

        NotificationRepository notif = new NotificationRepository();
        Notification notiClass = new Notification();

        notiClass.Message = $"You Have New Ratings {rating.Score} from {rating.UserId} ";
        notiClass.Date = DateTime.Now;
        notiClass.companyId = rating.CompanyId;
        notiClass.userId = rating.UserId;
        notif.CreatNotification(notiClass);

        return rating;
      }
    }
  }
}
