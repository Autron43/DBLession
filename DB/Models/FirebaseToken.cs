
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class FirebaseToken
  {
    [Key]
    public int Id { get; set; }

    [Required]
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 裝置 token
    /// </summary>
    public string DeviceToken { get; set; }

    /// <summary>
    /// 裝置種類
    /// </summary>
    [Required]
    public string DeviceType { get; set; }

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

    /// <summary>
    /// 使用次數
    /// </summary>
    public int UsageCount { get; set; }
  }
}
