
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class FormRecommend
  {
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// 推薦人GID
    /// </summary>
    public Guid RecommendGid { get; set; }

    /// <summary>
    /// 填寫人GID
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 推薦量表所屬機構ID
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 表單GID
    /// </summary>
    public Guid FormGid { get; set; }

    /// <summary>
    /// 表單填答 GID
    /// </summary>
    public int? FormResponseId { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    /// <summary>
    /// 推薦給用戶的時間
    /// </summary>
    public DateTime RecommendedAt { get; set; }

    /// <summary>
    /// 推薦量表群組 GID
    /// </summary>
    public Guid? FormGroupGid { get; set; }

    #region 關聯

    [Newtonsoft.Json.JsonIgnore]
    [ForeignKey("FormGid")]
    [NotMapped]
    public virtual Form Form { get; set; }

    [Newtonsoft.Json.JsonIgnore]
    [ForeignKey("FormResponseId")]
    [NotMapped]
    public virtual Result FormResponese { get; set; }

    [Newtonsoft.Json.JsonIgnore]
    [ForeignKey("FormGroupGid")]
    public virtual FormRecommendGroup FromRecommendGroup { get; set; }

    #endregion
  }
}
