
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class Role
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 角色名稱
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string Name { get; set; }

    /// <summary>
    /// 角色種類
    /// </summary>
    public RoleType RoleType { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int? OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    public virtual ICollection<AccountRole> AccountRoles { get; set; }

    public virtual ICollection<RolePermission> RolePermissions { get; set; }

    #endregion
  }
}