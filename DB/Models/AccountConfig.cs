
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{

  public class AccountConfig
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 是否自動授權
    /// </summary>
    public bool IsAutoAuthed { get; set; } = true;

    /// <summary>
    /// 資料加密用的PublicKey
    /// </summary>
    [MaxLength]
    public string PublicKey { get; set; }

    /// <summary>
    /// 特殊機構跨站登入Token
    /// </summary>
    [MaxLength]
    public string OrgToken { get; set; }

    /// <summary>
    /// Line的UserId
    /// </summary>
    [MaxLength(50)]
    public string LineUserId { get; set; }

    /// <summary>
    /// APPLE的UserId
    /// </summary>
    [MaxLength(50)]
    public string AppleUserId { get; set; }

    /// <summary>
    /// Line推播使用的Token
    /// </summary>
    [MaxLength(50)]
    public string LineNotifyToken { get; set; }

    /// <summary>
    /// 職工編號
    /// </summary>
    public string EmployeeId { get; set; }

    /// <summary>
    /// 企業代碼
    /// </summary>
    public string EmpCode { get; set; }

    /// <summary>
    /// 是否接收量測簡訊
    /// </summary>
    public bool? ReceiveSms { get; set; }

    /// <summary>
    /// 簡訊接收電話
    /// </summary>
    [MaxLength(20)]
    public string SmsPhone { get; set; }

    /// <summary>
    /// 是否接收使用量電子報
    /// </summary>
    public bool ReceiveUsageMail { get; set; } = true;

    /// <summary>
    /// 是否接收量測推播
    /// </summary>
    public bool ReceivePush { get; set; } = true;

    /// <summary>
    /// FaceBook訪問Token
    /// </summary>
    [MaxLength(300)]
    public string FaceBookAccessToken { get; set; }

    /// <summary>
    /// FaceBook使用者Id
    /// </summary>
    [MaxLength(50)]
    public string FaceBookUserId { get; set; }

    /// <summary>
    /// FaceBook訪問Token過期時間
    /// </summary>
    public DateTime? FaceBookExpiryAt { get; set; }

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

    /// <summary>
    /// 智慧時尚 金平安手環號碼
    /// </summary>
    public string DplusDeviceNo { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}