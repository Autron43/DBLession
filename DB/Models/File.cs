
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class File
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 來源資料 Id ( 或 Gid )
    /// </summary>
    public string OriginId { get; set; }

    /// <summary>
    /// 顯示名稱
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// 檔案名稱
    /// </summary>
    [Required]
    public string FileName { get; set; }

    /// <summary>
    /// 檔案路徑
    /// </summary>
    public string FileUrl { get; set; }

    /// <summary>
    /// 檔案大小（KB）
    /// </summary>
    public double Size { get; set; }

    /// <summary>
    /// 檔案用途
    /// </summary>
    [Required]
    public FileUsage Type { get; set; }

    /// <summary>
    /// 檔案空間來源
    /// </summary>
    [Required]
    public string Source { get; set; } = "localhost";

    /// <summary>
    /// 啟用狀態
    /// </summary>
    [Required]
    public bool Enabled { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 建立者Guid
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// 修改者Guid
    /// </summary>
    public Guid UpdatedBy { get; set; }

    /// <summary>
    /// 所屬機構Id
    /// </summary>
    public int OrganizationId { get; set; }

    /// <summary>
    /// 外部連結名稱
    /// </summary>
    [MaxLength(5)]
    public string ExternalLinkName { get; set; }

    /// <summary>
    /// 外部連結
    /// </summary>
    [DataType(DataType.Url)]
    public string ExternalLink { get; set; }

    /// <summary>
    /// 檔案公開設定
    /// </summary>
    [Required]
    public AccessType AccessType { get; set; } = AccessType.Private;

    /// <summary>
    /// 取得圖片HASH (SHA-1, HexDecimal)
    /// </summary>
    [MaxLength(40)]
    public string ImageHash { get; set; }

    /// <summary>
    /// 順序
    /// </summary>
    public int? Order { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    [Newtonsoft.Json.JsonIgnore]
    public virtual ICollection<OrganizationKioskVideo> OrganizationKioskVideos { get; set; }
    #endregion
  }
}