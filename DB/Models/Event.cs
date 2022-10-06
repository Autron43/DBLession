
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class Event
  {
    /// <summary>
    /// 活動Id
    /// </summary>
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 活動名稱
    /// </summary>
    public string EventName { get; set; }

    /// <summary>
    /// 是否需要報名
    /// </summary>
    public bool Application { get; set; }

    /// <summary>
    /// 報名開始時間
    /// </summary>
    public DateTime ApplyStartTime { get; set; }

    /// <summary>
    /// 報名截止時間
    /// </summary>
    public DateTime ApplyEndTime { get; set; }

    /// <summary>
    /// 報名人數上限
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// 活動開始時間
    /// </summary>
    public DateTime StartTime { get; set; }

    /// <summary>
    /// 活動結束時間
    /// </summary>
    public DateTime EndTime { get; set; }

    /// <summary>
    /// 地點
    /// </summary>
    public string Location { get; set; }
    /// <summary>
    /// 報名費用
    /// </summary>
    public decimal? Price { get; set; }

    /// <summary>
    /// 活動狀態
    /// </summary>
    public EventStatus Status { get; set; }

    /// <summary>
    /// 活動內容
    /// </summary>
    public string Content { get; set; }

    /// <summary>
    /// 封面圖片 Url
    /// </summary>
    public string CoverUrl { get; set; }

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
    /// 所屬機構
    /// </summary>
    public int OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    public virtual ICollection<EventApplication> EventApplications { get; set; }

    #endregion
  }
}