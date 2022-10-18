namespace DB.EnumFields
{
  /// <summary>
  /// 動態類別
  /// </summary>
  public enum NewsCategory
  {
    /// <summary>
    /// 全部
    /// </summary>
    All = 0,
    /// <summary>
    /// 衛教
    /// </summary>
    Course = 1,
    /// <summary>
    /// 個案
    /// </summary>
    Case = 2,
    /// <summary>
    /// 衛教推薦
    /// </summary>
    CourseRecommend = 3,
    /// <summary>
    /// 機構訊息
    /// </summary>
    OrgMsg = 4,
    /// <summary>
    /// 量表推薦
    /// </summary>
    FormRecommend = 5,
  }

  /// <summary>
  /// 動態內容模式
  /// </summary>
  public enum NewsMode
  {
    /// <summary>
    /// 文章
    /// </summary>
    Text = 1,

    /// <summary>
    /// 外部連結
    /// </summary>
    Link = 2
  }

  /// <summary>
  /// 動態消息排序格式
  /// </summary>
  public enum NewsSortBy
  {
    /// <summary>
    /// 最新排序
    /// </summary>
    Newest = 0,
    /// <summary>
    /// 最舊排序
    /// </summary>
    Oldest = 1,
    /// <summary>
    /// 最多觀看排序
    /// </summary>
    MostViewed = 2,
  }
}
