
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class EightDimensionReport
  {
    /// <summary>
    /// 八大面向報告流水號
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 使用者流水號
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 測驗報告的Guid(由系統自行產生)
    /// </summary>
    public Guid QuestionnaireGid { get; set; }

    /// <summary>
    /// 測驗類別
    /// </summary>
    public EightDimensionReportCategory Category { get; set; }

    /// <summary>
    /// 測驗項目
    /// </summary>
    public string Type { get; set; }

    /// <summary>
    /// 健康狀態
    /// </summary>
    public EightDimensionReportLabel LabelValue { get; set; }

    /// <summary>
    /// BMI測驗結果
    /// </summary>
    public string BmiResult { get; set; }

    /// <summary>
    /// BMI數值
    /// </summary>
    public float? BmiValue { get; set; }

    /// <summary>
    /// 檢測時間
    /// </summary>
    public DateTime TestAt { get; set; }

    /// <summary>
    /// 建立測驗的人
    /// </summary>
    public string Creator { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯
    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
    #endregion
  }
}
