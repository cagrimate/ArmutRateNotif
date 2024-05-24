using Armut.Abstract;
using Armut.Entities;
using Armut.Management;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Armut.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RatingController : ControllerBase
  {
    private IRatingService _ratingService;
    public RatingController()
    {
      _ratingService = new Management.RatingManager();
    }

    [HttpGet("{companyId}")]
    public List<Rating> GetRatingListByCompanyId(int companyId) //bunun list olması lazım
    {
      return _ratingService.GetRatingListByCompanyId(companyId);
    }

    [HttpGet("average/{companyId}")]
    public double GetAverageRating(int companyId)
    {
      return _ratingService.GetAverageRating(companyId);
    }

    [HttpPost]
    public Rating GiveRating([FromBody] Rating rating)
    {
      return _ratingService.GiveRating(rating);
    }
  }
}
