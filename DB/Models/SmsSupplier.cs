
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{

  public class SmsSupplier
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 簡訊商名稱
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }

    /// <summary>
    /// 簡訊商帳號
    /// </summary>
    [MaxLength(30)]
    public string Account { get; set; }

    /// <summary>
    /// 簡訊商密碼
    /// </summary>
    [MaxLength(30)]
    public string Password { get; set; }

    /// <summary>
    /// 寄送簡訊API
    /// </summary>
    [Url]
    [MaxLength(100)]
    public string SendUrl { get; set; }

    /// <summary>
    /// 查詢簡訊剩餘點數API
    /// </summary>
    [Url]
    [MaxLength(100)]
    public string CostUrl { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    public virtual ICollection<Organization> Organizations { get; set; }

    public virtual ICollection<SmsParameter> SmsParameters { get; set; }
    #endregion
  }
}