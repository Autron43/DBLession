using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class FormRecommendGroup
  {
    [Key]
    public Guid Gid { get; set; }

    /// <summary>
    /// 被推薦人 GID
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Description { get; set; }

    #region 關聯欄位
    [Newtonsoft.Json.JsonIgnore]
    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }
    #endregion
  }
}
