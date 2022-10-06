
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class SmsLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 簡訊類型
    /// </summary>
    public SmsType SmsType { get; set; }

    /// <summary>
    /// 接收行動電話號碼
    /// </summary>
    [MaxLength(20)]
    public string SendPhone { get; set; }

    /// <summary>
    /// 簡訊內容
    /// </summary>
    [MaxLength(500)]
    public string Message { get; set; }

    /// <summary>
    /// 簡訊商識別ID
    /// </summary>
    [MaxLength(50)]
    public string SmsId { get; set; }

    /// <summary>
    /// 收訊人名稱
    /// </summary>
    [MaxLength(30)]
    public string Name { get; set; }

    /// <summary>
    /// 扣除點數額
    /// </summary>
    public double CostPoint { get; set; }

    /// <summary>
    /// 發送狀態代碼
    /// </summary>
    public Every8DStatus? DeliveryStatus { get; set; }

    /// <summary>
    /// 發送後異常訊息
    /// </summary>
    public string ProcessMessage { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 機構ID
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 接收使用者GID
    /// </summary>
    public Guid? AccountGid { get; set; }

    #region 關聯
    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
    #endregion
  }
}
