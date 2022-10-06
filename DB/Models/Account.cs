
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class Account
  {
    /// <summary>
    /// 使用者Guid
    /// </summary>
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// 帳號
    /// </summary>
    [MaxLength(50)]
    public string LoginName { get; set; }

    /// <summary>
    /// 密碼
    /// </summary>
    [MaxLength(200)]
    public string HashedPassword { get; set; }

    /// <summary>
    /// 姓名
    /// </summary>
    [MaxLength(50)]
    public string UserName { get; set; }

    /// <summary>
    /// 帳號狀態
    /// </summary>
    public AccountStatus Status { get; set; }

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

    public virtual AccountInformation AccountInformation { get; set; }

    public virtual AccountConfig AccountConfig { get; set; }

    public virtual AccountNotificationSetting AccountNotificationSetting { get; set; }

    public virtual ICollection<AccountCertificate> AccountCertificates { get; set; }

    public virtual ICollection<AccountRole> AccountRoles { get; set; }

    public virtual ICollection<EightDimensionReport> EightDimensionReports { get; set; }

    public virtual ICollection<OrganizeAuthorization> OrganizeAuthorizations { get; set; }

    public virtual ICollection<AccountUserAgreement> SignedAgreements { get; set; }

    public virtual ICollection<LabelAccount> LabelAccounts { get; set; }

    public virtual ICollection<VitalSign> VitalSigns { get; set; }

    public virtual ICollection<PatientGroupDetail> PatientGroupDetails { get; set; }

    public virtual ICollection<AccountDiseaseIdentifiedAtLog> AccountDiseaseIdentifiedAtLogs { get; set; }

    public virtual VitalSignLatest VitalSignLatest { get; set; }

    public virtual NidrsChangeRecord NidrsChangeRecord { get; set; }
    #endregion
  }
}
