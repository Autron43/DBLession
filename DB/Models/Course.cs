
using mPHR.Services.Database.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace mPHR.Services.Database.Models
{
  public class Course
  {
    [Key]
    [Column("Gid")]
    public Guid CourseGid { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Title { get; set; }

    /// <summary>
    /// 說明
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 類別
    /// </summary>
    [Required]
    public int Category { get; set; }

    /// <summary>
    /// 內文
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// 連結
    /// </summary>
    [Url]
    public string Link { get; set; }

    /// <summary>
    /// 衛教課程類別(文章 or 外部連結)
    /// </summary>
    [Required]
    public CourseContentMode Mode { get; set; }

    public string Tags { get; set; }

    /// <summary>
    /// 組織ID
    /// </summary>
    [Required]
    public int OrganizationId { get; set; }

    /// <summary>
    /// 建立使用者GID
    /// </summary>
    public Guid CreatedBy { get; set; }

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

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    [ForeignKey("CreatedBy")]
    public virtual Account CreatorAccount { get; set; }

    public virtual ICollection<CourseRecommend> CourseRecommends { get; set; }

    #endregion

    [NotMapped]
    public List<int> TagIds
    {
      get { return Tags.Replace("#", "").TrimEnd(',').Split(',').Select(int.Parse).ToList(); }
      set { Tags = string.Concat(value.Select(x => "#" + x.ToString() + ",").ToArray()); }
    }
  }
}
