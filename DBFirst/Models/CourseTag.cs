using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CourseTag
    {
        public int Id { get; set; }
        public string? TagName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
