using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ShopProduct
    {
        public ShopProduct()
        {
            ShopPurchaseLogs = new HashSet<ShopPurchaseLog>();
        }

        public Guid ProductGid { get; set; }
        public string? ProductName { get; set; }
        public string? ImageUrl { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int Price { get; set; }
        public int TokenType { get; set; }
        public string? Desc { get; set; }
        public int Status { get; set; }
        public int ExchangeMaxCount { get; set; }
        public int StockMaxCount { get; set; }
        public int OrderCount { get; set; }
        public int WriteOffCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid UpdatedBy { get; set; }
        public Guid CampaignGid { get; set; }
        public int? OrgId { get; set; }
        public string? CustomNo { get; set; }
        public bool CashExchange { get; set; }
        public string? ShipmentMethods { get; set; }
        public string? ShipmentDesc { get; set; }
        public bool Featured { get; set; }
        public int ProductCategoryId { get; set; }

        public virtual ICollection<ShopPurchaseLog> ShopPurchaseLogs { get; set; }
    }
}
