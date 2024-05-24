using Armut.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Armut.Abstract
{
  public interface IRatingService
  {
    List<Rating> GetRatingListByCompanyId(int id);
    Rating GiveRating(Rating rating);
    double GetAverageRating(int id);
    bool GetRateDateByUser(int UserId);

  }
}
