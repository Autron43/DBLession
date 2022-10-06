
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{
  public class OrganizationLineSetting
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 機構ID
    /// </summary>
    public int OrganizationId { get; set; }
    /// <summary>
    /// line webhook用機構代碼(與機構資訊頁的代碼不同，不可修改)
    /// </summary>
    [MaxLength(50)]
    public string LineOrgCode { get; set; }
    /// <summary>
    /// line@頻道帳號(等於developer console內的bot basic id)
    /// </summary>
    public string ChannelId { get; set; }
    /// <summary>
    /// 機構LINE@ token
    /// </summary>
    public string ChannelAccessToken { get; set; }
    /// <summary>
    /// 預設回應訊息
    /// </summary>
    public string DefaultMessage { get; set; }
    /// <summary>
    /// 加入好友後歡迎訊息
    /// </summary>
    public string BefriendWelcomeMessage { get; set; }
    /// <summary>
    /// Line通知傳送
    /// </summary>
    public OrganizationLineNotifyType NotifyType { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
  }
}
