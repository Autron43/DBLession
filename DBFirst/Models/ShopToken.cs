using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ShopToken
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public Guid AccountGid { get; set; }
        public int Count { get; set; }
        public int Balance { get; set; }
        public int TokenType { get; set; }
        public int ReasonType { get; set; }
        public int TransactionType { get; set; }
        public string? Remarks { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
