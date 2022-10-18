
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class CourseTag
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 標籤名稱
    /// </summary>
    public string TagName { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime CreatedAt { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
    public DateTime UpdatedAt { get; set; }
  }
}
