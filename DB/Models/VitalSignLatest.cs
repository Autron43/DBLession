using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  /// <summary>
  /// 使用者最新一筆量測資料表
  /// </summary>
  public class VitalSignLatest
  {
    /// <summary>
    /// 量測資料使用者GID
    /// </summary>
    [Key]
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 量測資料 - 收縮壓
    /// </summary>
    public int? Systolic { get; set; }

    /// <summary>
    /// 量測資料 - 舒張壓
    /// </summary>
    public int? Diastolic { get; set; }

    /// <summary>
    /// 量測資料 - 脈搏
    /// </summary>
    public int? Pulse { get; set; }

    /// <summary>
    /// 量測資料 - 血壓量測時間
    /// </summary>
    public DateTime? PressureTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血壓 
    /// </summary>
    public VitalSignSource? PressureSource { get; set; }

    /// <summary>
    /// 量測資料 - 身高
    /// </summary>
    public double? BodyHeight { get; set; }

    /// <summary>
    /// 量測資料 - 體重
    /// </summary>
    public double? BodyWeight { get; set; }

    /// <summary>
    /// 量測資料 - BMI
    /// </summary>
    public double? BMI { get; set; }

    /// <summary>
    /// 量測資料 - 身高體重量測時間
    /// </summary>
    public DateTime? HeightWeightTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 身高體重 
    /// </summary>
    public VitalSignSource? HeightWeightSource { get; set; }

    /// <summary>
    /// 量測資料 - 體溫
    /// </summary>
    public double? BodyTemp { get; set; }

    /// <summary>
    /// 量測資料 - 體溫量測時間
    /// </summary>
    public DateTime? BodyTempTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 體溫 
    /// </summary>
    public VitalSignSource? BodyTempSource { get; set; }

    /// <summary>
    /// 量測資料 - 血氧
    /// </summary>
    public int? O2 { get; set; }

    /// <summary>
    /// 量測資料 - 血氧量測時間
    /// </summary>
    public DateTime? BloodO2TestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血氧
    /// </summary>
    public VitalSignSource? BloodO2Source { get; set; }

    /// <summary>
    /// 量測資料 - 血糖
    /// </summary>
    public int? BloodSugar { get; set; }

    /// <summary>
    /// 量測資料 - 血糖量測時狀態
    /// </summary>
    public VitalSignSugarStatus? SugarStatus { get; set; }

    /// <summary>
    /// 量測資料 - 血糖量測時間
    /// </summary>
    public DateTime? BloodSugarTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血糖
    /// </summary>
    public VitalSignSource? BloodSugarSource { get; set; }

    /// <summary>
    /// 量測資料 - 體脂肪
    /// </summary>
    public double? BodyFat { get; set; }

    /// <summary>
    /// 量測資料 - 內臟脂肪
    /// </summary>
    public double? VatLevel { get; set; }

    /// <summary>
    /// 量測資料 - 體脂肪量測時間
    /// </summary>
    public DateTime? BodyFatTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 體脂肪
    /// </summary>
    public VitalSignSource? BodyFatSource { get; set; }

    /// <summary>
    /// 量測資料 - 握力
    /// </summary>
    public double? GripStr { get; set; }

    /// <summary>
    /// 量測資料 - 握力量測時間
    /// </summary>
    public DateTime? GripStrTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 握力
    /// </summary>
    public VitalSignSource? GripStrSource { get; set; }

    /// <summary>
    /// 量測資料 - 尿酸
    /// </summary>
    public double? UricAcid { get; set; }

    /// <summary>
    /// 量測資料 - 尿酸量測時間
    /// </summary>
    public DateTime? UricAcidTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 尿酸
    /// </summary>
    public VitalSignSource? UricAcidSource { get; set; }

    /// <summary>
    /// 量測資料 - 膽固醇
    /// </summary>
    public double? Cholesterol { get; set; }

    /// <summary>
    /// 量測資料 - 膽固醇量測時間
    /// </summary>
    public DateTime? CholesterolTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 膽固醇
    /// </summary>
    public VitalSignSource? CholesterolSource { get; set; }

    /// <summary>
    /// 量測資料 - 血酮
    /// </summary>
    public double? Ketone { get; set; }

    /// <summary>
    /// 量測資料 - 血酮量測時間
    /// </summary>
    public DateTime? KetoneTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血酮
    /// </summary>
    public VitalSignSource? KetoneSource { get; set; }

    /// <summary>
    /// 量測資料 - 血色素
    /// </summary>
    public double? Hb { get; set; }

    /// <summary>
    /// 量測資料 - 血色素量測時間
    /// </summary>
    public DateTime? HbTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血色素
    /// </summary>
    public VitalSignSource? HbSource { get; set; }

    /// <summary>
    /// 量測資料 - 血容比
    /// </summary>
    public double? Hct { get; set; }

    /// <summary>
    /// 量測資料 - 血容比量測時間
    /// </summary>
    public DateTime? HctTestTime { get; set; }

    /// <summary>
    /// 資料來源 - 血色素
    /// </summary>
    public VitalSignSource? HctSource { get; set; }

    /// <summary>
    /// 量測資料 - Atk
    /// </summary>
    [MaxLength(50)]
    public string Atk { get; set; }

    /// <summary>
    /// 量測資料 - 驗證狀態
    /// </summary>
    public VerifyStatus? AtkApprovedStatus { get; set; }

    /// <summary>
    /// 量測資料 - Atk量測時間
    /// </summary>
    public DateTime? AtkTestTime { get; set; }

    /// <summary>
    /// 資料來源 - Atk
    /// </summary>
    public VitalSignSource? AtkSource { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }

}
