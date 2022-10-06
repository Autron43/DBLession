
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mPHR.Services.Database.Models
{
  public class LabelOperationLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 被標籤人
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 標籤Id
    /// </summary>
    public int LabelId { get; set; }

    /// <summary>
    /// 操作類別
    /// </summary>
    public LabelOperationType OperationType { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("LabelId")]
    public virtual Label Label { get; set; }

    #endregion
  }

  public enum LabelOperationType
  {
    Unknown = 0,
    Create = 1,
    Remove = 2
  }
}
