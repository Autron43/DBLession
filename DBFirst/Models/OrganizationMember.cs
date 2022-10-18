using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class OrganizationMember
    {
        public int Id { get; set; }
        public int OrganizationId { get; set; }
        public string? MemberName { get; set; }
        public string? MemberIntroduction { get; set; }
        public int? MemberPhotoId { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Organization Organization { get; set; } = null!;
    }
}
