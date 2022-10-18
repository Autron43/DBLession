using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class PatientGroupLog
    {
        public int Id { get; set; }
        public int PatientGroupId { get; set; }
        public Guid AccountGid { get; set; }
        public int Operation { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
