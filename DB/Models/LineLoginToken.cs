
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class LineLoginToken
  {
    [Key]
    public int Id { get; set; }
    public string LineUserId { get; set; }
    public string Token { get; set; }
    public DateTime ExpiredAt { get; set; }
    public DateTime CreatedAt { get; set; }
  }
}
