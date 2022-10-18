namespace DB.EnumFields
{
  /// <summary>
  /// 簡訊類型
  /// </summary>
  public enum SmsType
  {
    /// <summary>
    /// 忘記密碼
    /// </summary>
    ForgetPassword = 1,
    /// <summary>
    /// 個案管理
    /// </summary>
    Case = 2,
    /// <summary>
    /// 志工發送訊息
    /// </summary>
    Volunteer = 3,
    /// <summary>
    /// 簡訊驗證
    /// </summary>
    Verification = 4,
    /// <summary>
    /// 量測訊息
    /// </summary>
    VitalSign = 5,
    /// <summary>
    /// 共照群組發送訊息
    /// </summary>
    PatientGroup = 6,
    /// <summary>
    /// 批次簡訊發送
    /// </summary>
    GroupSend = 7,
  }

  /// <summary>
  /// Every8D簡訊發送狀態
  /// </summary>
  public enum Every8DStatus
  {
    /// <summary>
    /// 發送失敗
    /// </summary>
    Failed = -100,
    /// <summary>
    /// 點數餘額不足
    /// </summary>
    NotEnoughPoint = -101,
    /// <summary>
    /// 訊息已成功傳送給電信端，電信基地台與受話⽅⼿機溝通中
    /// </summary>
    Sending = 0,
    /// <summary>
    /// 成功送達⼿機
    /// </summary>
    Success = 100,
    /// <summary>
    /// 電信端回覆因受話⽅⼿機關機/訊號不良/簡訊功能異常等原因，該訊息無法送達受話⽅⼿機
    /// </summary>
    UserMoblieError = 101,
    /// <summary>
    /// 電信端回覆因網路系統/基地台設備異常等原因，該訊息無法送達受話⽅⼿機
    /// </summary>
    SMS_InternetError = 102,
    /// <summary>
    /// 電信端回覆因受話⽅⼿機⾨號為空號或停⽤中，該訊息無法送達受話⽅⼿機
    /// </summary>
    NumberNotExist = 103,
    /// <summary>
    /// 電信端回覆因受話⽅⼿機規格不符(⼭寨機或海外機)，該訊息無法送達受話⽅⼿機
    /// </summary>
    UserEquipmentNotSupport = 104,
    /// <summary>
    /// 電信端回覆因受話⽅⼿機設備問題/⼿機出現未預期錯誤等原因，該訊息無法送達受話⽅⼿機
    /// </summary>
    UserEquipmentError = 105,
    /// <summary>
    /// 電信端回覆因系統傳送時發⽣非預期錯誤，該訊息無法送達受話⽅⼿機
    /// </summary>
    UnknownError = 106,
    /// <summary>
    /// 電信端回覆因受話⽅⼿機關機/訊號不良/簡訊功能異常等原因，該訊息無法送達受話⽅⼿機
    /// </summary>
    UserPhonePowerOff = 107,
    /// <summary>
    /// 預約簡訊
    /// </summary>
    Scheduled = 300,
    /// <summary>
    /// 取消預約
    /// </summary>
    Canceled = 303,
    /// <summary>
    /// 表該⾨號為國際⾨號，請⾄系統設定開啟國際簡訊發送功能
    /// </summary>
    InternationalNumber = 500,
    /// <summary>
    /// 回覆簡訊
    /// </summary>
    Reply = 999,
    /// <summary>
    /// 參數錯誤，該訊息傳送失敗
    /// </summary>
    ParameterError = -1,
    /// <summary>
    /// API 帳號或密碼錯誤，該訊息傳送失敗
    /// </summary>
    APIAuthenticateError = -2,
    /// <summary>
    /// 受話⽅⼿機號碼錯誤或是簡訊⿊名單，該訊息傳送失敗
    /// </summary>
    NumberError = -3,
    /// <summary>
    /// 訊息預計發送時間已逾期 24 ⼩時以上，該訊息傳送失敗
    /// </summary>
    TimeOut24Hr = -4,
    /// <summary>
    /// Short Message 內容⻑度超過限制，該訊息傳送失敗
    /// </summary>
    MessageLengthExcess = -5,
    /// <summary>
    /// DT(預計發送時間)格式錯誤，該訊息傳送失敗
    /// </summary>
    DTError = -6,
    /// <summary>
    /// 主機端發⽣不明錯誤，請與廠商窗⼝聯繫。
    /// </summary>
    Every8DUnknownError = -99
  }
}
