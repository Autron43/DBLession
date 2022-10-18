
using DB.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DB.Models
{
  public class ChairStandTestRecord
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 用戶Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 起坐次數
    /// </summary>
    public int StandCount { get; set; }

    /// <summary>
    /// 測量時間長度
    /// </summary>
    public double Duration { get; set; }

    /// <summary>
    /// 人工判斷測驗結果
    /// </summary>
    public ChairStandTestResult Result { get; set; }

    /// <summary>
    /// 資料來源
    /// </summary>
    public VitalSignSource Source { get; set; }

    /// <summary>
    /// 量測時間
    /// </summary>
    public DateTime MeasureAt { get; set; }

    /// <summary>
    /// 建立者
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }
  }

  public enum ChairStandTestResult
  {
    Unknown = 0,
    Normal = 1,
    Abnormal = 2
  }
}
