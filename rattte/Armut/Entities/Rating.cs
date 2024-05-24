using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armut.Entities
{
  public class Rating
  {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CompanyId { get; set; }
    [Range(1, 5)]
    public double Score { get; set; }
    public DateTime Date { get; set; }

  }
}
