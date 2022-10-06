
using mPHR.Services.Database.EnumFields;

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  /// <summary>
  /// 個管建議 (原HealthData)
  /// </summary>
  public class CaseManagement
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 個案 Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 報告日期
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime ReportDate { get; set; }

    /// <summary>
    /// 個案名稱
    /// </summary>
    [MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// 生命徵象量測起始日
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? VitalSignStartDate { get; set; }

    /// <summary>
    /// 生命徵象量測結束日
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? VitalSignEndDate { get; set; }

    /// <summary>
    /// 回診日期
    /// </summary>
    [Column(TypeName = "date")]
    public DateTime? ReturnVisitDate { get; set; }

    /// <summary>
    /// 是否開啟個管提醒
    /// </summary>
    public bool ActivateNotify { get; set; } = false;

    /// <summary>
    /// 提醒頻率
    /// </summary>
    public NotifyFrequency? NotifyFrequency { get; set; }

    /// <summary>
    /// 選擇周或月 要記錄星期幾或每月幾號
    /// </summary>
    public int? NotifyAtDate { get; set; }

    /// <summary>
    /// 提醒時間
    /// </summary>
    [Column(TypeName = "time")]
    public TimeSpan? NotifyAt { get; set; }

    /// <summary>
    /// 食物建議
    /// </summary>
    public string DietAdvice { get; set; }

    /// <summary>
    /// 藥物建議
    /// </summary>
    public string MedicationAdvice { get; set; }

    /// <summary>
    /// 運動建議
    /// </summary>
    public string ExerciseAdvice { get; set; }

    /// <summary>
    /// 生活作息建議
    /// </summary>
    public string LifestyleAdvice { get; set; }

    /// <summary>
    /// 報告內容
    /// </summary>
    public string Summary { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Memo { get; set; }

    /// <summary>
    /// 編輯者
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 個管建議所屬機構ID
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 建立者GID
    /// </summary>
    [Required]
    public virtual Guid CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [Newtonsoft.Json.JsonIgnore]
    [ForeignKey("CreatedBy")]
    public virtual Account CreatorAccount { get; set; }

    #endregion

    /// <summary>
    /// Line通知Url
    /// </summary>
    [NotMapped]
    public string Url { get; set; }
  }
}
