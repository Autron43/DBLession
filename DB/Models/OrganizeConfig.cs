
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
    /// 是否為企業機構
    /// </summary>
    public bool Emp { get; set; } = false;

    /// <summary>
    /// 首頁顯示Logo類型
    /// </summary>
    public LogoType LogoType { get; set; }

    /// <summary>
    /// 是否開啟首頁享健康Logo
    /// </summary>
    public bool MphrLogo { get; set; } = true;

    /// <summary>
    /// 是否開啟客製化導覽列品牌LOGO
    /// </summary>
    public bool MphrNavBrand { get; set; } = false;

    /// <summary>
    /// 首頁顯示文字內容
    /// </summary>
    public string LogoText { get; set; }

    /// <summary>
    /// 預設角色權限
    /// </summary>
    public int? DefaultRoleId { get; set; }

    /// <summary>
    /// 背景圖副檔名
    /// </summary>
    [MaxLength(20)]
    public string ExtensionName { get; set; }

    /// <summary>
    /// 背景圖新檔名
    /// </summary>
    public Guid? PageIdentity { get; set; }

    /// <summary>
    /// 防疫大師機構token
    /// </summary>
    public string FastGoOrgToken { get; set; }

    /// <summary>
    /// 簡訊點數
    /// </summary>
    public int SmsPoint { get; set; }

    public UserAgreementType UserAgreementType { get; set; }

    /// <summary>
    /// APP 主題風格名稱
    /// </summary>
    public string AppThemeName { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    #endregion
  }
}