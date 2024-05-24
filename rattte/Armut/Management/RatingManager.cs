using Armut.Abstract;
using Armut.Entities;
using Armut.Repos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Armut.Management
{
  public class RatingManager : IRatingService
  {
    private IRatingService _ratingService;
    public RatingManager()
    {
      _ratingService = new RatingRepository();
    }
    public double GetAverageRating(int id)
    {
      return _ratingService.GetAverageRating(id);
    }

    public bool GetRateDateByUser(int UserId)
    {
      return _ratingService.GetRateDateByUser(UserId);
    }

    public List<Rating> GetRatingListByCompanyId(int CompanyId)
    {
      return _ratingService.GetRatingListByCompanyId(CompanyId);
    }

    public Rating GiveRating(Rating rating)
    {
      return _ratingService.GiveRating(rating);
    }
  }
}
