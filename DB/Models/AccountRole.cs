
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class AccountRole
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 角色Id
    /// </summary>
    public int RoleId { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("RoleId")]
    public virtual Role Role { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}