using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CourseRecommend
    {
        public int Id { get; set; }
        public Guid RecommendGid { get; set; }
        public Guid AccountGid { get; set; }
        public Guid CourseGid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account AccountG { get; set; } = null!;
        public virtual Course CourseG { get; set; } = null!;
        public virtual Account RecommendG { get; set; } = null!;
    }
}
