
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class AccessLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 建立使用者GID
    /// </summary>
    /// <remarks>**索引</remarks>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 裝置
    /// </summary>
    public string Device { get; set; }

    /// <summary>
    /// 登入介面
    /// </summary>
    public LoginType? LoginType { get; set; }

    /// <summary>
    /// 路徑
    /// </summary>
    public string Uri { get; set; }

    /// <summary>
    /// 行為
    /// </summary>
    public string Action { get; set; }

    /// <summary>
    /// IP
    /// </summary>
    public string Ip { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    /// <remarks>**索引</remarks>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }
  }
}
