using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class FormRecommend
    {
        public Guid Gid { get; set; }
        public Guid RecommendGid { get; set; }
        public Guid AccountGid { get; set; }
        public int? OrganizationId { get; set; }
        public Guid FormGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime RecommendedAt { get; set; }
        public Guid? FormGroupGid { get; set; }
        public int? FormResponseId { get; set; }

        public virtual FormRecommendGroup? FormGroupG { get; set; }
    }
}
