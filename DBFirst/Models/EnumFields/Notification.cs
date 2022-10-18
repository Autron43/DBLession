namespace DB.EnumFields
{
  /// <summary>
  /// 推播訊息類別
  /// </summary>
  public enum NotifyContentType
  {
    /// <summary>
    /// 個管
    /// </summary>
    CaseManagement = 1,
    /// <summary>
    /// 衛教推薦
    /// </summary>
    Course = 2,
    /// <summary>
    /// 機構訊息
    /// </summary>
    OrgMsg = 3,
    /// <summary>
    /// 量測數值
    /// </summary>
    VitalSign = 4,
    /// <summary>
    /// 共照群組發送訊息
    /// </summary>
    PatientGroup = 5,
    /// <summary>
    /// 電訪推播
    /// </summary>
    Call = 6,
    /// <summary>
    /// 防疫大師
    /// </summary>
    FastGo = 7,
    /// <summary>
    /// 量表推薦
    /// </summary>
    FormRecommend = 8,
    /// <summary>
    /// 留言推播
    /// </summary>
    Comment = 9,
    /// <summary>
    /// 批次量表推播
    /// </summary>
    BatchFormRecommend = 10,
    /// <summary>
    /// 活動
    /// </summary>
    Event = 11,
    /// <summary>
    /// 健康福利社
    /// </summary>
    Shop = 12,
  }

  /// <summary>
  /// 推播Token類別
  /// </summary>
  public enum NotifyTokenType
  {
    /// <summary>
    /// firebasee
    /// </summary>
    Fcm = 1,
    /// <summary>
    /// LineNotify
    /// </summary>
    LineNotify = 2,
    /// <summary>
    /// Line使用者Id (頻道內推播)
    /// </summary>
    LineUserId = 3
  }

  /// <summary>
  /// FCM推播訊息類別，用於手機端辨識通知類型
  /// </summary>
  public enum FCMNotifyType
  {
    /// <summary>
    /// 一般通知
    /// </summary>
    Common = 0,
    /// <summary>
    /// 生理量測
    /// </summary>
    VitalSign = 1,
    /// <summary>
    /// 個管通知
    /// </summary>
    Case = 2,
    /// <summary>
    /// 衛教推薦
    /// </summary>
    Course = 3,
    /// <summary>
    /// 機構訊息
    /// </summary>
    OrgMsg = 4,
    /// <summary>
    /// 遠距視訊通知
    /// </summary>
    VideoConCall = 5,
    /// <summary>
    /// 量表推薦
    /// </summary>
    FormRecommend = 6,
    /// <summary>
    /// 共照群組
    /// </summary>
    PatientGroup = 7,
    /// <summary>
    /// FastGo
    /// </summary>
    FastGo = 8,
    /// <summary>
    /// 個管建議留言
    /// </summary>
    Comment_CaseManagement = 9,
    /// <summary>
    /// 衛教資訊留言
    /// </summary>
    Comment_Course = 10,
    /// <summary>
    /// 批次量表推播
    /// </summary>
    BatchFormRecommend = 11,
  }

  public enum EventContentType
  {
    Unknown = 0,

    #region 個案管理

    /// <summary>
    /// 新增個管建議 (content: CaseManegement)
    /// </summary>
    CaseManegementCreate = 10,
    /// <summary>
    /// 通知管理員個管建議有新留言 (content: Comment)
    /// </summary>
    CaseManegementCommentByPatient = 11,
    /// <summary>
    /// 通知用戶個管建議有新留言
    /// </summary>
    CaseManegementCommentByCaregiver = 12,
    /// <summary>
    /// 通知管理員個管建議有新回覆 (content: Comment)
    /// </summary>
    CaseManegementReplyByPatient = 13,
    /// <summary>
    /// 通知用戶個管建議有新回覆 (content: Comment)
    /// </summary>
    CaseManegementReplyByCaregiver = 14,

    #endregion

    #region 衛教課程

    /// <summary>
    /// 機構新增一則衛教 (content: Course)
    /// </summary>
    CourseCreate = 20,
    /// <summary>
    /// 機構新增一則衛教給用戶 (content: CourseRecommend)
    /// </summary>
    CourseRecommend = 21,
    /// <summary>
    /// 通知作者有新回覆 (content: Comment)
    /// </summary>
    CourseComment = 22,
    /// <summary>
    /// 通知留言人有新回覆 (content: Comment)
    /// </summary>
    CourseReply = 23,

    #endregion

    #region 推薦量表

    /// <summary>
    /// 通知用戶有新的量表推薦 (content: FormRecommend)
    /// </summary>
    FormRecommend = 30,

    #endregion

    #region 機構訊息

    /// <summary>
    /// 通知用戶機構有新訊息 (content: OrganizationMessage)
    /// </summary>
    OrgMsg = 40,

    #endregion

    #region 活動

    /// <summary>
    /// 通知用戶機構有新活動 (content: Event)
    /// </summary>
    EventCreate = 50,
    /// <summary>
    /// 通知機構活動有新的參加者 (content: EventApplication)
    /// </summary>
    EventApply = 51,

    #endregion

    #region 健康福利社

    /// <summary>
    /// 通知用戶機構有新上架商品 (content: ShopProduct)
    /// </summary>
    ShopProductCreate = 60,
    /// <summary>
    /// 通知管理員有人兌換商品 (content: ShopPurchaseLog)
    /// </summary>
    ShopPurchase = 61,

    #endregion

    #region 量測通知

    /// <summary>
    /// 使用者量測後通知 (與推播訊息相同，content: VitalSignId)
    /// </summary>
    VitalSign = 90,

    #endregion

    #region 系統訊息

    SystemUpdate = 100,
    SystemMaintain = 101,
    SystemSatisfactionSurvey = 102,

    #endregion
  }
}
