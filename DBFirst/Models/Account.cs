using DB.EnumFields;
using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountCertificates = new HashSet<AccountCertificate>();
            AccountDiseaseIdentifiedAtLogs = new HashSet<AccountDiseaseIdentifiedAtLog>();
            AccountKpiMachines = new HashSet<AccountKpiMachine>();
            AccountNotificationLogs = new HashSet<AccountNotificationLog>();
            AccountRoles = new HashSet<AccountRole>();
            AccountUserAgreements = new HashSet<AccountUserAgreement>();
            AtkRecords = new HashSet<AtkRecord>();
            CaseManagemenetCalls = new HashSet<CaseManagemenetCall>();
            CaseManagements = new HashSet<CaseManagement>();
            CommentReads = new HashSet<CommentRead>();
            Comments = new HashSet<Comment>();
            CourseRecommendAccountGs = new HashSet<CourseRecommend>();
            CourseRecommendRecommendGs = new HashSet<CourseRecommend>();
            Courses = new HashSet<Course>();
            EightDimensionReports = new HashSet<EightDimensionReport>();
            EventApplications = new HashSet<EventApplication>();
            FormRecommendGroups = new HashSet<FormRecommendGroup>();
            LabelAccounts = new HashSet<LabelAccount>();
            MachineUsageLogs = new HashSet<MachineUsageLog>();
            OrganizationMessages = new HashSet<OrganizationMessage>();
            OrganizeAuthorizations = new HashSet<OrganizeAuthorization>();
            PatientGroupDetails = new HashSet<PatientGroupDetail>();
            SatisfactionSurveys = new HashSet<SatisfactionSurvey>();
            ScriptAccounts = new HashSet<ScriptAccount>();
            ScriptExecutionLogs = new HashSet<ScriptExecutionLog>();
            ShopPurchaseLogs = new HashSet<ShopPurchaseLog>();
            SmsLogs = new HashSet<SmsLog>();
            VideoConCalls = new HashSet<VideoConCall>();
            VitalSigns = new HashSet<VitalSign>();
        }

        public Guid Gid { get; set; }
        public string? LoginName { get; set; }
        public string? HashedPassword { get; set; }
        public string? UserName { get; set; }
        public AccountStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int? OrganizationId { get; set; }

        public virtual Organization? Organization { get; set; }
        public virtual AccountConfig? AccountConfig { get; set; }
        public virtual AccountInformation? AccountInformation { get; set; }
        public virtual AccountNotificationSetting? AccountNotificationSetting { get; set; }
        public virtual NidrsChangeRecord? NidrsChangeRecord { get; set; }
        public virtual VitalSignLatest? VitalSignLatest { get; set; }
        public virtual ICollection<AccountCertificate> AccountCertificates { get; set; }
        public virtual ICollection<AccountDiseaseIdentifiedAtLog> AccountDiseaseIdentifiedAtLogs { get; set; }
        public virtual ICollection<AccountKpiMachine> AccountKpiMachines { get; set; }
        public virtual ICollection<AccountNotificationLog> AccountNotificationLogs { get; set; }
        public virtual ICollection<AccountRole> AccountRoles { get; set; }
        public virtual ICollection<AccountUserAgreement> AccountUserAgreements { get; set; }
        public virtual ICollection<AtkRecord> AtkRecords { get; set; }
        public virtual ICollection<CaseManagemenetCall> CaseManagemenetCalls { get; set; }
        public virtual ICollection<CaseManagement> CaseManagements { get; set; }
        public virtual ICollection<CommentRead> CommentReads { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<CourseRecommend> CourseRecommendAccountGs { get; set; }
        public virtual ICollection<CourseRecommend> CourseRecommendRecommendGs { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<EightDimensionReport> EightDimensionReports { get; set; }
        public virtual ICollection<EventApplication> EventApplications { get; set; }
        public virtual ICollection<FormRecommendGroup> FormRecommendGroups { get; set; }
        public virtual ICollection<LabelAccount> LabelAccounts { get; set; }
        public virtual ICollection<MachineUsageLog> MachineUsageLogs { get; set; }
        public virtual ICollection<OrganizationMessage> OrganizationMessages { get; set; }
        public virtual ICollection<OrganizeAuthorization> OrganizeAuthorizations { get; set; }
        public virtual ICollection<PatientGroupDetail> PatientGroupDetails { get; set; }
        public virtual ICollection<SatisfactionSurvey> SatisfactionSurveys { get; set; }
        public virtual ICollection<ScriptAccount> ScriptAccounts { get; set; }
        public virtual ICollection<ScriptExecutionLog> ScriptExecutionLogs { get; set; }
        public virtual ICollection<ShopPurchaseLog> ShopPurchaseLogs { get; set; }
        public virtual ICollection<SmsLog> SmsLogs { get; set; }
        public virtual ICollection<VideoConCall> VideoConCalls { get; set; }
        public virtual ICollection<VitalSign> VitalSigns { get; set; }
    }
}
