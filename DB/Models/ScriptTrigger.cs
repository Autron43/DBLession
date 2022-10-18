
using DB.EnumFields;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class ScriptTrigger
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本Id
    /// </summary>
    public int ScriptId { get; set; }

    /// <summary>
    /// 觸發種類
    /// </summary>
    public TriggerType TriggerType { get; set; } = TriggerType.Instant;

    /// <summary>
    /// 觸發時間 
    /// </summary>
    public DateTime? ScheduleTime { get; set; }

    /// <summary>
    /// 延遲時間Tick
    /// 請使用DelayTimeSpan
    /// </summary>
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public long? DelayTimeTicks { get; set; }

    [NotMapped]
    public TimeSpan? DelayTimeSapn
    {
      get
      {
        if (DelayTimeTicks.HasValue) return TimeSpan.FromTicks(DelayTimeTicks.Value);
        return null;
      }
      set { DelayTimeTicks = value?.Ticks; }
    }

    /// <summary>
    /// Cron 表達式
    /// </summary>
    [MaxLength(300)]
    public string CronExpression { get; set; }

    /// <summary>
    /// 事件處發器種類
    /// </summary>
    public TriggerEventType EventType { get; set; }

    /// <summary>
    /// 排程工作Id
    /// </summary>
    /// <remarks>
    /// Schedule : Blockly:{ScriptId}:Scheduled
    /// 
    /// </remarks>
    public string JobId { get; set; }

    public DateTime CreatedAt { get; set; }

    #region 關聯
    [ForeignKey(nameof(ScriptId))]
    public virtual Script Script { get; set; }
    #endregion
  }

}