
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace mPHR.Services.Database.Models
{
  public class AtkRecords
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 試驗結果
    /// </summary>
    public string Result { get; set; }

    /// <summary>
    /// 受驗者GID
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 檢驗者帳號GID
    /// </summary>
    public Guid InspectorGid { get; set; }

    /// <summary>
    /// 檢測上傳照片
    /// </summary>
    public string ImageId { get; set; }

    /// <summary>
    /// 檢核者帳號GID
    /// </summary>
    public Guid? VerifierGid { get; set; }

    /// <summary>
    /// 檢核時間
    /// </summary>
    public DateTime? VerifierTime { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 量測時間
    /// </summary>
    public DateTime UserMeasureTime { get; set; }

    /// <summary>
    /// 資料來源
    /// </summary>
    public VitalSignSource Source { get; set; }

    /// <summary>
    /// 審核狀態
    /// </summary>
    public VerifyStatus VerifyStatus { get; set; } = VerifyStatus.NotVerify;

    /// <summary>
    /// 檢驗試劑Id(KitCode)"
    /// </summary>
    [MaxLength(50)]
    public string RapidTestId { get; set; }

    /// <summary>
    /// 機構Id
    /// </summary>
    public int? OrgId { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    public virtual VitalSign VitalSign { get; set; }
    public virtual Account Verifier { get; set; }

    #endregion

    [NotMapped]
    public int[] ImgIdArray
    {
      get => string.IsNullOrEmpty(ImageId) ? null : JsonSerializer.Deserialize<int[]>(this.ImageId);
      set => ImageId = JsonSerializer.Serialize(value);
    }
  }
}
