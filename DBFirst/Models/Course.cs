using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseRecommends = new HashSet<CourseRecommend>();
        }

        public Guid Gid { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public int Category { get; set; }
        public string? Text { get; set; }
        public string? Link { get; set; }
        public int Mode { get; set; }
        public string? Tags { get; set; }
        public int OrganizationId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account CreatedByNavigation { get; set; } = null!;
        public virtual Organization Organization { get; set; } = null!;
        public virtual ICollection<CourseRecommend> CourseRecommends { get; set; }
    }
}
