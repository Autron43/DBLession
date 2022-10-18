
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class LabelAccount
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 標籤Id
    /// </summary>
    public int LabelId { get; set; }

    /// <summary>
    /// 帳號Guid
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
    /// 建立者Guid
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    #region 關聯

    [ForeignKey("LabelId")]
    public virtual Label Label { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}