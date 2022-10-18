using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Role
    {
        public Role()
        {
            AccountRoles = new HashSet<AccountRole>();
            RolePermissions = new HashSet<RolePermission>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int RoleType { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual ICollection<AccountRole> AccountRoles { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
    }
}
