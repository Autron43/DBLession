using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class CaseManagement
    {
        public int Id { get; set; }
        public Guid AccountGid { get; set; }
        public DateTime ReportDate { get; set; }
        public string? Name { get; set; }
        public DateTime? VitalSignStartDate { get; set; }
        public DateTime? VitalSignEndDate { get; set; }
        public DateTime? ReturnVisitDate { get; set; }
        public bool ActivateNotify { get; set; }
        public int? NotifyFrequency { get; set; }
        public int? NotifyAtDate { get; set; }
        public TimeSpan? NotifyAt { get; set; }
        public string? DietAdvice { get; set; }
        public string? MedicationAdvice { get; set; }
        public string? ExerciseAdvice { get; set; }
        public string? LifestyleAdvice { get; set; }
        public string? Summary { get; set; }
        public string? Memo { get; set; }
        public Guid UpdatedBy { get; set; }
        public int? OrganizationId { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public virtual Account CreatedByNavigation { get; set; } = null!;
    }
}
