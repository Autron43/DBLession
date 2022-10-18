using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class RolePermission
    {
        public int Id { get; set; }
        public string KeyName { get; set; } = null!;
        public bool Read { get; set; }
        public bool Create { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Print { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; } = null!;
    }
}
