﻿
using mPHR.Services.Database.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace mPHR.Services.Database.Models
{
  public class WalkingSpeedTestRecord
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 用戶Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 距離
    /// </summary>
    public double Distance { get; set; }

    /// <summary>
    /// 測量時間長度
    /// </summary>
    public double Duration { get; set; }

    /// <summary>
    /// 人工判斷測驗結果
    /// </summary>
    public WalkingSpeedTestResult Result { get; set; }

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
    /// 新增時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }
  }

  public enum WalkingSpeedTestResult
  {
    Unknown = 0,
    Normal = 1,
    Abnormal = 2
  }
}
