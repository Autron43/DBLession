using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class SatisfactionSurvey
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 使用者GID
    /// </summary>
    [Required]
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 設備ID
    /// </summary>
    [Required]
    public int MachineId { get; set; }

    /// <summary>
    /// 得分
    /// </summary>
    [Required]
    public SatisfactionSurveyScore Score { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

    #region 關聯

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}
