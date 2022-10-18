using System;

namespace DB.EnumFields
{
  public enum NotifyFrequency
  {
    Daily = 1,
    Weekly = 2,
    Monthly = 3
  }

  [Flags]
  public enum CaseManagemenetCallType : int
  {
    /// <summary>
    /// 電訪紀錄
    /// </summary>
    HealthCall = 1,

    /// <summary>
    /// 推播
    /// </summary>
    Push = 1 << CaseManagemenetCallType.HealthCall,

    /// <summary>
    /// 簡訊
    /// </summary>
    SMS = 1 << CaseManagemenetCallType.HealthCall,
  }
}
