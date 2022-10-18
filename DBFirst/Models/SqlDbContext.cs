using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBFirst.Models
{
  //建立一個繼承至 System.Data.Entity.DbContext 的類別 SqlDbContext
  public partial class SqlDbContext : DbContext
  {
    public SqlDbContext()
    {
    }

    public SqlDbContext(DbContextOptions<SqlDbContext> options)
        : base(options)
    {
    }

    //針對各Data Model加入 DbSet 屬性
    //Properties 
    public virtual DbSet<AccessLog> AccessLogs { get; set; } = null!;
    public virtual DbSet<Account> Accounts { get; set; } = null!;
    public virtual DbSet<AccountCertificate> AccountCertificates { get; set; } = null!;
    public virtual DbSet<AccountConfig> AccountConfigs { get; set; } = null!;
    public virtual DbSet<AccountContactPerson> AccountContactPeople { get; set; } = null!;
    public virtual DbSet<AccountDiseaseIdentifiedAtLog> AccountDiseaseIdentifiedAtLogs { get; set; } = null!;
    public virtual DbSet<AccountInformation> AccountInformations { get; set; } = null!;
    public virtual DbSet<AccountKpiMachine> AccountKpiMachines { get; set; } = null!;
    public virtual DbSet<AccountLineSetting> AccountLineSettings { get; set; } = null!;
    public virtual DbSet<AccountNotificationLog> AccountNotificationLogs { get; set; } = null!;
    public virtual DbSet<AccountNotificationSetting> AccountNotificationSettings { get; set; } = null!;
    public virtual DbSet<AccountRole> AccountRoles { get; set; } = null!;
    public virtual DbSet<AccountUserAgreement> AccountUserAgreements { get; set; } = null!;
    public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; } = null!;
    public virtual DbSet<ApiLog> ApiLogs { get; set; } = null!;
    public virtual DbSet<AtkRecord> AtkRecords { get; set; } = null!;
    public virtual DbSet<CaseManagemenetCall> CaseManagemenetCalls { get; set; } = null!;
    public virtual DbSet<CaseManagement> CaseManagements { get; set; } = null!;
    public virtual DbSet<ChairStandTestRecord> ChairStandTestRecords { get; set; } = null!;
    public virtual DbSet<Comment> Comments { get; set; } = null!;
    public virtual DbSet<CommentRead> CommentReads { get; set; } = null!;
    public virtual DbSet<CoravelLog> CoravelLogs { get; set; } = null!;
    public virtual DbSet<Counter> Counters { get; set; } = null!;
    public virtual DbSet<Course> Courses { get; set; } = null!;
    public virtual DbSet<CourseCategory> CourseCategories { get; set; } = null!;
    public virtual DbSet<CourseRecommend> CourseRecommends { get; set; } = null!;
    public virtual DbSet<CourseTag> CourseTags { get; set; } = null!;
    public virtual DbSet<EightDimensionReport> EightDimensionReports { get; set; } = null!;
    public virtual DbSet<ElectronicStethoscopeRecord> ElectronicStethoscopeRecords { get; set; } = null!;
    public virtual DbSet<Event> Events { get; set; } = null!;
    public virtual DbSet<EventApplication> EventApplications { get; set; } = null!;
    public virtual DbSet<File> Files { get; set; } = null!;
    public virtual DbSet<FirebaseToken> FirebaseTokens { get; set; } = null!;
    public virtual DbSet<FormRecommend> FormRecommends { get; set; } = null!;
    public virtual DbSet<FormRecommendGroup> FormRecommendGroups { get; set; } = null!;
    public virtual DbSet<FormSubject> FormSubjects { get; set; } = null!;
    public virtual DbSet<Hash> Hashes { get; set; } = null!;
    public virtual DbSet<HealthPassbook> HealthPassbooks { get; set; } = null!;
    public virtual DbSet<JfBlock> JfBlocks { get; set; } = null!;
    public virtual DbSet<JfBlockDetail> JfBlockDetails { get; set; } = null!;
    public virtual DbSet<JfForm> JfForms { get; set; } = null!;
    public virtual DbSet<JfMessage> JfMessages { get; set; } = null!;
    public virtual DbSet<JfResult> JfResults { get; set; } = null!;
    public virtual DbSet<JfResultBlock> JfResultBlocks { get; set; } = null!;
    public virtual DbSet<JfResultBlockDetail> JfResultBlockDetails { get; set; } = null!;
    public virtual DbSet<JfTrigger> JfTriggers { get; set; } = null!;
    public virtual DbSet<Job> Jobs { get; set; } = null!;
    public virtual DbSet<JobParameter> JobParameters { get; set; } = null!;
    public virtual DbSet<JobQueue> JobQueues { get; set; } = null!;
    public virtual DbSet<KpiMachineReportDetail> KpiMachineReportDetails { get; set; } = null!;
    public virtual DbSet<Label> Labels { get; set; } = null!;
    public virtual DbSet<LabelAccount> LabelAccounts { get; set; } = null!;
    public virtual DbSet<LabelOperationLog> LabelOperationLogs { get; set; } = null!;
    public virtual DbSet<LineAuthorizationLog> LineAuthorizationLogs { get; set; } = null!;
    public virtual DbSet<LineCustomKeywordResponse> LineCustomKeywordResponses { get; set; } = null!;
    public virtual DbSet<LineLoginToken> LineLoginTokens { get; set; } = null!;
    public virtual DbSet<LinePhrase> LinePhrases { get; set; } = null!;
    public virtual DbSet<LineResendQueue> LineResendQueues { get; set; } = null!;
    public virtual DbSet<LineSession> LineSessions { get; set; } = null!;
    public virtual DbSet<List> Lists { get; set; } = null!;
    public virtual DbSet<Machine> Machines { get; set; } = null!;
    public virtual DbSet<MachineHisLog> MachineHisLogs { get; set; } = null!;
    public virtual DbSet<MachineInfo> MachineInfos { get; set; } = null!;
    public virtual DbSet<MachineStatusLog> MachineStatusLogs { get; set; } = null!;
    public virtual DbSet<MachineUsageLog> MachineUsageLogs { get; set; } = null!;
    public virtual DbSet<NidrsChangeRecord> NidrsChangeRecords { get; set; } = null!;
    public virtual DbSet<Notification> Notifications { get; set; } = null!;
    public virtual DbSet<Organization> Organizations { get; set; } = null!;
    public virtual DbSet<OrganizationLineLiff> OrganizationLineLiffs { get; set; } = null!;
    public virtual DbSet<OrganizationLineSetting> OrganizationLineSettings { get; set; } = null!;
    public virtual DbSet<OrganizationMember> OrganizationMembers { get; set; } = null!;
    public virtual DbSet<OrganizationMessage> OrganizationMessages { get; set; } = null!;
    public virtual DbSet<OrganizeAuthorization> OrganizeAuthorizations { get; set; } = null!;
    public virtual DbSet<OrganizeConfig> OrganizeConfigs { get; set; } = null!;
    public virtual DbSet<OrganizeGroup> OrganizeGroups { get; set; } = null!;
    public virtual DbSet<PatientGroup> PatientGroups { get; set; } = null!;
    public virtual DbSet<PatientGroupDetail> PatientGroupDetails { get; set; } = null!;
    public virtual DbSet<PatientGroupLog> PatientGroupLogs { get; set; } = null!;
    public virtual DbSet<PatientGroupOwner> PatientGroupOwners { get; set; } = null!;
    public virtual DbSet<PatientGroupScript> PatientGroupScripts { get; set; } = null!;
    public virtual DbSet<ProductSerial> ProductSerials { get; set; } = null!;
    public virtual DbSet<QuestionnaireOrganize> QuestionnaireOrganizes { get; set; } = null!;
    public virtual DbSet<Role> Roles { get; set; } = null!;
    public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
    public virtual DbSet<SatisfactionSurvey> SatisfactionSurveys { get; set; } = null!;
    public virtual DbSet<Schema> Schemas { get; set; } = null!;
    public virtual DbSet<Script> Scripts { get; set; } = null!;
    public virtual DbSet<ScriptAccount> ScriptAccounts { get; set; } = null!;
    public virtual DbSet<ScriptAccountJob> ScriptAccountJobs { get; set; } = null!;
    public virtual DbSet<ScriptExecutionLog> ScriptExecutionLogs { get; set; } = null!;
    public virtual DbSet<ScriptTrigger> ScriptTriggers { get; set; } = null!;
    public virtual DbSet<Server> Servers { get; set; } = null!;
    public virtual DbSet<Set> Sets { get; set; } = null!;
    public virtual DbSet<ShopProduct> ShopProducts { get; set; } = null!;
    public virtual DbSet<ShopProductCategory> ShopProductCategories { get; set; } = null!;
    public virtual DbSet<ShopPurchaseLog> ShopPurchaseLogs { get; set; } = null!;
    public virtual DbSet<ShopReceiverInfo> ShopReceiverInfos { get; set; } = null!;
    public virtual DbSet<ShopToken> ShopTokens { get; set; } = null!;
    public virtual DbSet<SleepRecord> SleepRecords { get; set; } = null!;
    public virtual DbSet<SmsLog> SmsLogs { get; set; } = null!;
    public virtual DbSet<SmsParameter> SmsParameters { get; set; } = null!;
    public virtual DbSet<SmsPhrase> SmsPhrases { get; set; } = null!;
    public virtual DbSet<SmsSupplier> SmsSuppliers { get; set; } = null!;
    public virtual DbSet<State> States { get; set; } = null!;
    public virtual DbSet<StepRecord> StepRecords { get; set; } = null!;
    public virtual DbSet<UsageRecord> UsageRecords { get; set; } = null!;
    public virtual DbSet<VideoConCall> VideoConCalls { get; set; } = null!;
    public virtual DbSet<VitalSign> VitalSigns { get; set; } = null!;
    public virtual DbSet<VitalSignLatest> VitalSignLatests { get; set; } = null!;
    public virtual DbSet<WalkingSpeedTestRecord> WalkingSpeedTestRecords { get; set; } = null!;
    public virtual DbSet<OrganizationKioskVideo> OrganizationKioskVideos { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        optionsBuilder.UseSqlServer("Server=DESKTOP-UUQEV4H;Database=mPHR-Test;Trusted_Connection=True");
      }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<AccessLog>(entity =>
      {
        entity.HasIndex(e => new { e.AccountGid, e.CreatedAt }, "IX_AccessLogs_AccountGid_CreatedAt");
      });

      modelBuilder.Entity<Account>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.OrganizationId, "IX_Accounts_OrganizationId");

        entity.HasIndex(e => new { e.UserName, e.LoginName }, "IX_Accounts_UserName_LoginName");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.Property(e => e.HashedPassword).HasMaxLength(200);

        entity.Property(e => e.LoginName).HasMaxLength(50);

        entity.Property(e => e.UserName).HasMaxLength(50);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Accounts)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<AccountCertificate>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountCertificates_AccountGid");

        entity.Property(e => e.CertificateContent).HasMaxLength(100);

        entity.Property(e => e.CertificatedContent).HasMaxLength(100);

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountCertificates)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountConfig>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountConfigs_AccountGid")
                  .IsUnique();

        entity.HasIndex(e => new { e.EmployeeId, e.EmpCode }, "IX_AccountConfigs_EmployeeId_EmpCode");

        entity.Property(e => e.AppleUserId).HasMaxLength(50);

        entity.Property(e => e.FaceBookAccessToken).HasMaxLength(300);

        entity.Property(e => e.FaceBookUserId).HasMaxLength(50);

        entity.Property(e => e.LineNotifyToken).HasMaxLength(50);

        entity.Property(e => e.LineUserId).HasMaxLength(50);

        entity.Property(e => e.SmsPhone).HasMaxLength(20);

        entity.HasOne(d => d.AccountG)
                  .WithOne(p => p.AccountConfig)
                  .HasForeignKey<AccountConfig>(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountDiseaseIdentifiedAtLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountDiseaseIdentifiedAtLogs_AccountGid");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountDiseaseIdentifiedAtLogs)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountInformation>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountInformations_AccountGid")
                  .IsUnique();

        entity.HasIndex(e => new { e.IdentityNo, e.Mobile, e.Birthday, e.Gender, e.CardNo, e.NidrsCode, e.CovidIdentifiedAt }, "IX_AccountInformations_IdentityNo_Mobile_Birthday_Gender_CardNo_NidrsCode_CovidIdentifiedAt");

        entity.Property(e => e.Address).HasMaxLength(100);

        entity.Property(e => e.Birthday).HasColumnType("date");

        entity.Property(e => e.CardNo).HasMaxLength(20);

        entity.Property(e => e.County).HasMaxLength(50);

        entity.Property(e => e.District).HasMaxLength(50);

        entity.Property(e => e.Email).HasMaxLength(100);

        entity.Property(e => e.IdentityNo).HasMaxLength(20);

        entity.Property(e => e.Language).HasMaxLength(20);

        entity.Property(e => e.Mobile).HasMaxLength(50);

        entity.Property(e => e.Tel).HasMaxLength(50);

        entity.Property(e => e.ZipCode).HasMaxLength(10);

        entity.HasOne(d => d.AccountG)
                  .WithOne(p => p.AccountInformation)
                  .HasForeignKey<AccountInformation>(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountKpiMachine>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountKpiMachines_AccountGid");

        entity.HasIndex(e => e.MachineId, "IX_AccountKpiMachines_MachineId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountKpiMachines)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.AccountKpiMachines)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<AccountLineSetting>(entity =>
      {
        entity.HasIndex(e => new { e.AccountGid, e.OrgId }, "IX_AccountLineSettings_AccountGid_OrgId");

        entity.HasIndex(e => new { e.LineUserId, e.OrgId }, "IX_AccountLineSettings_LineUserId_OrgId");

        entity.Property(e => e.LineUserId).HasMaxLength(100);
      });

      modelBuilder.Entity<AccountNotificationLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountNotificationLogs_AccountGid");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountNotificationLogs)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountNotificationSetting>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountNotificationSettings_AccountGid")
                  .IsUnique();

        entity.HasOne(d => d.AccountG)
                  .WithOne(p => p.AccountNotificationSetting)
                  .HasForeignKey<AccountNotificationSetting>(d => d.AccountGid);
      });

      modelBuilder.Entity<AccountRole>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountRoles_AccountGid");

        entity.HasIndex(e => e.RoleId, "IX_AccountRoles_RoleId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountRoles)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Role)
                  .WithMany(p => p.AccountRoles)
                  .HasForeignKey(d => d.RoleId);
      });

      modelBuilder.Entity<AccountUserAgreement>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_AccountUserAgreements_AccountGid");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.AccountUserAgreements)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<AggregatedCounter>(entity =>
      {
        entity.HasKey(e => e.Key)
                  .HasName("PK_HangFire_CounterAggregated");

        entity.ToTable("AggregatedCounter", "dbo.hf");

        entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                  .HasFilter("([ExpireAt] IS NOT NULL)");

        entity.Property(e => e.Key).HasMaxLength(100);

        entity.Property(e => e.ExpireAt).HasColumnType("datetime");
      });

      modelBuilder.Entity<ApiLog>(entity =>
      {
        entity.Property(e => e.Method).HasMaxLength(6);

        entity.Property(e => e.Uri).HasMaxLength(100);
      });

      modelBuilder.Entity<AtkRecord>(entity =>
      {
        entity.HasIndex(e => e.VerifierGid, "IX_AtkRecords_VerifierGid");

        entity.Property(e => e.RapidTestId).HasMaxLength(50);

        entity.HasOne(d => d.VerifierG)
                  .WithMany(p => p.AtkRecords)
                  .HasForeignKey(d => d.VerifierGid);
      });

      modelBuilder.Entity<CaseManagemenetCall>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_CaseManagemenetCalls_AccountGid");

        entity.HasIndex(e => e.CreatedBy, "IX_CaseManagemenetCalls_CreatedBy");

        entity.HasOne(d => d.CreatedByNavigation)
                  .WithMany(p => p.CaseManagemenetCalls)
                  .HasForeignKey(d => d.CreatedBy);
      });

      modelBuilder.Entity<CaseManagement>(entity =>
      {
        entity.HasIndex(e => e.CreatedBy, "IX_CaseManagements_CreatedBy");

        entity.Property(e => e.Name).HasMaxLength(100);

        entity.Property(e => e.ReportDate).HasColumnType("date");

        entity.Property(e => e.ReturnVisitDate).HasColumnType("date");

        entity.Property(e => e.VitalSignEndDate).HasColumnType("date");

        entity.Property(e => e.VitalSignStartDate).HasColumnType("date");

        entity.HasOne(d => d.CreatedByNavigation)
                  .WithMany(p => p.CaseManagements)
                  .HasForeignKey(d => d.CreatedBy)
                  .OnDelete(DeleteBehavior.ClientSetNull);
      });

      modelBuilder.Entity<Comment>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.CreatedBy, "IX_Comments_CreatedBy");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.HasOne(d => d.CreatedByNavigation)
                  .WithMany(p => p.Comments)
                  .HasForeignKey(d => d.CreatedBy);
      });

      modelBuilder.Entity<CommentRead>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.AccountGid, "IX_CommentReads_AccountGid");

        entity.Property(e => e.Gid)
                  .ValueGeneratedNever()
                  .HasColumnName("gid");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.CommentReads)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<Counter>(entity =>
      {
        entity.HasNoKey();

        entity.ToTable("Counter", "dbo.hf");

        entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                  .IsClustered();

        entity.Property(e => e.ExpireAt).HasColumnType("datetime");

        entity.Property(e => e.Key).HasMaxLength(100);
      });

      modelBuilder.Entity<Course>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.CreatedBy, "IX_Courses_CreatedBy");

        entity.HasIndex(e => e.OrganizationId, "IX_Courses_OrganizationId");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.Property(e => e.Title).HasMaxLength(50);

        entity.HasOne(d => d.CreatedByNavigation)
                  .WithMany(p => p.Courses)
                  .HasForeignKey(d => d.CreatedBy)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Courses)
                  .HasForeignKey(d => d.OrganizationId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
      });

      modelBuilder.Entity<CourseCategory>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_CourseCategories_OrganizationId");

        entity.Property(e => e.Name).HasMaxLength(50);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.CourseCategories)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<CourseRecommend>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_CourseRecommends_AccountGid");

        entity.HasIndex(e => e.CourseGid, "IX_CourseRecommends_CourseGid");

        entity.HasIndex(e => e.RecommendGid, "IX_CourseRecommends_RecommendGid");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.CourseRecommendAccountGs)
                  .HasForeignKey(d => d.AccountGid)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.CourseG)
                  .WithMany(p => p.CourseRecommends)
                  .HasForeignKey(d => d.CourseGid);

        entity.HasOne(d => d.RecommendG)
                  .WithMany(p => p.CourseRecommendRecommendGs)
                  .HasForeignKey(d => d.RecommendGid)
                  .OnDelete(DeleteBehavior.ClientSetNull);
      });

      modelBuilder.Entity<EightDimensionReport>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_EightDimensionReports_AccountGid");

        entity.HasIndex(e => new { e.Category, e.Type }, "IX_EightDimensionReports_Category_Type");

        entity.HasIndex(e => e.QuestionnaireGid, "IX_EightDimensionReports_QuestionnaireGid");

        entity.Property(e => e.TestAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.EightDimensionReports)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<Event>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_Events_OrganizationId");

        entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Events)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<EventApplication>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_EventApplications_AccountGid");

        entity.HasIndex(e => e.EventId, "IX_EventApplications_EventId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.EventApplications)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Event)
                  .WithMany(p => p.EventApplications)
                  .HasForeignKey(d => d.EventId);
      });

      modelBuilder.Entity<File>(entity =>
      {
        entity.HasKey(e => e.Id);

        entity.HasIndex(e => e.OrganizationId, "IX_Files_OrganizationId");

        entity.Property(e => e.ExternalLinkName).HasMaxLength(5);

        entity.Property(e => e.ImageHash).HasMaxLength(40);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Files)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<FormRecommend>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => new { e.AccountGid, e.RecommendGid, e.FormGid, e.RecommendedAt }, "IX_FormRecommends_AccountGid_RecommendGid_FormGid_RecommendedAt");

        entity.HasIndex(e => e.FormGroupGid, "IX_FormRecommends_FormGroupGid");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.HasOne(d => d.FormGroupG)
                  .WithMany(p => p.FormRecommends)
                  .HasForeignKey(d => d.FormGroupGid);
      });

      modelBuilder.Entity<FormRecommendGroup>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.AccountGid, "IX_FormRecommendGroups_AccountGid");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.FormRecommendGroups)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<FormSubject>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.Property(e => e.Gid).ValueGeneratedNever();
      });

      modelBuilder.Entity<Hash>(entity =>
      {
        entity.HasKey(e => new { e.Key, e.Field })
                  .HasName("PK_HangFire_Hash");

        entity.ToTable("Hash", "dbo.hf");

        entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                  .HasFilter("([ExpireAt] IS NOT NULL)");

        entity.Property(e => e.Key).HasMaxLength(100);

        entity.Property(e => e.Field).HasMaxLength(100);
      });

      modelBuilder.Entity<JfBlock>(entity =>
      {
        entity.ToTable("jf_Blocks");

        entity.HasIndex(e => e.FormGid, "IX_jf_Blocks_FormGid");

        entity.Property(e => e.Title).HasMaxLength(128);

        entity.HasOne(d => d.FormG)
                  .WithMany(p => p.JfBlocks)
                  .HasForeignKey(d => d.FormGid);
      });

      modelBuilder.Entity<JfBlockDetail>(entity =>
      {
        entity.ToTable("jf_BlockDetails");

        entity.HasIndex(e => e.BlockId, "IX_jf_BlockDetails_BlockId");

        entity.HasOne(d => d.Block)
                  .WithMany(p => p.JfBlockDetails)
                  .HasForeignKey(d => d.BlockId);
      });

      modelBuilder.Entity<JfForm>(entity =>
      {
        entity.HasKey(e => e.Guid);

        entity.ToTable("jf_Forms");

        entity.Property(e => e.Guid).ValueGeneratedNever();

        entity.Property(e => e.Score)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.Property(e => e.Title).HasMaxLength(128);
      });

      modelBuilder.Entity<JfMessage>(entity =>
      {
        entity.ToTable("jf_Messages");

        entity.HasIndex(e => e.FormGid, "IX_jf_Messages_FormGid");

        entity.HasOne(d => d.FormG)
                  .WithMany(p => p.JfMessages)
                  .HasForeignKey(d => d.FormGid);
      });

      modelBuilder.Entity<JfResult>(entity =>
      {
        entity.ToTable("jf_Results");

        entity.HasIndex(e => e.FormGid, "IX_jf_Results_FormGid");

        entity.HasIndex(e => e.RecordAt, "IX_jf_Results_RecordAt");

        entity.HasOne(d => d.FormG)
                  .WithMany(p => p.JfResults)
                  .HasForeignKey(d => d.FormGid);
      });

      modelBuilder.Entity<JfResultBlock>(entity =>
      {
        entity.ToTable("jf_ResultBlocks");

        entity.HasIndex(e => e.ResultId, "IX_jf_ResultBlocks_ResultId");

        entity.Property(e => e.Title).HasMaxLength(128);

        entity.HasOne(d => d.Result)
                  .WithMany(p => p.JfResultBlocks)
                  .HasForeignKey(d => d.ResultId);
      });

      modelBuilder.Entity<JfResultBlockDetail>(entity =>
      {
        entity.ToTable("jf_ResultBlockDetails");

        entity.HasIndex(e => e.BlockId, "IX_jf_ResultBlockDetails_BlockId");

        entity.HasOne(d => d.Block)
                  .WithMany(p => p.JfResultBlockDetails)
                  .HasForeignKey(d => d.BlockId);
      });

      modelBuilder.Entity<JfTrigger>(entity =>
      {
        entity.ToTable("jf_Triggers");

        entity.HasIndex(e => e.FormGid, "IX_jf_Triggers_FormGid");

        entity.HasOne(d => d.FormG)
                  .WithMany(p => p.JfTriggers)
                  .HasForeignKey(d => d.FormGid);
      });

      modelBuilder.Entity<Job>(entity =>
      {
        entity.ToTable("Job", "dbo.hf");

        entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                  .HasFilter("([ExpireAt] IS NOT NULL)");

        entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                  .HasFilter("([StateName] IS NOT NULL)");

        entity.Property(e => e.CreatedAt).HasColumnType("datetime");

        entity.Property(e => e.ExpireAt).HasColumnType("datetime");

        entity.Property(e => e.StateName).HasMaxLength(20);
      });

      modelBuilder.Entity<JobParameter>(entity =>
      {
        entity.HasKey(e => new { e.JobId, e.Name })
                  .HasName("PK_HangFire_JobParameter");

        entity.ToTable("JobParameter", "dbo.hf");

        entity.Property(e => e.Name).HasMaxLength(40);

        entity.HasOne(d => d.Job)
                  .WithMany(p => p.JobParameters)
                  .HasForeignKey(d => d.JobId)
                  .HasConstraintName("FK_HangFire_JobParameter_Job");
      });

      modelBuilder.Entity<JobQueue>(entity =>
      {
        entity.HasKey(e => new { e.Queue, e.Id })
                  .HasName("PK_HangFire_JobQueue");

        entity.ToTable("JobQueue", "dbo.hf");

        entity.Property(e => e.Queue).HasMaxLength(50);

        entity.Property(e => e.Id).ValueGeneratedOnAdd();

        entity.Property(e => e.FetchedAt).HasColumnType("datetime");
      });

      modelBuilder.Entity<KpiMachineReportDetail>(entity =>
      {
        entity.HasKey(e => new { e.StatsAt, e.MachineId });

        entity.Property(e => e.O2testTimes).HasColumnName("O2TestTimes");
      });

      modelBuilder.Entity<Label>(entity =>
      {
        entity.HasIndex(e => e.Name, "IX_Labels_Name");

        entity.HasIndex(e => e.OrganizationId, "IX_Labels_OrganizationId");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Labels)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<LabelAccount>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_LabelAccounts_AccountGid");

        entity.HasIndex(e => e.LabelId, "IX_LabelAccounts_LabelId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.LabelAccounts)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Label)
                  .WithMany(p => p.LabelAccounts)
                  .HasForeignKey(d => d.LabelId);
      });

      modelBuilder.Entity<LabelOperationLog>(entity =>
      {
        entity.HasIndex(e => e.LabelId, "IX_LabelOperationLogs_LabelId");

        entity.HasOne(d => d.Label)
                  .WithMany(p => p.LabelOperationLogs)
                  .HasForeignKey(d => d.LabelId);
      });

      modelBuilder.Entity<LineAuthorizationLog>(entity =>
      {
        entity.Property(e => e.CovidPatient)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");
      });

      modelBuilder.Entity<LineCustomKeywordResponse>(entity =>
      {
        entity.Property(e => e.KeywordRelatedFunction).HasColumnName("keywordRelatedFunction");
      });

      modelBuilder.Entity<LinePhrase>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_LinePhrases_OrganizationId");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.LinePhrases)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<LineSession>(entity =>
      {
        entity.HasIndex(e => new { e.LineUserId, e.OrgId }, "IX_LineSessions_LineUserId_OrgId");

        entity.Property(e => e.CreatedAt).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

        entity.Property(e => e.LineUserId).HasMaxLength(100);

        entity.Property(e => e.Register)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");
      });

      modelBuilder.Entity<List>(entity =>
      {
        entity.HasKey(e => new { e.Key, e.Id })
                  .HasName("PK_HangFire_List");

        entity.ToTable("List", "dbo.hf");

        entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                  .HasFilter("([ExpireAt] IS NOT NULL)");

        entity.Property(e => e.Key).HasMaxLength(100);

        entity.Property(e => e.Id).ValueGeneratedOnAdd();

        entity.Property(e => e.ExpireAt).HasColumnType("datetime");
      });

      modelBuilder.Entity<Machine>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_Machines_OrganizationId");

        entity.Property(e => e.Available)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.Property(e => e.DeviceSerialNo).HasMaxLength(50);

        entity.Property(e => e.Ipaddress)
                  .HasMaxLength(30)
                  .HasColumnName("IPAddress");

        entity.Property(e => e.LastTestDateO2).HasColumnName("LastTestDate_O2");

        entity.Property(e => e.Macaddress)
                  .HasMaxLength(30)
                  .HasColumnName("MACAddress");

        entity.Property(e => e.MachineNotifyToken).HasMaxLength(200);

        entity.Property(e => e.SystemSerialNo).HasMaxLength(50);

        entity.Property(e => e.SystemVersion).HasMaxLength(10);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Machines)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<MachineHisLog>(entity =>
      {
        entity.HasIndex(e => e.MachineId, "IX_MachineHisLogs_MachineId");

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.MachineHisLogs)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<MachineInfo>(entity =>
      {
        entity.HasIndex(e => e.MachineId, "IX_MachineInfos_MachineId")
                  .IsUnique();

        entity.Property(e => e.Name).HasMaxLength(100);

        entity.Property(e => e.SimPhoneNumber).HasMaxLength(20);

        entity.Property(e => e.Xjkproject).HasColumnName("XJKProject");

        entity.HasOne(d => d.Machine)
                  .WithOne(p => p.MachineInfo)
                  .HasForeignKey<MachineInfo>(d => d.MachineId);
      });

      modelBuilder.Entity<MachineStatusLog>(entity =>
      {
        entity.HasIndex(e => e.MachineId, "IX_MachineStatusLogs_MachineId");

        entity.Property(e => e.AppVer).HasMaxLength(20);

        entity.Property(e => e.BloodPressurePort).HasMaxLength(150);

        entity.Property(e => e.BodyTempDevice).HasMaxLength(30);

        entity.Property(e => e.Boot).HasMaxLength(30);

        entity.Property(e => e.CardDevice).HasMaxLength(20);

        entity.Property(e => e.CurrentActivity).HasMaxLength(50);

        entity.Property(e => e.HeightWeightPort).HasMaxLength(150);

        entity.Property(e => e.Ipaddress)
                  .HasMaxLength(30)
                  .HasColumnName("IPAddress");

        entity.Property(e => e.MobileTraffic).HasMaxLength(15);

        entity.Property(e => e.NetworkType).HasMaxLength(20);

        entity.Property(e => e.Spo2Device).HasMaxLength(30);

        entity.Property(e => e.TotalTraffic).HasMaxLength(15);

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.MachineStatusLogs)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<MachineUsageLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_MachineUsageLogs_AccountGid");

        entity.HasIndex(e => e.MachineId, "IX_MachineUsageLogs_MachineId");

        entity.Property(e => e.TimeOfUsage).HasMaxLength(8);

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.MachineUsageLogs)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.MachineUsageLogs)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<NidrsChangeRecord>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_NidrsChangeRecords_AccountGid")
                  .IsUnique()
                  .HasFilter("([AccountGid] IS NOT NULL)");

        entity.Property(e => e.Address).HasMaxLength(100);

        entity.Property(e => e.IdentityNo).HasMaxLength(20);

        entity.Property(e => e.Mobile).HasMaxLength(50);

        entity.Property(e => e.Tel).HasMaxLength(50);

        entity.Property(e => e.UserName).HasMaxLength(50);

        entity.HasOne(d => d.AccountG)
                  .WithOne(p => p.NidrsChangeRecord)
                  .HasForeignKey<NidrsChangeRecord>(d => d.AccountGid)
                  .OnDelete(DeleteBehavior.Cascade);
      });

      modelBuilder.Entity<Notification>(entity =>
      {
        entity.HasIndex(e => e.ExpectedTime, "IX_ExpectedTime");
      });

      modelBuilder.Entity<Organization>(entity =>
      {
        entity.HasKey(e => e.Id);

        entity.HasIndex(e => e.SmsSupplierId, "IX_Organizations_SmsSupplierId");

        entity.Property(e => e.CompanyId).HasMaxLength(50);

        entity.Property(e => e.Email).HasMaxLength(50);

        entity.Property(e => e.Mobile).HasMaxLength(50);

        entity.Property(e => e.Name).HasMaxLength(100);

        entity.Property(e => e.Tel).HasMaxLength(50);

        entity.HasOne(d => d.SmsSupplier)
                  .WithMany(p => p.Organizations)
                  .HasForeignKey(d => d.SmsSupplierId);

      });

      modelBuilder.Entity<OrganizationLineSetting>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_OrganizationLineSettings_OrganizationId");

        entity.Property(e => e.LineOrgCode).HasMaxLength(50);
      });

      modelBuilder.Entity<OrganizationMember>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_OrganizationMembers_OrganizationId");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.OrganizationMembers)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<OrganizationMessage>(entity =>
      {
        entity.HasIndex(e => e.CreatedBy, "IX_OrganizationMessages_CreatedBy");

        entity.HasIndex(e => e.OrganizationId, "IX_OrganizationMessages_OrganizationId");

        entity.Property(e => e.Id).ValueGeneratedNever();

        entity.Property(e => e.Title).HasMaxLength(100);

        entity.HasOne(d => d.CreatedByNavigation)
                  .WithMany(p => p.OrganizationMessages)
                  .HasForeignKey(d => d.CreatedBy)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.OrganizationMessages)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<OrganizeAuthorization>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_OrganizeAuthorizations_AccountGid");

        entity.HasIndex(e => e.CreatedAt, "IX_OrganizeAuthorizations_CreatedAt");

        entity.HasIndex(e => e.OrganizationId, "IX_OrganizeAuthorizations_OrganizationId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.OrganizeAuthorizations)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.OrganizeAuthorizations)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<OrganizeConfig>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_OrganizeConfigs_OrganizationId")
                  .IsUnique();

        entity.Property(e => e.ExtensionName).HasMaxLength(20);

        entity.Property(e => e.MphrNavBrand)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.HasOne(d => d.Organization)
                  .WithOne(p => p.OrganizeConfig)
                  .HasForeignKey<OrganizeConfig>(d => d.OrganizationId);
      });

      modelBuilder.Entity<OrganizeGroup>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_OrganizeGroups_OrganizationId");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.OrganizeGroups)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<PatientGroup>(entity =>
      {
        entity.ToTable("PatientGroup");

        entity.HasIndex(e => e.OrganizationId, "IX_PatientGroup_OrganizationId");

        entity.Property(e => e.Name).HasMaxLength(50);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.PatientGroups)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<PatientGroupDetail>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_PatientGroupDetails_AccountGid");

        entity.HasIndex(e => e.CreatedAt, "IX_PatientGroupDetails_CreatedAt");

        entity.HasIndex(e => e.PatientGroupId, "IX_PatientGroupDetails_PatientGroupId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.PatientGroupDetails)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.PatientGroup)
                  .WithMany(p => p.PatientGroupDetails)
                  .HasForeignKey(d => d.PatientGroupId);
      });

      modelBuilder.Entity<PatientGroupOwner>(entity =>
      {
        entity.HasIndex(e => e.PatientGroupId, "IX_PatientGroupOwners_PatientGroupId");

        entity.HasOne(d => d.PatientGroup)
                  .WithMany(p => p.PatientGroupOwners)
                  .HasForeignKey(d => d.PatientGroupId);
      });

      modelBuilder.Entity<PatientGroupScript>(entity =>
      {
        entity.HasIndex(e => e.PatientGroupId, "IX_PatientGroupScripts_PatientGroupId");

        entity.HasIndex(e => e.ScriptId, "IX_PatientGroupScripts_ScriptId");

        entity.HasOne(d => d.PatientGroup)
                  .WithMany(p => p.PatientGroupScripts)
                  .HasForeignKey(d => d.PatientGroupId);

        entity.HasOne(d => d.Script)
                  .WithMany(p => p.PatientGroupScripts)
                  .HasForeignKey(d => d.ScriptId)
                  .OnDelete(DeleteBehavior.ClientSetNull);
      });

      modelBuilder.Entity<ProductSerial>(entity =>
      {
        entity.HasKey(e => e.SerialNo);

        entity.HasIndex(e => e.MachineId, "IX_ProductSerials_MachineId");

        entity.HasIndex(e => e.OrganizationId, "IX_ProductSerials_OrganizationId");

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.ProductSerials)
                  .HasForeignKey(d => d.MachineId);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.ProductSerials)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<QuestionnaireOrganize>(entity =>
      {
        entity.HasKey(e => e.FormGuid);

        entity.HasIndex(e => e.OrganizationId, "IX_QuestionnaireOrganizes_OrganizationId");

        entity.Property(e => e.FormGuid).ValueGeneratedNever();

        entity.Property(e => e.RoleAuthType).HasDefaultValueSql("((32))");

        entity.HasOne(d => d.FormGu)
                  .WithOne(p => p.QuestionnaireOrganize)
                  .HasForeignKey<QuestionnaireOrganize>(d => d.FormGuid);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.QuestionnaireOrganizes)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<Role>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_Roles_OrganizationId");

        entity.Property(e => e.Name).HasMaxLength(20);

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Roles)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<RolePermission>(entity =>
      {
        entity.HasIndex(e => e.RoleId, "IX_RolePermissions_RoleId");

        entity.HasOne(d => d.Role)
                  .WithMany(p => p.RolePermissions)
                  .HasForeignKey(d => d.RoleId);
      });

      modelBuilder.Entity<SatisfactionSurvey>(entity =>
      {
        entity.ToTable("SatisfactionSurvey");

        entity.HasIndex(e => e.AccountGid, "IX_SatisfactionSurvey_AccountGid");

        entity.HasIndex(e => e.MachineId, "IX_SatisfactionSurvey_MachineId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.SatisfactionSurveys)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.SatisfactionSurveys)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<Schema>(entity =>
      {
        entity.HasKey(e => e.Version)
                  .HasName("PK_HangFire_Schema");

        entity.ToTable("Schema", "dbo.hf");

        entity.Property(e => e.Version).ValueGeneratedNever();
      });

      modelBuilder.Entity<Script>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_Scripts_OrganizationId");

        entity.Property(e => e.CronExpression).HasMaxLength(300);

        entity.Property(e => e.Enabled)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.Property(e => e.IsDeleted)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.Property(e => e.TriggerOnce)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(1)))");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.Scripts)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<ScriptAccount>(entity =>
      {
        entity.ToTable("ScriptAccount");

        entity.HasIndex(e => e.AccountGid, "IX_ScriptAccount_AccountGid");

        entity.HasIndex(e => e.GroupScriptId, "IX_ScriptAccount_GroupScriptId");

        entity.HasIndex(e => e.ScriptId, "IX_ScriptAccount_ScriptId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.ScriptAccounts)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.GroupScript)
                  .WithMany(p => p.ScriptAccounts)
                  .HasForeignKey(d => d.GroupScriptId)
                  .OnDelete(DeleteBehavior.ClientSetNull);

        entity.HasOne(d => d.Script)
                  .WithMany(p => p.ScriptAccounts)
                  .HasForeignKey(d => d.ScriptId);
      });

      modelBuilder.Entity<ScriptAccountJob>(entity =>
      {
        entity.HasIndex(e => e.ScriptAccountId, "IX_ScriptAccountJobs_ScriptAccountId");

        entity.HasOne(d => d.ScriptAccount)
                  .WithMany(p => p.ScriptAccountJobs)
                  .HasForeignKey(d => d.ScriptAccountId);
      });

      modelBuilder.Entity<ScriptExecutionLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_ScriptExecutionLogs_AccountGid");

        entity.HasIndex(e => e.ScriptId, "IX_ScriptExecutionLogs_ScriptId");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.ScriptExecutionLogs)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Script)
                  .WithMany(p => p.ScriptExecutionLogs)
                  .HasForeignKey(d => d.ScriptId);
      });

      modelBuilder.Entity<ScriptTrigger>(entity =>
      {
        entity.HasIndex(e => e.ScriptId, "IX_ScriptTriggers_ScriptId");

        entity.Property(e => e.CronExpression).HasMaxLength(300);

        entity.HasOne(d => d.Script)
                  .WithMany(p => p.ScriptTriggers)
                  .HasForeignKey(d => d.ScriptId);
      });

      modelBuilder.Entity<Server>(entity =>
      {
        entity.ToTable("Server", "dbo.hf");

        entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

        entity.Property(e => e.Id).HasMaxLength(200);

        entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
      });

      modelBuilder.Entity<Set>(entity =>
      {
        entity.HasKey(e => new { e.Key, e.Value })
                  .HasName("PK_HangFire_Set");

        entity.ToTable("Set", "dbo.hf");

        entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                  .HasFilter("([ExpireAt] IS NOT NULL)");

        entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

        entity.Property(e => e.Key).HasMaxLength(100);

        entity.Property(e => e.Value).HasMaxLength(256);

        entity.Property(e => e.ExpireAt).HasColumnType("datetime");
      });

      modelBuilder.Entity<ShopProduct>(entity =>
      {
        entity.HasKey(e => e.ProductGid);

        entity.Property(e => e.ProductGid).ValueGeneratedNever();

        entity.Property(e => e.ProductName).HasMaxLength(100);
      });

      modelBuilder.Entity<ShopPurchaseLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_ShopPurchaseLogs_AccountGid");

        entity.HasIndex(e => e.ProductGid, "IX_ShopPurchaseLogs_ProductGid");

        entity.Property(e => e.CashPaid)
                  .IsRequired()
                  .HasDefaultValueSql("(CONVERT([bit],(0)))");

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.ShopPurchaseLogs)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.ProductG)
                  .WithMany(p => p.ShopPurchaseLogs)
                  .HasForeignKey(d => d.ProductGid);
      });

      modelBuilder.Entity<ShopReceiverInfo>(entity =>
      {
        entity.HasIndex(e => e.ShopPurchaseLogId, "IX_ShopReceiverInfos_ShopPurchaseLogId");

        entity.HasOne(d => d.ShopPurchaseLog)
                  .WithMany(p => p.ShopReceiverInfos)
                  .HasForeignKey(d => d.ShopPurchaseLogId);
      });

      modelBuilder.Entity<SleepRecord>(entity =>
      {
        entity.Property(e => e.AppleHealthId).HasMaxLength(36);

        entity.Property(e => e.GoogleFitId).HasMaxLength(36);
      });

      modelBuilder.Entity<SmsLog>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_SmsLogs_AccountGid");

        entity.Property(e => e.Message).HasMaxLength(500);

        entity.Property(e => e.Name).HasMaxLength(30);

        entity.Property(e => e.SendPhone).HasMaxLength(20);

        entity.Property(e => e.SmsId).HasMaxLength(50);

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.SmsLogs)
                  .HasForeignKey(d => d.AccountGid);
      });

      modelBuilder.Entity<SmsParameter>(entity =>
      {
        entity.HasIndex(e => e.SmsSupplierId, "IX_SmsParameters_SmsSupplierId");

        entity.Property(e => e.Key).HasMaxLength(20);

        entity.Property(e => e.Value).HasMaxLength(20);

        entity.HasOne(d => d.SmsSupplier)
                  .WithMany(p => p.SmsParameters)
                  .HasForeignKey(d => d.SmsSupplierId);
      });

      modelBuilder.Entity<SmsPhrase>(entity =>
      {
        entity.HasIndex(e => e.OrganizationId, "IX_SmsPhrases_OrganizationId");

        entity.HasOne(d => d.Organization)
                  .WithMany(p => p.SmsPhrases)
                  .HasForeignKey(d => d.OrganizationId);
      });

      modelBuilder.Entity<SmsSupplier>(entity =>
      {
        entity.Property(e => e.Account).HasMaxLength(30);

        entity.Property(e => e.CostUrl).HasMaxLength(100);

        entity.Property(e => e.Name).HasMaxLength(20);

        entity.Property(e => e.Password).HasMaxLength(30);

        entity.Property(e => e.SendUrl).HasMaxLength(100);
      });

      modelBuilder.Entity<State>(entity =>
      {
        entity.HasKey(e => new { e.JobId, e.Id })
                  .HasName("PK_HangFire_State");

        entity.ToTable("State", "dbo.hf");

        entity.Property(e => e.Id).ValueGeneratedOnAdd();

        entity.Property(e => e.CreatedAt).HasColumnType("datetime");

        entity.Property(e => e.Name).HasMaxLength(20);

        entity.Property(e => e.Reason).HasMaxLength(100);

        entity.HasOne(d => d.Job)
                  .WithMany(p => p.States)
                  .HasForeignKey(d => d.JobId)
                  .HasConstraintName("FK_HangFire_State_Job");
      });

      modelBuilder.Entity<StepRecord>(entity =>
      {
        entity.Property(e => e.AppleHealthId).HasMaxLength(36);

        entity.Property(e => e.GoogleFitId).HasMaxLength(36);
      });

      modelBuilder.Entity<UsageRecord>(entity =>
      {
        entity.Property(e => e.ObjectId).HasMaxLength(36);
      });

      modelBuilder.Entity<VideoConCall>(entity =>
      {
        entity.HasKey(e => e.Gid);

        entity.HasIndex(e => e.CreatedAccountGid, "IX_VideoConCalls_CreatedAccountGid");

        entity.HasIndex(e => e.OrgId, "IX_VideoConCalls_OrgId");

        entity.Property(e => e.Gid).ValueGeneratedNever();

        entity.HasOne(d => d.CreatedAccountG)
                  .WithMany(p => p.VideoConCalls)
                  .HasForeignKey(d => d.CreatedAccountGid);

        entity.HasOne(d => d.Org)
                  .WithMany(p => p.VideoConCalls)
                  .HasForeignKey(d => d.OrgId);
      });

      modelBuilder.Entity<VitalSign>(entity =>
      {
        entity.HasIndex(e => e.AccountGid, "IX_VitalSigns_AccountGid");

        entity.HasIndex(e => e.AtkId, "IX_VitalSigns_AtkId")
                  .IsUnique()
                  .HasFilter("([AtkId] IS NOT NULL)");

        entity.HasIndex(e => e.MachineId, "IX_VitalSigns_MachineId");

        entity.Property(e => e.AppleHealthId).HasMaxLength(36);

        entity.Property(e => e.Bmi).HasColumnName("BMI");

        entity.Property(e => e.Bmr).HasColumnName("BMR");

        entity.Property(e => e.DeviceModel).HasMaxLength(50);

        entity.Property(e => e.EStethoscopeKey).HasColumnName("eStethoscopeKey");

        entity.Property(e => e.GoogleFitId).HasMaxLength(36);

        entity.HasOne(d => d.AccountG)
                  .WithMany(p => p.VitalSigns)
                  .HasForeignKey(d => d.AccountGid);

        entity.HasOne(d => d.Atk)
                  .WithOne(p => p.VitalSign)
                  .HasForeignKey<VitalSign>(d => d.AtkId);

        entity.HasOne(d => d.Machine)
                  .WithMany(p => p.VitalSigns)
                  .HasForeignKey(d => d.MachineId);
      });

      modelBuilder.Entity<VitalSignLatest>(entity =>
      {
        entity.HasKey(e => e.AccountGid);

        entity.Property(e => e.AccountGid).ValueGeneratedNever();

        entity.Property(e => e.Atk).HasMaxLength(50);

        entity.Property(e => e.BloodO2source).HasColumnName("BloodO2Source");

        entity.Property(e => e.BloodO2testTime).HasColumnName("BloodO2TestTime");

        entity.Property(e => e.Bmi).HasColumnName("BMI");

        entity.HasOne(d => d.AccountG)
                  .WithOne(p => p.VitalSignLatest)
                  .HasForeignKey<VitalSignLatest>(d => d.AccountGid);
      });
      modelBuilder.Entity<OrganizationKioskVideo>(entity =>
      {
        entity.HasKey(e => new { e.OrganizationId, e.FileId });
        entity.Property(e => e.OrganizationId);
        entity.Property(e => e.FileId);

        entity.HasOne(d => d.Organization)
        .WithMany(p => p.OrganizationKioskVideos)
        .HasForeignKey(d => d.OrganizationId);

        entity.HasOne(d => d.File)
        .WithMany(p => p.OrganizationKioskVideos)
        .HasForeignKey(d => d.FileId);


        //外來鍵設定
      });

      // Methods
      //提供簡單的API介面，以定義實體的形狀、實體之間的關聯性，以及它們如何對應至資料庫。
      OnModelCreatingPartial(modelBuilder);
    }



    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
  }
}
