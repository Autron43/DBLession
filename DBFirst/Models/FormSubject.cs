using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class FormSubject
    {
        public Guid Gid { get; set; }
        public int FormResponseId { get; set; }
        public Guid SubjectGid { get; set; }
    }
}
