using System.ComponentModel.DataAnnotations;

namespace DB.EnumFields
{
  /// <summary>
  /// 血壓量測時狀態
  /// </summary>
  public enum VitalSignBloodStatus
  {
    /// <summary>
    /// 其他(預設)
    /// </summary>
    Other = 0,
    /// <summary>
    /// 晨起
    /// </summary>
    Morning = 1,
    /// <summary>
    /// 睡前
    /// </summary>
    BeforeBedtime = 2,
    /// <summary>
    /// 運動前
    /// </summary>
    BeforeExercise = 3,
    /// <summary>
    /// 運動後
    /// </summary>
    AfterExercise = 4,
  }

  /// <summary>
  /// 血糖量測時狀態
  /// </summary>
  public enum VitalSignSugarStatus
  {
    /// <summary>
    /// 其他(預設)
    /// </summary>
    Other = 0,
    /// <summary>
    /// 早上飯前
    /// </summary>
    BeforeBreakfast = 1,
    /// <summary>
    /// 早上飯後
    /// </summary>
    AfterBreakfast = 2,
    /// <summary>
    /// 中餐飯前
    /// </summary>
    BeforeLunch = 3,
    /// <summary>
    /// 中餐飯後
    /// </summary>
    AfterLunch = 4,
    /// <summary>
    /// 晚餐飯前
    /// </summary>
    BeforeDinner = 5,
    /// <summary>
    /// 晚餐飯後
    /// </summary>
    AfterDinner = 6,
    /// <summary>
    /// 睡前
    /// </summary>
    BeforeBedtime = 7
  }

  /// <summary>
  /// 器官代號
  /// </summary>
  public enum Organ
  {
    Heart = 0,
    Achest = 1,
    Pchest = 2,
    Neck = 3,
    Bowel = 4
  }

  /// <summary>
  /// 電子聽診器模式
  /// </summary>
  public enum ElectronicStethoscopeMode
  {
    B = 0,
    D = 1,
    W = 2
  }

  public enum VitalSignSource
  {
    /// <summary>
    /// HealthStation 一般量測
    /// </summary>
    Kiosk = 0,
    /// <summary>
    /// APP 一般量測
    /// </summary>
    App = 10,
    /// <summary>
    /// mPHR Cloud 手動輸入
    /// </summary>
    Web = 20,
    /// <summary>
    /// 其他裝置輸入
    /// </summary>
    OtherDevice = 30,
    /// <summary>
    /// HealthStation 手動輸入
    /// </summary>
    KioskHandWrite = 40,
    /// <summary>
    /// LinkBox
    /// </summary>
    LinkBox = 50,
    /// <summary>
    /// APP 手動輸入
    /// </summary>
    AppHandWrite = 60,
    /// <summary>
    /// HealthGoBox 享健康隨行包
    /// </summary>
    HealthGoBox = 70,
    /// <summary>
    /// HealthGoBox 享健康隨行包 手動輸入
    /// </summary>
    HealthGoBoxHandWrite = 80,
    /// <summary>
    /// FastGo 防疫大師
    /// </summary>
    FastGo = 90,
    /// <summary>
    /// FastGo 防疫大師 手動輸入
    /// </summary>
    FastGoHandWrite = 100,
    /// <summary>
    /// 福爾 Fora 設備上傳
    /// </summary>
    ForaCare = 110,
    /// <summary>
    /// AppleHealth App同步
    /// </summary>
    AppleHealth = 120,
    /// <summary>
    /// AppleHealth App同步 (資料為手寫)
    /// </summary>
    AppleHealthHandWrite = 121,
    /// <summary>
    /// GoogleFit App同步
    /// </summary>
    GoogleFit = 130,
    /// <summary>
    /// Line手動輸入
    /// </summary>
    LineHandWrite = 140,
    /// <summary>
    /// D+平台
    /// </summary>
    Dplus = 150
  }

  public enum TestType
  {
    BloodPressure = 0,
    BodyTemp = 10,
    BodyWeight = 20,
    BodyHeight = 30,
    O2Saturation = 40,
    BloodSugar = 50,
    BodyFat = 60,
    Waist = 70,
    UricAcid = 80,
    GripStr = 90,
    Cholesterol = 100,
    Ketone = 110,
    Hb = 120,
    Hct = 130,
  }

  public enum TestItem
  {
    [Display(Name = "VitalSign_BloodPressure_Systolic")]
    Systolic = 0,
    [Display(Name = "VitalSign_BloodPressure_Diastolic")]
    Diastolic = 10,
    [Display(Name = "VitalSign_BloodPressure_Pulse")]
    Pulse = 20,
    [Display(Name = "VitalSign_BodyTemp")]
    Temperature = 30,
    [Display(Name = "VitalSign_BodyWeight")]
    BodyWeight = 40,
    [Display(Name = "VitalSign_BodyHeight")]
    BodyHeight = 50,
    [Display(Name = "VitalSign_BodyWeight_BMI")]
    BMI = 60,
    [Display(Name = "VitalSign_O2")]
    SpO2 = 70,
    [Display(Name = "VitalSign_BloodSugar")]
    BloodSugar = 80,
    [Display(Name = "VitalSign_BodyFat")]
    BodyFat = 90,
    [Display(Name = "VitalSign_VatLevel")]
    VatLevel = 100,
    [Display(Name = "VitalSign_BMR")]
    Bmr = 110,
    [Display(Name = "VitalSign_MetabolicAge")]
    MetabolicAge = 120,
    [Display(Name = "VitalSign_MuscleMass")]
    MuscleMass = 130,
    [Display(Name = "VitalSign_BoneMass")]
    BoneMass = 140,
    [Display(Name = "VitalSign_BodyWaterMass")]
    BodyWaterMass = 150,
    [Display(Name = "VitalSign_Waistline")]
    Waistline = 160,
    [Display(Name = "VitalSign_WaistReduce")]
    WaistReduce = 170,
    [Display(Name = "VitalSign_UricAcid")]
    UricAcid = 180,
    [Display(Name = "VitalSign_GripStr")]
    GripStr = 190,
    [Display(Name = "VitalSign_Cholesterol")]
    Cholesterol = 200,
    [Display(Name = "VitalSign_Ketone")]
    Ketone = 210,
    [Display(Name = "VitalSign_Hb")]
    Hb = 220,
    [Display(Name = "VitalSign_Hct")]
    Hct = 230,
    [Display(Name = "VitalSign_StepRecord")]
    StepRecord = 240,
    [Display(Name = "VitalSign_Sleep")]
    Sleep = 250,
    [Display(Name = "VitalSign_LacticAcid")]
    LacticAcid = 260,
    [Display(Name = "VitalSign_Triglyceride")]
    Triglyceride = 270
  }

  /// <summary>
  /// V3 App統一規格
  /// </summary>
  public enum VitalSignCategory
  {
    Pressure = 0,
    Pulse = 10,
    BodyTemp = 20,
    BodyWeight = 30,
    O2 = 40,
    BloodSugar = 50,
    BodyFat = 60,
    BodyFat_v2 = 61,
    VatLevel = 70,
    Waist = 80,
    BMR = 90,
    MetabolicAge = 100,
    MuscleMass = 110,
    BoneMass = 120,
    BodyWaterMass = 130,
    BodyHeight = 140,
    Cholesterol = 150,
    Ketone = 160,
    GripStr = 170,
    UricAcid = 180,
    Hb = 190,
    Hct = 200,
    Atk = 210,
    LacticAcid = 220,
    Triglyceride = 230
  }

  /// <summary>
  /// ATK 驗證狀態
  /// </summary>
  public enum AtkApprovedStatus
  {
    /// <summary>
    /// 資料未經驗證
    /// </summary>
    NotApproved = 0,

    /// <summary>
    /// 資料已經驗證
    /// </summary>
    Approved = 1,
  }

  public enum SleepQuality
  {
    /// <summary>
    /// 未知(預設)
    /// </summary>
    [Display(Name = "Comm_Unknow")]
    Unknown = 99,
    /// <summary>
    /// 稍差
    /// </summary>
    [Display(Name = "Comm_SlightlyWorse")]
    SlightlyWorse = -1,
    /// <summary>
    /// 普通
    /// </summary>
    [Display(Name = "VitalSign_Normal")]
    Normal = 0,
    /// <summary>
    /// 良好
    /// </summary>
    [Display(Name = "Comm_Good")]
    Good = 1,
  }
}

namespace mPHR.Services.Database.VitalSignAnalysis
{
  public enum Pressure
  {
    none, //無值

    [Display(Name = "VitalSign_Hypotension")]
    hypotension, //低血壓

    [Display(Name = "VitalSign_Pressure_Normal")]
    desired,  //正常

    [Display(Name = "VitalSign_Hypertension_Prehypertension")]
    prehypertension,  //前期高血壓

    [Display(Name = "VitalSign_Stage1_Hypertension")]
    Stage1_hypertension, //第一期高血壓

    [Display(Name = "VitalSign_Stage2_Hypertension")]
    Stage2_hypertension, //第二期高血壓
  }

  public enum Systolic
  {
    none,//無值
    [Display(Name = "VitalSign_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_High")]
    high, //偏高
  }

  public enum Diastolic
  {
    none,//無值
    [Display(Name = "VitalSign_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_High")]
    high, //偏高
  }

  public enum Pulse
  {
    none,//無值
    [Display(Name = "VitalSign_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_High")]
    high, //偏高
  }

  public enum Bmi
  {
    none,//無值
    [Display(Name = "VitalSign_BMI_Underweight")]
    underweight,  //過輕

    [Display(Name = "VitalSign_BMI_Normal")]
    normal, //正常

    [Display(Name = "VitalSign_BMI_OverWeight")]
    overweight, //偏重

    [Display(Name = "VitalSign_BMI_Moderately_Obese")]
    moderately_obese, //輕度肥胖

    [Display(Name = "VitalSign_BMI_Severely_Obese")]
    severely_obese, //中度肥胖

    [Display(Name = "VitalSign_BMI_Very_Severely_Obese")]
    very_severely_obese, //重度肥胖
  }

  public enum Temperature
  {
    none,//無值
    [Display(Name = "VitalSign_Temperature_Normal", ShortName = "VitalSign_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Temperature_Low", ShortName = "VitalSign_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_Temperature_High", ShortName = "VitalSign_High")]
    high, //偏高
  }

  public enum Cholesterol
  {
    none,//無值
    [Display(Name = "VitalSign_Cholesterol_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Cholesterol_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_Cholesterol_High")]
    high, //偏高
  }

  public enum Ketone
  {
    none,//無值
    [Display(Name = "VitalSign_Ketone_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_Ketone_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_Ketone_High")]
    high, //偏高

    [Display(Name = "VitalSign_Ketone_VeryHigh")]
    veryHigh,//過高
  }

  public enum Oxygen
  {
    none,//無值
    [Display(Name = "VitalSign_Oxygen_Normal", ShortName = "VitalSign_Normal")]
    normal,  //正常
    [Display(Name = "VitalSign_Oxygen_Abnormal", ShortName = "VitalSign_Abnormal_Short")]
    Abnormal //異常
  }

  public enum Bodyfat
  {
    none,//無值
    noGender,//無性別
    [Display(Name = "VitalSign_BodyFat_Normal")]
    normal,  //正常

    [Display(Name = "VitalSign_BodyFat_Low")]
    low,  //偏低

    [Display(Name = "VitalSign_BodyFat_High")]
    high, //偏高

    [Display(Name = "VitalSign_BodyFat_Too_High")]
    very_high //過高
  }

  public enum Vatlevel
  {
    none,			//無值
    [Display(Name = "VitalSign_BodyFat_Normal")]
    normal,		//正常
    [Display(Name = "VitalSign_BodyFat_High")]
    high,    //偏高
    [Display(Name = "VitalSign_BodyFat_Too_High")]
    very_high  //過高
  }

}
