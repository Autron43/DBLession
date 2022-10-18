
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class ShopProductCategory
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 機構id null的為預設分類
    /// </summary>
    public int? OrgId { get; set; }
    /// <summary>
    /// 分類名稱
    /// </summary>
    public string CategoryName { get; set; }
    /// <summary>
    /// 建立者
    /// </summary>
    public Guid CreatedBy { get; set; }
    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// 更新日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }
  }
}
