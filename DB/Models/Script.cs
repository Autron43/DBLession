
using mPHR.Services.Database.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class Script
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本名稱
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// 腳本名稱
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// JavaScript的程式內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// Blockly的XML DOM資料
    /// </summary>
    public string Xml { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 建立者Guid
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    /// <summary>
    /// 腳本啟用狀態
    /// </summary>
    public bool Enabled { get; set; }

    /// <summary>
    /// 對任意成員只觸發一次
    /// </summary>
    public bool TriggerOnce { get; set; } = true;

    /// <summary>
    /// 觸發種類
    /// </summary>
    public TriggerType TriggerType { get; set; } = TriggerType.Instant;

    /// <summary>
    /// 觸發時間 
    /// </summary>
    public DateTime? TriggerTime { get; set; }

    /// <summary>
    /// 週期種類
    /// </summary>
    public CronType CronType { get; set; } = CronType.Never;

    /// <summary>
    /// Cron 表達式
    /// </summary>
    [MaxLength(300)]
    public string CronExpression { get; set; }

    /// <summary>
    /// 排程工作Id
    /// </summary>
    public string JobId { get; set; }

    /// <summary>
    /// 是否刪除
    /// </summary>
    public bool IsDeleted { get; set; } = false;

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    public virtual ICollection<ScriptAccount> ScriptAccounts { get; set; }

    public virtual ICollection<PatientGroupScript> GroupScripts { get; set; }

    public virtual ICollection<ScriptTrigger> ScriptTriggers { get; set; }
    #endregion
  }

}