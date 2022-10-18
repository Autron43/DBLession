
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class AccountNotificationLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 用戶Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 已讀/未讀
    /// </summary>
    public bool Read { get; set; } = false;

    /// <summary>
    /// 事件種類
    /// </summary>
    public EventContentType ContentType { get; set; }

    /// <summary>
    /// 事件ID
    /// </summary>
    public string ContentId { get; set; }

    /// <summary>
    /// 事件內容網址
    /// </summary>
    public string ContentUrl { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}
