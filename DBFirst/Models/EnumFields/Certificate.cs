namespace DB.EnumFields
{
  /// <summary>
  /// 認證類型
  /// </summary>
  public enum AccountCertificateType
  {
    Email = 10,
    Mobile = 20,
    IdentityNo = 30
  }

  /// <summary>
  /// 確認驗證狀態
  /// </summary>
  public enum AccountCertiCheckType
  {
    /// <summary>
    /// 未驗證 或 未於驗證到期時間前驗證
    /// </summary>
    NO = 10,

    /// <summary>
    /// 驗證中
    /// </summary>
    Waiting = 20,

    /// <summary>
    /// 首次驗證中
    /// 曾經回寫過欄位的使用者，進行首次驗證時
    /// </summary>
    WaitingFirst = 21,

    /// <summary>
    /// 已驗證
    /// </summary>
    OK = 30,

    /// <summary>
    /// 驗證內容已被使用過
    /// </summary>
    BeUsed = 40,

    /// <summary>
    /// 簡訊發送配額已使用完
    /// </summary>
    QuotaRunOut = 50
  }
}
