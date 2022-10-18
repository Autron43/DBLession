
using DB.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;

namespace DB.Models
{
  public class ShopToken
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 機構ID
    /// </summary>
    public int OrgId { get; set; }

    /// <summary>
    /// 使用者Gid
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 金額
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// 使用者目前餘額
    /// </summary>
    public int Balance { get; set; }

    /// <summary>
    /// 代幣種類
    /// </summary>
    public ShopTokenType TokenType { get; set; }

    /// <summary>
    /// 交易原因
    /// </summary>
    public ShopTokenReason ReasonType { get; set; } = ShopTokenReason.Unknown;

    /// <summary>
    /// 交易動作(存入/提出)
    /// </summary>
    public ShopTransactionType TransactionType { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string Remarks { get; set; }

    /// <summary>
    /// 操作人員
    /// </summary>
    public Guid? CreatedBy { get; set; }

    /// <summary>
    /// 建立時間
    /// </summary>
    public DateTime CreatedAt { get; set; }


  }
}
