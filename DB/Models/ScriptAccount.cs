
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class ScriptAccount
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本Id
    /// </summary>
    public int ScriptId { get; set; }

    /// <summary>
    /// 群組腳本Id
    /// </summary>
    public int GroupScriptId { get; set; }

    /// <summary>
    /// 成員帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 最後執行時間
    /// </summary>
    public DateTime? LastExecuted { get; set; }

    /// <summary>
    /// 套用建立者 Gid
    /// </summary>
    public Guid CreatedBy { get; set; }

    #region 關聯

    [ForeignKey("ScriptId")]
    public virtual Script Script { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    [ForeignKey("GroupScriptId")]
    public virtual PatientGroupScript GroupScript { get; set; }

    public virtual ICollection<ScriptAccountJob> ScriptAccountJobs { get; set; }
    #endregion
  }


}