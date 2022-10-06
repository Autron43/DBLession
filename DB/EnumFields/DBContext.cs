using DB.Models;
using Microsoft.EntityFrameworkCore;
using mPHR.Services.Database.Models;
using File = mPHR.Services.Database.Models.File;

namespace DB.EnumFields
{
  public class DBContext : DbContext
  {
    public DbSet<AccessLog> AccessLogs { get; set; }
    public DbSet<Account> Accounts { get; set; }
    public DbSet<AccountCertificate> AccountCertificates { get; set; }
    public DbSet<AccountConfig> AccountConfigs { get; set; }
    public DbSet<AccountContactPerson> AccountContactPerson { get; set; }
    public DbSet<AccountDiseaseIdentifiedAtLog> AccountDiseaseIdentifiedAtLogs { get; set; }
    public DbSet<AccountInformation> AccountInformations { get; set; }
    public DbSet<AccountKpiMachine> AccountKpiMachines { get; set; }
    public DbSet<AccountLineSetting> AccountLineSettings { get; set; }
    public DbSet<AccountNotificationLog> AccountNotificationLogs { get; set; }
    public DbSet<AccountNotificationSetting> AccountNotificationSettings { get; set; }
    public DbSet<AccountRole> AccountRoles { get; set; }     
    public DbSet<AccountUserAgreement> AccountUserAgreements { get; set; }
    public DbSet<ApiLog> ApiLogs { get; set; }
    public DbSet<AtkRecords> AtkRecords { get; set; }
    public DbSet<CaseManagemenetCall> CaseManagemenetCalls { get; set; }
    public DbSet<CaseManagement> CaseManagements { get; set; }
    public DbSet<ChairStandTestRecord> ChairStandTestRecords { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<CommentRead> CommentReads { get; set; }
    public DbSet<CoravelLog> CoravelLogs { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<CourseCategory> CourseCategorys { get; set; }
    public DbSet<CourseRecommend> CourseRecommends { get; set; }
    public DbSet<CourseTag> CourseTags { get; set; }
    public DbSet<EightDimensionReport> EightDimensionReports { get; set; }
    public DbSet<ElectronicStethoscopeRecord> ElectronicStethoscopeRecords { get; set; }
    public DbSet<ErrorViewModel> ErrorViewModels { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventApplication> EventApplications { get; set; }
    public DbSet<File> Files { get; set; }
    public DbSet<FirebaseToken> FirebaseTokens{ get; set; }
    public DbSet<FormRecommend> FormRecommends { get; set; }
    public DbSet<FormSubject> FormSubjects { get; set; }
    public DbSet<HealthPassbook> HealthPassbooks { get; set; }
    public DbSet<KpiMachineReportDetail> KpiMachineReportDetails { get; set; }
    public DbSet<Label> Labels { get; set; }
    public DbSet<LabelAccount> LabelAccounts { get; set; }
    public DbSet<LabelOperationLog> LabelOperationLogs { get; set; }
    public DbSet<LineAuthorizationLog> LineAuthorizationLogs { get; set; }
    public DbSet<LineCustomKeywordResponse> LineCustomKeywordResponses { get; set; }
    public DbSet<LineLoginToken> LineLoginTokens { get; set; }
    public DbSet<LinePhrase> LinePhrases { get; set; }
    public DbSet<LineResendQueue> LineResendQueues { get; set; }
    public DbSet<LineSession> LineSessions { get; set; }
    public DbSet<Machine> Machines { get; set; }
    public DbSet<MachineHisLog> MachineHisLogs { get; set; }
    public DbSet<MachineInfo> MachineInfos { get; set; }
    public DbSet<MachineStatusLog> MachineStatusLogs { get; set; }
    public DbSet<MachineUsageLog> MachineUsageLogs { get; set; }
    public DbSet<NidrsChangeRecord> NidrsChangeRecords { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<OrganizationKioskVideo> OrganizationKioskVideos { get; set; }
    public DbSet<OrganizationLineLiff> OrganizationLineLiffs { get; set; }
    public DbSet<OrganizationLineSetting> OrganizationLineSettings { get; set; }
    public DbSet<OrganizationMember> OrganizationMembers { get; set; }
    public DbSet<OrganizationMessage> OrganizationMessages { get; set; }
    public DbSet<OrganizeAuthorization> OrganizeAuthorizations { get; set; }
    public DbSet<OrganizeConfig> OrganizeConfigs { get; set; }
    public DbSet<OrganizeGroup> OrganizeGroups { get; set; }
    public DbSet<PatientGroup> PatientGroup { get; set; }
    public DbSet<PatientGroupDetail> PatientGroupDetails { get; set; }
    public DbSet<PatientGroupLog> PatientGroupLogs { get; set; }
    public DbSet<PatientGroupOwner> PatientGroupOwners { get; set; }
    public DbSet<PatientGroupScript> PatientGroupScripts { get; set; }
    public DbSet<ProductSerial> ProductSerials { get; set; }
    public DbSet<QueryOnly> QueryOnlys { get; set; }
    public DbSet<QuestionnaireOrganize> QuestionnaireOrganizes { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<RolePermission> RolePermissions { get; set; }
    public DbSet<SatisfactionSurvey> SatisfactionSurveys { get; set; }
    public DbSet<Script> Scripts { get; set; }
    public DbSet<ScriptAccount> ScriptAccounts { get; set; }
    public DbSet<ScriptAccountJob> ScriptAccountJobs { get; set; }
    public DbSet<ScriptExecutionLog> ScriptExecutionLogs { get; set; }
    public DbSet<ScriptTrigger> ScriptTriggers { get; set; }
    public DbSet<ShopProduct> ShopProducts { get; set; }
    public DbSet<ShopProductCategory> ShopProductCategorys { get; set; }
    public DbSet<ShopPurchaseLog> ShopPurchaseLogs { get; set; }
    public DbSet<ShopReceiverInfo> ShopReceiverInfos { get; set; }
    public DbSet<ShopToken> ShopTokens { get; set; }
    public DbSet<SleepRecord> SleepRecords { get; set; }
    public DbSet<SmsLog> SmsLogs { get; set; }
    public DbSet<SmsParameter> SmsParameters { get; set; }
    public DbSet<SmsPhrase> SmsPhrases { get; set; }
    public DbSet<SmsSupplier> SmsSuppliers { get; set; }
    public DbSet<StepRecord> StepRecords { get; set; }
    public DbSet<UsageRecord> UsageRecords { get; set; }
    public DbSet<VideoConCall> VideoConCalls { get; set; }
    public DbSet<VitalSign> VitalSigns { get; set; }
    public DbSet<VitalSignLatest> VitalSignLatests { get; set; }
    public DbSet<WalkingSpeedTestRecord> WalkingSpeedTestRecords { get; set; }  


  }
}


