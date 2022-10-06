
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class PatientGroupDetail
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 建立者Guid
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 群組ID
    /// </summary>
    public int PatientGroupId { get; set; }

    /// <summary>
    /// 成員狀態
    /// </summary>
    public PatientGroupStatus Status { get; set; } = PatientGroupStatus.Available;

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    [ForeignKey("PatientGroupId")]
    public virtual PatientGroup PatientGroup { get; set; }

    #endregion
  }
}