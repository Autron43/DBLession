
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class LinePhrase
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 樣板標題
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 樣板內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
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

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int? OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    #endregion
  }
}
