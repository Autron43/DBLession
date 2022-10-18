
using DB.EnumFields;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace DB.Models
{
  public class ShopProduct
  {
    /// <summary>
    /// 商品ID (原: ItemGid)
    /// </summary>
    [Key]
    public Guid ProductGid { get; set; }

    /// <summary>
    /// 商品名稱
    /// </summary>
    [MaxLength(100)]
    public string ProductName { get; set; }
    /// <summary>
    /// 商品圖片
    /// </summary>
    public string ImageUrl { get; set; }
    /// <summary>
    /// 開始兌換時間
    /// </summary>
    public DateTime StartTime { get; set; }
    /// <summary>
    /// 結束兌換時間
    /// </summary>
    public DateTime? EndTime { get; set; }
    /// <summary>
    /// 價格
    /// </summary>
    public int Price { get; set; }
    /// <summary>
    /// 使用代幣種類
    /// </summary>
    public ShopTokenType TokenType { get; set; }
    /// <summary>
    /// 商品描述
    /// </summary>
    public string Desc { get; set; }
    /// <summary>
    /// 商品上架狀態
    /// </summary>
    public ShopProductStatus Status { get; set; }
    /// <summary>
    /// 最大兌換數量
    /// </summary>
    public int ExchangeMaxCount { get; set; }
    /// <summary>
    /// 最大庫存量
    /// </summary>
    public int StockMaxCount { get; set; }
    /// <summary>
    /// 已下單數量
    /// </summary>
    public int OrderCount { get; set; }
    /// <summary>
    /// 已核銷數量
    /// </summary>
    public int WriteOffCount { get; set; }
    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }
    /// <summary>
    /// 更新日期
    /// </summary>
    public DateTime UpdatedAt { get; set; }
    /// <summary>
    /// 建立使用者GID
    /// </summary>
    public Guid CreatedBy { get; set; }
    /// <summary>
    /// 修改使用者GID
    /// </summary>
    public Guid UpdatedBy { get; set; }
    /// <summary>
    /// 組織GID
    /// </summary>
    public Guid CampaignGid { get; set; }
    /// <summary>
    /// 商品分類
    /// </summary>
    public int ProductCategoryId { get; set; } = 1;
    /// <summary>
    /// 機構id
    /// </summary>
    public int? OrgId { get; set; }
    /// <summary>
    /// 自訂商品編號
    /// </summary>
    public string CustomNo { get; set; }
    /// <summary>
    /// 開啟現金兌換(20201026:暫不開放)
    /// </summary>
    public bool CashExchange { get; set; } = false;
    /// <summary>
    /// 運送方式
    /// </summary>
    public string ShipmentMethods { get; set; }
    /// <summary>
    /// 運送方式說明
    /// </summary>
    public string ShipmentDesc { get; set; }
    /// <summary>
    /// 優先顯示
    /// </summary>
    public bool Featured { get; set; }

    [NotMapped]
    public ShopProductShipment[] Shipments
    {
      get { return (string.IsNullOrEmpty(ShipmentMethods)) ? null : JsonSerializer.Deserialize<ShopProductShipment[]>(ShipmentMethods); }
      set { ShipmentMethods = JsonSerializer.Serialize(value); }
    }

    public virtual ICollection<ShopPurchaseLog> ShopPurchaseLog { get; set; }
  }
}
