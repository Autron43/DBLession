
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class OrganizationMessage
  {
    [Key]
    public Guid Id { get; set; }
    /// <summary>
    /// 標題
    /// </summary>
    [MaxLength(100)]
    public string Title { get; set; }

    /// <summary>
    /// 發表時間
    /// </summary>
    public DateTime? PostDate { get; set; }

    /// <summary>
    /// 內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 發布機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 最後修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 建立使用者GID
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改使用者GID
    /// </summary>
    public Guid UpdatedBy { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    [ForeignKey("CreatedBy")]
    public virtual Account CreatorAccount { get; set; }

    #endregion
  }
}
