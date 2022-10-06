
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class SleepRecord
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 用戶Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// Apple Health Id
    /// </summary>
    [MaxLength(36)]
    public string AppleHealthId { get; set; }

    /// <summary>
    /// Google Fit Id
    /// </summary>
    [MaxLength(36)]
    public string GoogleFitId { get; set; }

    public SleepQuality Quality { get; set; } = SleepQuality.Unknown;

    /// <summary>
    /// 資料來源
    /// </summary>
    public VitalSignSource Source { get; set; }

    /// <summary>
    /// 紀錄起始時間
    /// </summary>
    public DateTime StartAt { get; set; }

    /// <summary>
    /// 紀錄終止時間
    /// </summary>
    public DateTime EndAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }
  }
}
