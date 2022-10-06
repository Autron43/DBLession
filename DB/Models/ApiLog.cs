
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class ApiLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// http請求方法
    /// </summary>
    /// <remarks>
    /// </remarks>
    [MaxLength(6)]
    public string Method { get; set; }

    /// <summary>
    /// api網址
    /// </summary>
    [MaxLength(100)]
    public string Uri { get; set; }

    /// <summary>
    /// 請求資料
    /// </summary>
    public string Input { get; set; }

    /// <summary>
    /// 請求標頭
    /// </summary>
    public string Headers { get; set; }

    public Guid? AccountGid { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
  }
}
