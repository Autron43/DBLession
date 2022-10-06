
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class VideoConCall
  {
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// OpenTok ApiKey
    /// </summary>
    public string ApiKey { get; set; }

    /// <summary>
    /// OpenTok SessionId
    /// </summary>
    public string SessionId { get; set; }

    /// <summary>
    /// OpenTok Token
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// 機構編號
    /// </summary>
    public int OrgId { get; set; }

    /// <summary>
    /// 房間名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 建立者GID
    /// </summary>
    public Guid CreatedAccountGid { get; set; }

    /// <summary>
    /// 被邀請者GID
    /// </summary>
    public Guid? InviteAccountGid { get; set; }

    /// <summary>
    /// 到期時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime ExpireTime { get; set; }

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


    [ForeignKey("OrgId")]
    public Organization Organization { get; set; }

    [ForeignKey("CreatedAccountGid")]
    public Account Account { get; set; }
  }
}
