using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class QuestionnaireOrganize
    {
        public Guid FormGuid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? OrganizationId { get; set; }
        public int RoleAuthType { get; set; }

        public virtual JfForm FormGu { get; set; } = null!;
        public virtual Organization? Organization { get; set; }
    }
}
