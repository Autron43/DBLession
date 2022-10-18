namespace DB.EnumFields
{
  /// <summary>
  /// 檔案用途
  /// </summary>
  public enum FileUsage
  {
    /// <summary>
    /// 衛教影音封面
    /// </summary>
    CourseCover = 1,

    /// <summary>
    /// 衛教影音附加檔案
    /// </summary>
    CourseAttachment = 2,

    /// <summary>
    /// 機構訊息內文檔案
    /// </summary>
    OrgMsgAttachment = 3,

    /// <summary>
    /// 活動內容
    /// </summary>
    EventContext = 4,

    /// <summary>
    /// mPHR Logo
    /// </summary>
    mphrLogo = 10,

    /// <summary>
    /// mPHR Background image
    /// </summary>
    mphrBackground = 11,

    /// <summary>
    /// Kiosk Logo
    /// </summary>
    kioskLogo = 12,

    /// <summary>
    /// Kiosk Background image
    /// </summary>
    kioskBackground = 13,

    /// <summary>
    /// Kiosk Video
    /// </summary>
    kioskVideo = 14,

    /// <summary>
    /// mPHR Stake Holders Logo
    /// </summary>
    mphrBusinessLogo = 15,

    /// <summary>
    /// ATK試劑佐證照片
    /// </summary>
    atkImage = 16,

    /// <summary>
    /// 彈性表單圖檔
    /// </summary>
    eFormsImage = 17,

    /// <summary>
    /// 機構簡介照片
    /// </summary>
    OrgIntroductionImage = 18,

    /// <summary>
    /// 機構自訂服務照片
    /// </summary>
    OrgCustomServiceImage = 19,

    /// <summary>
    /// 機構人員照片
    /// </summary>
    OrgMemberPhoto = 20,

    /// <summary>
    /// 機構自訂導覽列品牌圖示
    /// </summary>
    MphrNavBrand = 21,

    /// <summary>
    /// APP登入背景圖
    /// </summary>
    AppLoginBackground = 22,

    /// <summary>
    /// APP首頁背景圖
    /// </summary>
    AppHomeBackground = 23,

    /// <summary>
    /// APP個人資料頁背景圖
    /// </summary>
    AppProfileBackground = 24,

    /// <summary>
    /// 暫存檔案(未來可直接刪除)
    /// </summary>
    TemporaryFiles = 25,

    /// <summary>
    /// APP 橫幅圖片
    /// </summary>
    AppBanner = 26

  }

  /// <summary>
  /// 檔案公開度類型
  /// </summary>
  public enum AccessType
  {
    /// <summary>
    /// 不公開
    /// </summary>
    Private = 0,
    /// <summary>
    /// 僅此機構可見
    /// </summary>
    PublicToSelf = 1,
    /// <summary>
    /// 對指定機構公開
    /// </summary>
    PublicToSome = 2,
    /// <summary>
    /// 對所有從屬機構公開
    /// </summary>
    PublicToAll = 3
  }

}
