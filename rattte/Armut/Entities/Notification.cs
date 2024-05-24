using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armut.Entities
{
  public class Notification
  {
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [StringLength(50)]
    public string Message { get; set; }

    public DateTime Date { get; set; }
    public int companyId { get; set; }
    public int userId { get; set; }
  }
}
