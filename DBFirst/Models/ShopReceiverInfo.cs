using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ShopReceiverInfo
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public string? ReceiverName { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int Shipment { get; set; }
        public bool Default { get; set; }
        public int ShopPurchaseLogId { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Guid UpdateBy { get; set; }

        public virtual ShopPurchaseLog ShopPurchaseLog { get; set; } = null!;
    }
}
