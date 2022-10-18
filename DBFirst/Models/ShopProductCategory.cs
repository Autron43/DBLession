using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ShopProductCategory
    {
        public int Id { get; set; }
        public int? OrgId { get; set; }
        public string? CategoryName { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
