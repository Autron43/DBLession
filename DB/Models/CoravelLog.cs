
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class CoravelLog
  {
    /// <summary>
    /// ID
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 排程名稱
    /// </summary>
    public string TaskName { get; set; }

    /// <summary>
    /// 執行結果
    /// </summary>
    public bool Result { get; set; }

    /// <summary>
    /// 執行結果內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 執行日期
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }
  }
}
