
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class OrganizeConfig
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// �O�_�����~���c
    /// </summary>
    public bool Emp { get; set; } = false;

    /// <summary>
    /// �������Logo����
    /// </summary>
    public LogoType LogoType { get; set; }

    /// <summary>
    /// �O�_�}�ҭ����ɰ��dLogo
    /// </summary>
    public bool MphrLogo { get; set; } = true;

    /// <summary>
    /// �O�_�}�ҫȻs�ƾ����C�~�PLOGO
    /// </summary>
    public bool MphrNavBrand { get; set; } = false;

    /// <summary>
    /// ������ܤ�r���e
    /// </summary>
    public string LogoText { get; set; }

    /// <summary>
    /// �w�]�����v��
    /// </summary>
    public int? DefaultRoleId { get; set; }

    /// <summary>
    /// �I���ϰ��ɦW
    /// </summary>
    [MaxLength(20)]
    public string ExtensionName { get; set; }

    /// <summary>
    /// �I���Ϸs�ɦW
    /// </summary>
    public Guid? PageIdentity { get; set; }

    /// <summary>
    /// ���̤j�v���ctoken
    /// </summary>
    public string FastGoOrgToken { get; set; }

    /// <summary>
    /// ²�T�I��
    /// </summary>
    public int SmsPoint { get; set; }

    public UserAgreementType UserAgreementType { get; set; }

    /// <summary>
    /// APP �D�D����W��
    /// </summary>
    public string AppThemeName { get; set; }

    /// <summary>
    /// �إ߮ɶ�
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// ��s�ɶ�
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// ���ݾ��cId
    /// </summary>
    public int OrganizationId { get; set; }

    #region ���p

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    #endregion
  }
}