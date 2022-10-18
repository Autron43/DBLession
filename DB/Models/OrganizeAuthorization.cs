
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class OrganizeAuthorization
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    /// <summary>
    /// 使用者Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 移除授權日期
    /// </summary>
    public DateTime? RemovedAt { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}