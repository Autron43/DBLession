
using DB.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  /// <summary>
  /// 舊: ShopItemLog 購買紀錄
  /// </summary>
  public class ShopPurchaseLog
  {
    [Key]
    public int Id { get; set; }

    public Guid ProductGid { get; set; }
    /// <summary>
    /// 兌換者GID
    /// </summary>
    public Guid AccountGid { get; set; }
    /// <summary>
    /// 代幣明細ID
    /// </summary>
    public int TokenId { get; set; }
    /// <summary>
    /// 兌換數量
    /// </summary>
    public int ExchangeCount { get; set; }
    /// <summary>
    /// 說明
    /// </summary>
    public string Desc { get; set; }
    /// <summary>
    /// "全部"點數數量
    /// </summary>
    public int Point { get; set; }
    /// <summary>
    /// "全部"付現金額
    /// </summary>
    public int Cash { get; set; }
    /// <summary>
    /// 付現是否完成
    /// </summary>
    public bool CashPaid { get; set; } = false;
    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// 紀錄建立人
    /// </summary>
    public Guid CreatedBy { get; set; }
    /// <summary>
    /// 更新時間
    /// </summary>
    public DateTime UpdatedAt { get; set; }
    /// <summary>
    /// 紀錄更新人
    /// </summary>
    public Guid UpdateBy { get; set; }
    /// <summary>
    /// 機構id
    /// </summary>
    public int? OrgId { get; set; }
    /// <summary>
    /// 訂單狀態類別
    /// </summary>
    public ShopPurchaseLogType Type { get; set; }

    #region 關聯

    [ForeignKey("ProductGid")]
    public virtual ShopProduct ShopProduct { get; set; }
    [ForeignKey("AccountGid")]
    public virtual Account Account { get; set; }

    public virtual ICollection<ShopReceiverInfo> ReceiverInfos { get; set; }

    #endregion
  }
}
