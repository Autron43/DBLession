
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace mPHR.Services.Database.Models
{

  public class Organization
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 機構名稱
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// 機構編號
    /// </summary>
    [MaxLength(50)]
    public string CompanyId { get; set; }

    /// <summary>
    /// 機構代碼
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 機構連絡電話
    /// </summary>
    [MaxLength(50)]
    public string Tel { get; set; }

    /// <summary>
    /// 機構聯絡行動電話
    /// </summary>
    [MaxLength(50)]
    public string Mobile { get; set; }

    /// <summary>
    /// 機構地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 機構負責人
    /// </summary>
    public string Owner { get; set; }

    /// <summary>
    /// 機構電子信箱
    /// </summary>
    [MaxLength(50)]
    public string Email { get; set; }

    /// <summary>
    /// 官方網站
    /// </summary>
    public string OfficialWebsite { get; set; }

    /// <summary>
    /// 機構介紹
    /// </summary>
    public string Introduction { get; set; }

    /// <summary>
    /// 機構服務項目標題
    /// </summary>
    public string ServiceTitle { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 簡訊供應商Id
    /// </summary>
    public int? SmsSupplierId { get; set; }

    #region 關聯

    public virtual OrganizeConfig OrganizeConfig { get; set; }

    public virtual SmsSupplier SmsSupplier { get; set; }

    public virtual ICollection<Account> Accounts { get; set; }

    public virtual ICollection<OrganizeAuthorization> OrganizeAuthorizations { get; set; }

    public virtual ICollection<QuestionnaireOrganize> QuestionnaireOrganizes { get; set; }

    public virtual ICollection<OrganizeGroup> OrganizeGroups { get; set; }

    public virtual ICollection<OrganizationMessage> OrganizationMessages { get; set; }

    public virtual ICollection<Machine> Machines { get; set; }

    public virtual ICollection<PatientGroup> PatientGroups { get; set; }

    public virtual ICollection<SmsPhrase> SmsPhrases { get; set; }

    public virtual ICollection<Label> Labels { get; set; }

    public virtual ICollection<Event> Events { get; set; }

    public virtual ICollection<Course> Courses { get; set; }

    public virtual ICollection<CourseCategory> CourseCategories { get; set; }

    public virtual ICollection<ProductSerial> ProductSerials { get; set; }

    public virtual ICollection<VideoConCall> VideoConCalls { get; set; }

    public virtual ICollection<Role> Roles { get; set; }

    #endregion

  }
}