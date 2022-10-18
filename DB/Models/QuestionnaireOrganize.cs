using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class QuestionnaireOrganize
  {
    private Form form;

    /// <summary>
    /// 量表Guid
    /// </summary>
    [Key]
    public Guid FormGuid { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 機構Id
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 可見量表的角色
    /// </summary>
    public RoleAuthType RoleAuthType { get; set; } = RoleAuthType.Member;

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    [ForeignKey("FormGuid")]
    public virtual Form Form { get => form; set => form = value; }

    #endregion

  }

}