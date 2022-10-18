
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class AccountKpiMachine
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 機台Id
    /// </summary>
    public int MachineId { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    #endregion
  }
}