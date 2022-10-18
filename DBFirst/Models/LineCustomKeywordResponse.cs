using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class LineCustomKeywordResponse
    {
        public int Id { get; set; }
        public int OrgId { get; set; }
        public int SearchType { get; set; }
        public string? Keyword { get; set; }
        public string? KeywordRelatedFunction { get; set; }
        public string? KeywordResponse { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int RequiredDataType { get; set; }
        public string? ResponseImage { get; set; }
        public string? TargetPatientGroup { get; set; }
    }
}
