using System.ComponentModel.DataAnnotations;

namespace DB.EnumFields
{
  /// <summary>
  /// 帳號狀態
  /// </summary>
  public enum AccountStatus
  {
    /// <summary>
    /// 可用
    /// </summary>
    Available = 0,

    /// <summary>
    /// 鎖定
    /// </summary>
    Lockout = 10,

    /// <summary>
    /// 刪除
    /// </summary>
    Delete = 20
  }

  /// <summary>
  /// 性別
  /// </summary>
  public enum AccountGender
  {
    /// <summary>
    /// 未知
    /// </summary>
    [Display(Name = "Comm_Unknow")]
    Unknow = 0,

    /// <summary>
    /// 男性
    /// </summary>
    [Display(Name = "Comm_male")]
    Male = 10,

    /// <summary>
    /// 女性
    /// </summary>
    [Display(Name = "Comm_Female")]
    Female = 20,

    /// <summary>
    /// 其他
    /// </summary>
    [Display(Name = "Comm_Other")]
    Other = 30
  }

  public enum AccountBlood
  {
    [Display(Name = "Comm_None")]
    Unknown = 0,

    [Display(Name = "Comm_Blood_A")]
    A = 10,

    [Display(Name = "Comm_Blood_AB")]
    AB = 20,

    [Display(Name = "Comm_Blood_B")]
    B = 30,

    [Display(Name = "Comm_Blood_O")]
    O = 40,

    [Display(Name = "Comm_Blood_Other")]
    Other = 50,
  }

  public enum RegisterSource
  {
    /// <summary>
    /// 未知
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// Kiosk
    /// </summary>
    Kiosk = 1,
    /// <summary>
    /// 診間院所
    /// </summary>
    Clinic = 2,
    /// <summary>
    /// mPHR
    /// </summary>
    Web = 3,
    /// <summary>
    /// APP
    /// </summary>
    Mobile = 4,
    /// <summary>
    /// LinkBox
    /// </summary>
    LinkBox = 5,
    /// <summary>
    /// 中華EHS
    /// </summary>
    Ehs = 6,
    /// <summary>
    /// 享健康隨行包
    /// </summary>
    HealthGo = 7,
    /// <summary>
    /// LINE@
    /// </summary>
    Line = 8,
    /// <summary>
    /// 銀髮俱樂部
    /// </summary>
    SeniorCitizen = 9,
  }

  public enum LoginType
  {
    /// <summary>
    /// 帳號 or 行動電話號碼
    /// </summary>
    IdLogin = 0,
    /// <summary>
    /// 手環號碼
    /// </summary>
    NfcLogin = 10,
    /// <summary>
    /// 感應卡號碼
    /// </summary>
    CardLogin = 20,
    /// <summary>
    /// 身分證字號
    /// </summary>
    NHICardLogin = 30,
    /// <summary>
    /// FaceBook
    /// </summary>
    FaceBookLogin = 40,
    /// <summary>
    /// Line@
    /// </summary>
    LineLogin = 50,
    /// <summary>
    /// Apple
    /// </summary>
    AppleLogin = 60,
    /// <summary>
    /// 防疫大師
    /// </summary>
    FastGoLogin = 70,
    /// <summary>
    /// 照護包
    /// </summary>
    HealthGoLogin = 80,
    /// <summary>
    /// 企業帳號登入
    /// </summary>
    EmpLogin = 90,
    /// <summary>
    /// 未知帳號類型
    /// </summary>
    Unknown = 100
  }
  public enum Language
  {
    [Display(Name = "繁體中文")]
    zh_TW = 0,

    [Display(Name = "English")]
    en_US = 10
  }
}
