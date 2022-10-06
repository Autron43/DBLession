
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mPHR.Services.Database.Models
{
  public class AccountDiseaseIdentifiedAtLog
  {
    [Key]
    public int Id { get; set; }

    public Guid AccountGid { get; set; }

    //public enum DiseaseType { get;set; } 

    /// <summary>
    /// 疾病開案日/確診日
    /// </summary>
    public DateTime IdentifiedAt { get; set; }

    /// <summary>
    /// 開案機構
    /// </summary>
    public int OrgId { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 修改日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    #endregion
  }
}
