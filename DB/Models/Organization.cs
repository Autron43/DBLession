
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DB.EnumFields;
using DB.Models;

namespace DB.Models
{

  public class Organization
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// ���c�W��
    /// </summary>
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    /// <summary>
    /// ���c�s��
    /// </summary>
    [MaxLength(50)]
    public string CompanyId { get; set; }

    /// <summary>
    /// ���c�N�X
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// ���c�s���q��
    /// </summary>
    [MaxLength(50)]
    public string Tel { get; set; }

    /// <summary>
    /// ���c�p����ʹq��
    /// </summary>
    [MaxLength(50)]
    public string Mobile { get; set; }

    /// <summary>
    /// ���c�a�}
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// ���c�t�d�H
    /// </summary>
    public string Owner { get; set; }

    /// <summary>
    /// ���c�q�l�H�c
    /// </summary>
    [MaxLength(50)]
    public string Email { get; set; }

    /// <summary>
    /// �x�����
    /// </summary>
    public string OfficialWebsite { get; set; }

    /// <summary>
    /// ���c����
    /// </summary>
    public string Introduction { get; set; }

    /// <summary>
    /// ���c�A�ȶ��ؼ��D
    /// </summary>
    public string ServiceTitle { get; set; }

    /// <summary>
    /// �إ߮ɶ�
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// ��s�ɶ�
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// ²�T������Id
    /// </summary>
    public int? SmsSupplierId { get; set; }

    #region ���p

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
  //class db
  //{
  //  Organization organization = new Organization();
  //  IEnumerable<Organization> query = from args in organization
  //                                    select Organization.Name;
  //}
}