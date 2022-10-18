
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class Comment
  {
    [Key]
    [Column("Gid")]
    public Guid CommentGid { get; set; }
    /// <summary>
    /// 來源文章編號
    /// </summary>
    public string OriginGid { get; set; }
    /// <summary>
    /// 來源文章類型
    /// </summary>
    public CommentOriginType OriginType { get; set; }
    /// <summary>
    /// 主留言編號(若與CommentGid相同，則此留言為主留言)
    /// </summary>
    public Guid? MainCommentGid { get; set; }
    /// <summary>
    /// 是否為悄悄話
    /// </summary>
    public bool IsSecret { get; set; }
    /// <summary>
    /// 是否匿名
    /// </summary>
    public bool IsAnonymous { get; set; }
    /// <summary>
    /// 留言人
    /// </summary>
    public Guid CreatedBy { get; set; }
    /// <summary>
    /// 留言內容
    /// </summary>
    public string ContentText { get; set; }
    /// <summary>
    /// 建立時間
    /// </summary>
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }

    #region 關聯
    [ForeignKey("CreatedBy")]
    public virtual Account Account { get; set; }
    #endregion
  }
}