
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class OrganizationLineLiff
  {
    [Key]
    public int Id { get; set; }
    public int OrgId { get; set; }
    public LiffType LiffType { get; set; }
    public string LiffId { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }

  public enum LiffType
  {
    Unknown = 0,
    OrganizationAuthorization = 1,
    QrCodeScan = 2,
    UploadRapidTestPhoto = 3,
    HealthCardIdentification = 4
  }
}
