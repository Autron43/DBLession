
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class PatientGroup
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 共照群組名稱
    /// </summary>
    [MaxLength(50)]
    public string Name { get; set; }

    /// <summary>
    /// 共照群組狀態
    /// </summary>
    public PatientGroupStatus Status { get; set; }

    /// <summary>
    /// 是否為全機構成員
    /// </summary>
    public bool WholeAccount { get; set; } = false;

    /// <summary>
    /// 群組公告訊息
    /// </summary>
    public string Bulletin { get; set; }

    /// <summary>
    /// 用戶自訂類別說明
    /// </summary>
    public string CategoryText { get; set; }

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
    /// 所屬機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    public virtual ICollection<PatientGroupDetail> PatientGroupDetails { get; set; }

    public virtual ICollection<PatientGroupOwner> PatientGroupOwners { get; set; }

    public virtual ICollection<PatientGroupScript> PatientGroupScripts { get; set; }

    #endregion
  }
}