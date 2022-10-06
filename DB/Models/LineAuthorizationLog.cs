
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class LineAuthorizationLog
  {
    [Key]
    public int Id { get; set; }
    public string LineUserId { get; set; }
    public int OrgId { get; set; }
    public int ChannelOrgId { get; set; }
    public int? PatientGroupId { get; set; }
    public bool Completed { get; set; }
    public bool CovidPatient { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}
