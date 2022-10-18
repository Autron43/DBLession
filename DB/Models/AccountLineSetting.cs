
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class AccountLineSetting
  {
    [Key]
    public int Id { get; set; }

    public Guid AccountGid { get; set; }
    public int OrgId { get; set; }
    [MaxLength(100)]
    public string LineUserId { get; set; }
    public string LineNotifyToken { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}
