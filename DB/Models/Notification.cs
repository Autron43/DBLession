
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class Notification
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 接受者Gid
    /// </summary>
    [Required]
    public Guid ReceiverGid { get; set; }

    /// <summary>
    /// Token種類
    /// </summary>
    [Required]
    public NotifyTokenType TokenType { get; set; }

    /// <summary>
    /// Token
    /// </summary>
    [Required]
    public string Token { get; set; }

    /// <summary>
    /// 內容種類 
    /// </summary>
    public NotifyContentType ContentType { get; set; }

    /// <summary>
    /// 內容Id 
    /// </summary>
    public string ContentId { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 預計推播時間
    /// </summary>
    /// <remarks>
    /// 須建立非叢集索引
    /// </remarks>
    public DateTime ExpectedTime { get; set; }

    /// <summary>
    /// 實際推播成功時間
    /// </summary>
    public DateTime? PushTime { get; set; }

    /// <summary>
    /// 推播失敗錯誤訊息
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

  }
}