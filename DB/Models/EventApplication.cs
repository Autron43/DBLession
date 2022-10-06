
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class EventApplication
  {
    /// <summary>
    /// 報名Id
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 報名狀態
    /// </summary>
    public EventApplyStatus Status { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remark { get; set; }

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

    /// <summary>
    /// 報名人員Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 活動Id
    /// </summary>
    public int EventId { get; set; }

    #region 關聯

    [ForeignKey("EventId")]
    public virtual Event Event { get; set; }

    [ForeignKey("AccountGid")]
    public Account Account { get; set; }

    #endregion
  }
}