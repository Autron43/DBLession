
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class ElectronicStethoscopeRecord
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 可以連結到VitalSignInternal的KEY
    /// </summary>
    public string ElectronicStethoscopeKey { get; set; }
    /// <summary>
    /// 器官
    /// </summary>
    public Organ Organ { get; set; }
    /// <summary>
    /// 位置
    /// </summary>
    public int Position { get; set; }
    /// <summary>
    /// 電子聽診器模式
    /// </summary>
    public ElectronicStethoscopeMode Mode { get; set; }
    /// <summary>
    /// 錄音檔網址
    /// </summary>
    public string AudioRecordFile { get; set; }
    /// <summary>
    /// 錄音檔檔名
    /// </summary>
    public string AudioRecordFileName { get; set; }
    /// <summary>
    /// 檔案大小
    /// </summary>
    public int ContentLength { get; set; }
    /// <summary>
    /// 測量時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-ddTHH:mm:sszzz}")]
    public DateTime UserMeasureTime { get; set; }
    /// <summary>
    /// 上傳日期
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

  }
}
