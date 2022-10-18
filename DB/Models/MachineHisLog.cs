
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class MachineHisLog
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 上傳內容
    /// </summary>
    public string UploadContent { get; set; }

    /// <summary>
    /// 錯誤訊息
    /// </summary>
    public string ErrorMessage { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    public int MachineId { get; set; }

    [ForeignKey("MachineId")]
    public virtual Machine Machine { get; set; }

    #endregion
  }
}
