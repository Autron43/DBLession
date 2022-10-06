
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class ProductSerial
  {
    [Key]
    [Display(Name = "產品序號")]
    public string SerialNo { get; set; }

    /// <summary>
    /// 註冊時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime? RegTime { get; set; }

    /// <summary>
    /// 起始時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 截止時間
    /// </summary>
    [Display(Name = "有效期限")]
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 設備Id
    /// </summary>
    public int? MachineId { get; set; }

    #region 關聯

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    #endregion
  }
}
