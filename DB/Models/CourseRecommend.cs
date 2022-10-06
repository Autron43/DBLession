

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class CourseRecommend
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 推薦者GID
    /// </summary>
    [Required]
    public Guid RecommendGid { get; set; }

    /// <summary>
    /// 被推薦使用者GID
    /// </summary>
    [Required]
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 衛教資訊GID
    /// </summary>
    [Required]
    public Guid CourseGid { get; set; }

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

    #region 關聯

    [ForeignKey("RecommendGid")]
    public virtual Account Recommend { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    [ForeignKey("CourseGid")]
    public virtual Course Course { get; set; }

    #endregion

    /// <summary>
    /// Line推播連結
    /// </summary>
    [NotMapped]
    public string Url { get; set; }
  }
}
