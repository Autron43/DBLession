
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class AccountNotificationSetting
  {
    [Key]
    public int Id { get; set; }
    public Guid AccountGid { get; set; }

    public bool OrganizationMessage { get; set; }
    public bool CaseManagement { get; set; }
    public bool Course { get; set; }
    public bool FormRecommend { get; set; }
    public bool Event { get; set; }
    public bool Shop { get; set; }
    public bool VitalSign { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}
