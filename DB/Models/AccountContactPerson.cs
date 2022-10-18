
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class AccountContactPerson
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 用戶Gid
    /// </summary>
    public Guid AccountGid { get; set; }
    /// <summary>
    /// 聯絡人Gid (會一同收到用戶的訊息)
    /// </summary>
    public Guid ContactPersonGid { get; set; }
    /// <summary>
    /// 是否接受推播通知
    /// </summary>
    public bool ReceivePushNotification { get; set; }
    /// <summary>
    /// 是否接受電子報寄送
    /// </summary>
    public bool ReceiveEmailReport { get; set; }
    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }
  }
}
