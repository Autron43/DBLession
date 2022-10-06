
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  // 原 HealthCall
  public class CaseManagemenetCall
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 帳號GID
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 標題
    /// </summary>
    public string Title { get; set; }

    /// <summary>
    /// 訊息內容
    /// </summary>
    public string Content { get; set; }

    public string FirebaseId { get; set; }

    /// <summary>
    /// 電訪推播所屬機構ID
    /// </summary>
    public int? OrganizationId { get; set; }

    /// <summary>
    /// 紀錄種類
    /// </summary>
    public int HealthCallType { get; set; }

    /// <summary>
    /// 建立者GID
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// 編輯者 (舊資料庫內有這個欄位，後來改成存入編輯者的guid；因為早期資料只有存文字，若省略此欄位會看不到當時的編輯者，未來不會在此欄位新增資料)
    /// </summary>
    public string ModUser { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("CreatedBy")]
    public virtual Account CreatorAccount { get; set; }

    #endregion
  }
}
