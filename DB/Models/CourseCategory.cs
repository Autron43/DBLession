
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class CourseCategory
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 名稱
    /// </summary>
    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    /// <summary>
    /// 說明
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// 組織ID
    /// </summary>
    [Required]
    public int OrganizationId { get; set; }

    /// <summary>
    /// 建立使用者GID
    /// </summary>
    public Guid? AccountGid { get; set; }

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

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }
  }
}
