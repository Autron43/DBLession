namespace DB.EnumFields
{
  public enum EventApplyStatus
  {
    /// <summary>
    /// 已報名
    /// </summary>
    Apply = 0,
    /// <summary>
    /// 已取消
    /// </summary>
    Cancel = 1,
    /// <summary>
    /// 已報到
    /// </summary>
    CheckIn = 2,
    /// <summary>
    /// deleted
    /// </summary>
    Deleted = 99
  }

  public enum EventStatus
  {
    /// <summary>
    /// 草稿
    /// </summary>
    Draft = 0,
    /// <summary>
    /// 已發佈
    /// </summary>
    Published = 1,
    /// <summary>
    /// 已取消
    /// </summary>
    Canceled = 2,
    /// <summary>
    /// 報名已開始
    /// </summary>
    Applying = 3,
    /// <summary>
    /// 進行中
    /// </summary>
    Progressing = 4,
    /// <summary>
    /// 已結束
    /// </summary>
    End = 5,
    /// <summary>
    /// 報名尚未開始
    /// </summary>
    ApplyNotStart = 6,
    /// <summary>
    /// 報名名額已滿
    /// </summary>
    ApplyFull = 7,
    /// <summary>
    ///  報名結束
    /// </summary>
    ApplyEnd = 8,
    /// <summary>
    /// delete
    /// </summary>
    Deleted = 99
  }
}
