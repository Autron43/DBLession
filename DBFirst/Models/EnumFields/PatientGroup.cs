namespace DB.EnumFields
{
  /// <summary>
  /// 共照群組狀態
  /// </summary>
  public enum PatientGroupStatus
  {
    /// <summary>
    /// 可用
    /// </summary>
    Available = 0,

    /// <summary>
    /// 已刪除
    /// </summary>
    Deleted = 99
  }

  /// <summary>
  /// 成員異動類型
  /// </summary>
  public enum PatientGroupOperation
  {
    /// <summary>
    /// 加入群組
    /// </summary>
    Add = 0,
    /// <summary>
    /// 移出群組
    /// </summary>
    Remove = 99,
  }
}
