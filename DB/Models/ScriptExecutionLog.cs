
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class ScriptExecutionLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本ID
    /// </summary>
    public int ScriptId { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 是否正常執行
    /// </summary> 
    public bool Success { get; set; }

    /// <summary>
    /// 執行結果回傳的訊息
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey(nameof(ScriptId))]
    public virtual Script Script { get; set; }

    [ForeignKey(nameof(AccountGid))]
    public virtual Account Account { get; set; }
    #endregion
  }
}