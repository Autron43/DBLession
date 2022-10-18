
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class AccountCertificate
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 驗證類型
    /// </summary>
    public AccountCertificateType CertiType { get; set; }

    /// <summary>
    /// 已驗證的內容(信箱地址、手機號碼)
    /// </summary>
    [MaxLength(100)]
    public string CertificatedContent { get; set; }

    /// <summary>
    /// 驗證內容(信箱地址、手機號碼)
    /// </summary>
    [MaxLength(100)]
    public string CertificateContent { get; set; }

    /// <summary>
    /// 驗證碼(GUID或6碼數字)
    /// </summary>
    public string Code { get; set; }

    /// <summary>
    /// 驗證過期時間
    /// </summary>
    public DateTime ExpiryAt { get; set; }

    /// <summary>
    /// 驗證時間
    /// </summary>
    public DateTime? CertificateAt { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}