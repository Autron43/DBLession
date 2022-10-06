using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class CommentRead
  {
    [Key]
    public Guid gid { get; set; }
    /// <summary>
    /// 來源文章編號
    /// </summary>
    [Required]
    public string OriginGid { get; set; }
    /// <summary>
    /// 留言板參與人
    /// </summary>
    public Guid AccountGid { get; set; }
    /// <summary>
    /// 最後進入留言板的時間
    /// </summary>
    public DateTime? LastReadTime { get; set; }
    /// <summary>
    /// 來源文章類型
    /// </summary>
    public CommentOriginType OriginType { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
  }
}
