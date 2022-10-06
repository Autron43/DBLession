
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public  class NidrsChangeRecord
  {
    [Key]
    public int Id { get; set; }
    /// <summary>
    /// 姓名
    /// </summary>
    [MaxLength(50)]
    public string UserName { get; set; }
    /// <summary>
    /// 姓別
    /// </summary>
    public AccountGender Gender { get; set; }

    /// <summary>
    /// 生日
    /// </summary>
    public string Birthday { get; set; }

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
    /// 地址
    /// </summary>
    [MaxLength(100)]
    public string Address { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯
    /// <summary>
    /// 帳號Guid
    /// </summary>
    public Guid? AccountGid { get; set; }

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
    #endregion
  }
}
