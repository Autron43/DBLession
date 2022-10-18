namespace DB.EnumFields
{
  /// <summary>
  /// 腳本觸發條件
  /// </summary>
  /// 這個條件決定腳本的觸發時機
  /// 啟用腳本、或套用至成員時會檢查此項目，然後將執行工作排入HangFire中，產生一個JobId。
  /// JobId 用於取消排程中的工作；不同的類別產生的JobId會存在不同的位置；
  /// 例如：
  /// Instant => 會直接執行，因此不需要紀錄 JobId
  /// Schedule => 存於 [ScriptTrigger].[JobId]
  /// Recurring => 存於 [ScriptTrigger].[JobId]
  /// ScheduleDay => 存於 [ScriptAccountJob].[JobId]
  /// Event => 於事件發生時判斷用，不需要紀錄 JobId
  public enum TriggerType
  {
    /// <summary>
    /// 立即執行
    /// </summary>
    Instant = 0,
    /// <summary>
    /// 預約執行 (At [ScriptTrigger].[JobId])
    /// </summary>
    Schedule = 1,
    /// <summary>
    /// 週期執行 (At [ScriptTrigger].[JobId])
    /// </summary>
    Recurring = 2,
    /// <summary>
    /// 套用後天數執行 (At [ScriptAccountJob].[JobId])
    /// </summary>
    ScheduleDay = 3,
    /// <summary>
    /// 事件
    /// </summary>
    Event = 4,
  }

  /// <summary>
  /// 事件觸發器種類
  /// </summary>
  public enum TriggerEventType
  {
    VitalSign_Upload = 10,
    Form_Submit = 20,
    Event_Apply = 30,
    Atk_Verify = 40,
  }

  public enum CronType
  {
    Never = 0,
    Minutely = 10,
    Hourly = 20,
    Daily = 30,
    Weekly = 40,
    Monthly = 50,
  }

  public enum ScriptTargetType
  {
    None = 0,

    /// <summary>
    /// 對象為成員
    /// </summary>
    Member = 1,

    /// <summary>
    /// 對象為群組
    /// </summary>
    Group = 2,

    /// <summary>
    /// 只套用到群組新進成員
    /// </summary>
    NewMember = 3,
  }
}
