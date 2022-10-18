
using DB.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class PatientGroupScript
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 腳本Id
    /// </summary>
    public int ScriptId { get; set; }

    /// <summary>
    /// 所屬群組Id
    /// </summary>
    public int PatientGroupId { get; set; }

    /// <summary>
    /// 套用對象
    /// </summary>
    public ScriptTargetType ApplyTarget { get; set; }

    /// <summary>
    /// 套用至新進成員
    /// </summary>
    public bool ApplyToNewMember { get; set; } = true;

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


    #region 關聯

    [ForeignKey(nameof(PatientGroupId))]
    public virtual PatientGroup PatientGroup { get; set; }

    [ForeignKey(nameof(ScriptId))]
    public virtual Script Script { get; set; }

    public virtual ICollection<ScriptAccount> ScriptAccounts { get; set; }
    #endregion
  }

}