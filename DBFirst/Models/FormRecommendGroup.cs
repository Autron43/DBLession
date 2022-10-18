using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class FormRecommendGroup
    {
        public FormRecommendGroup()
        {
            FormRecommends = new HashSet<FormRecommend>();
        }

        public Guid Gid { get; set; }
        public Guid AccountGid { get; set; }
        public string? Description { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual ICollection<FormRecommend> FormRecommends { get; set; }
    }
}
