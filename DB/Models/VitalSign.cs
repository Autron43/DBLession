
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class VitalSign
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 收縮壓
    /// </summary>
    public int? Systolic { get; set; }

    /// <summary>
    /// 舒張壓
    /// </summary>
    public int? Diastolic { get; set; }

    /// <summary>
    /// 脈搏
    /// </summary>
    public int? Pulse { get; set; }

    /// <summary>
    /// 血氧
    /// </summary>
    public int? O2 { get; set; }

    /// <summary>
    /// 額溫
    /// </summary>
    public double? BodyTemp { get; set; }

    /// <summary>
    /// 血糖
    /// </summary>
    public int? BloodSugar { get; set; }

    /// <summary>
    /// 血壓量測時狀態
    /// </summary>
    public VitalSignBloodStatus BloodStatus { get; set; }

    /// <summary>
    /// 血糖量測時狀態
    /// </summary>
    public VitalSignSugarStatus SugarStatus { get; set; }

    /// <summary>
    /// 身高
    /// </summary>
    public double? BodyHeight { get; set; }

    /// <summary>
    /// 體重
    /// </summary>
    public double? BodyWeight { get; set; }

    /// <summary>
    /// BMI
    /// </summary>
    public double? BMI { get; set; }

    /// <summary>
    /// 腰圍
    /// </summary>
    public double? WaistLine { get; set; }

    /// <summary>
    /// 待減腰圍
    /// </summary>
    public double? WaistReduce { get; set; }

    /// <summary>
    /// 體脂
    /// </summary>
    public double? BodyFat { get; set; }

    /// <summary>
    /// 內臟脂肪
    /// </summary>
    public double? VatLevel { get; set; }

    /// <summary>
    /// 基礎代謝
    /// </summary>
    public int? BMR { get; set; }

    /// <summary>
    /// 體年齡
    /// </summary>
    public int? MetabolicAge { get; set; }

    /// <summary>
    /// 肌肉含量
    /// </summary>
    public double? MuscleMass { get; set; }

    /// <summary>
    /// 骨量
    /// </summary>
    public double? BoneMass { get; set; }

    /// <summary>
    /// 體水份
    /// </summary>
    public double? BodyWaterMass { get; set; }

    /// <summary>
    /// 握力
    /// </summary>
    public double? GripStr { get; set; }

    /// <summary>
    /// 尿酸
    /// </summary>
    public double? UricAcid { get; set; }

    /// <summary>
    /// 膽固醇
    /// </summary>
    public double? Cholesterol { get; set; }
    /// <summary>
    /// 酮體
    /// </summary>
    public double? Ketone { get; set; }

    /// <summary>
    /// 血色素 (g/dl)
    /// </summary>
    public double? Hb { get; set; }

    /// <summary>
    /// 紅血球容積比 (%)
    /// </summary>
    public double? Hct { get; set; }

    /// <summary>
    /// 乳酸 (mmol/L)
    /// </summary>
    public double? LacticAcid { get; set; }

    /// <summary>
    /// 三酸甘油脂 (mg/dl)
    /// </summary>
    public double? Triglyceride { get; set; }

    /// <summary>
    /// 電子聽診器上傳檔key
    /// </summary>
    public string eStethoscopeKey { get; set; }

    /// <summary>
    /// ATK試劑上傳資料Key
    /// </summary>
    public int? AtkId { get; set; }

    /// <summary>
    /// 量測時間
    /// </summary>
    public DateTime MeasuredAt { get; set; }

    /// <summary>
    /// 資料來源
    /// </summary>
    public VitalSignSource Source { get; set; }

    /// <summary>
    /// 量測設備型號
    /// 例如血壓機、額溫槍的型號
    /// </summary>
    [MaxLength(50)]
    public string DeviceModel { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 建立者Guid
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 量測位置
    /// </summary>
    public int MachineId { get; set; }

    /// <summary>
    /// 設備使用紀錄
    /// </summary>
    public int MachineUsageLogId { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// Apple Health Id
    /// </summary>
    [MaxLength(36)]
    public string AppleHealthId { get; set; }

    /// <summary>
    /// Google Fit Id
    /// </summary>
    [MaxLength(36)]
    public string GoogleFitId { get; set; }

    /// <summary>
    /// 身體量測資訊序號(用來判斷是不是屬於同一組資料)
    /// </summary>
    public Guid? SerialNo { get; set; }


    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    [ForeignKey("AtkId")]
    public virtual AtkRecords AtkRecord { get; set; }

    #endregion
  }
}