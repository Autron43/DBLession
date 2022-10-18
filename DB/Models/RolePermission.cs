
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class RolePermission
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 權限名稱
    /// </summary>
    [Required]
    public string KeyName { get; set; }

    /// <summary>
    /// 讀取
    /// </summary>
    public bool Read { get; set; }

    /// <summary>
    /// 建立
    /// </summary>
    public bool Create { get; set; }

    /// <summary>
    /// 修改
    /// </summary>
    public bool Update { get; set; }

    /// <summary>
    /// 刪除
    /// </summary>
    public bool Delete { get; set; }

    /// <summary>
    /// 列印
    /// </summary>
    public bool Print { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 角色Id
    /// </summary>
    public int RoleId { get; set; }

    #region 關聯

    [ForeignKey("RoleId")]
    public virtual Role Role { get; set; }

    #endregion
  }
}