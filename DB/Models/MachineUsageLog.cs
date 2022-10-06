
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class MachineUsageLog
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 帳號GID
    /// </summary>
    public Guid AccountGid { get; set; }
    /// <summary>
    /// 機台Id
    /// </summary>
    public int MachineId { get; set; }
    /// <summary>
    /// 使用的卡片類型
    /// </summary>
    public LoginType? CardType { get; set; }
    /// <summary>
    /// 使用時間
    /// </summary>
    [MaxLength(8)]
    public string TimeOfUsage { get; set; }
    /// <summary>
    /// 是否手輸
    /// </summary>
    public bool IsHandWrite { get; set; } = false;
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    #endregion
  }
}
