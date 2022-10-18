
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{

  public class AccountInformation
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 個人圖像
    /// </summary>
    public byte[] Avatar { get; set; }

    /// <summary>
    /// 電子信箱
    /// </summary>
    [MaxLength(100)]
    public string Email { get; set; }

    /// <summary>
    /// 姓別
    /// </summary>
    public AccountGender Gender { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    [Column(TypeName = "Date")]
    public DateTime? Birthday { get; set; }

    /// <summary>
    /// 血型
    /// </summary>
    public AccountBlood Blood { get; set; }

    /// <summary>
    /// 特殊血型(血型：其他)
    /// </summary>
    public string ParticularBloodType { get; set; }

    /// <summary>
    /// 感應卡號碼 : 感應卡登入
    /// </summary>
    [MaxLength(20)]
    public string CardNo { get; set; }

    /// <summary>
    /// 身份證 : 健保卡登入
    /// </summary>
    [MaxLength(20)]
    public string IdentityNo { get; set; }

    /// <summary>
    /// 手機
    /// </summary>
    [MaxLength(50)]
    public string Mobile { get; set; }

    /// <summary>
    /// 市話
    /// </summary>
    [MaxLength(50)]
    public string Tel { get; set; }

    /// <summary>
    /// 使用者註冊來源
    /// </summary>
    public RegisterSource RegisterSource { get; set; }

    /// <summary>
    /// 使用者註冊機台
    /// </summary>
    public string RegisterFrom { get; set; }

    /// <summary>
    /// 地址
    /// </summary>
    [MaxLength(100)]
    public string Address { get; set; }

    /// <summary>
    /// 郵遞區號
    /// </summary>
    [MaxLength(10)]
    public string ZipCode { get; set; }

    /// <summary>
    /// 市
    /// </summary>
    [MaxLength(50)]
    public string County { get; set; }

    /// <summary>
    /// 區
    /// </summary>
    [MaxLength(50)]
    public string District { get; set; }

    /// <summary>
    /// 使用語系
    /// </summary>
    [MaxLength(20)]
    public string Language { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    public DateTime? CovidIdentifiedAt { get; set; }

    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 法傳編號
    /// </summary>
    public string NidrsCode { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion


    [NotMapped]
    public int Age
    {
      get
      {
        return this.Birthday.HasValue ? Convert.ToInt32((DateTime.Today - this.Birthday.Value).TotalDays / 365.25) : 0;
      }
    }
  }
}