
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class LineResendQueue
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 用戶Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// Line訊息
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 狀態
    /// </summary>
    public LineResendStatus Status { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 訊息來源機構
    /// </summary>
    public int OrganizationId { get; set; }
  }

}
