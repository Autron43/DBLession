
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  /// <summary>
  /// 存放腳本觸發類別為 ScheduleDay 的 JobId
  /// </summary>
  public class ScriptAccountJob
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本對象Id
    /// </summary>
    public int ScriptAccountId { get; set; }

    /// <summary>
    /// HangFireJobId
    /// </summary>
    public string JobId { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    #region 關聯

    [ForeignKey(nameof(ScriptAccountId))]
    public virtual ScriptAccount ScriptAccount { get; set; }

    #endregion
  }


}