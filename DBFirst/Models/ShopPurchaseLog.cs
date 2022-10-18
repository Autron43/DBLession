using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ShopPurchaseLog
    {
        public ShopPurchaseLog()
        {
            ShopReceiverInfos = new HashSet<ShopReceiverInfo>();
        }

        public int Id { get; set; }
        public Guid ProductGid { get; set; }
        public Guid AccountGid { get; set; }
        public int TokenId { get; set; }
        public int ExchangeCount { get; set; }
        public string? Desc { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdateBy { get; set; }
        public int? OrgId { get; set; }
        public int Type { get; set; }
        public int Cash { get; set; }
        public bool? CashPaid { get; set; }
        public int Point { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual ShopProduct ProductG { get; set; } = null!;
        public virtual ICollection<ShopReceiverInfo> ShopReceiverInfos { get; set; }
    }
}
