
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class HealthPassbook
  {
    [Key]
    public int Id { get; set; }
    public Guid AccountGid { get; set; }
    public string Content { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}
