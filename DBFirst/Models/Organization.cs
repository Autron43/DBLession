using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
  public partial class Organization
  {
    public Organization()
    {
      Accounts = new HashSet<Account>();
      CourseCategories = new HashSet<CourseCategory>();
      Courses = new HashSet<Course>();
      Events = new HashSet<Event>();
      Files = new HashSet<File>();
      Labels = new HashSet<Label>();
      LinePhrases = new HashSet<LinePhrase>();
      Machines = new HashSet<Machine>();
      OrganizationMembers = new HashSet<OrganizationMember>();
      OrganizationMessages = new HashSet<OrganizationMessage>();
      OrganizeAuthorizations = new HashSet<OrganizeAuthorization>();
      OrganizeGroups = new HashSet<OrganizeGroup>();
      PatientGroups = new HashSet<PatientGroup>();
      ProductSerials = new HashSet<ProductSerial>();
      QuestionnaireOrganizes = new HashSet<QuestionnaireOrganize>();
      Roles = new HashSet<Role>();
      Scripts = new HashSet<Script>();
      SmsPhrases = new HashSet<SmsPhrase>();
      VideoConCalls = new HashSet<VideoConCall>();
      FilesNavigation = new HashSet<File>();
    }

    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string? CompanyId { get; set; }
    public string? Code { get; set; }
    public string? Tel { get; set; }
    public string? Mobile { get; set; }
    public string? Address { get; set; }
    public string? Owner { get; set; }
    public string? Email { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public int? SmsSupplierId { get; set; }
    public string? Introduction { get; set; }
    public string? OfficialWebsite { get; set; }
    public string? ServiceTitle { get; set; }

    public virtual SmsSupplier? SmsSupplier { get; set; }
    public virtual OrganizeConfig? OrganizeConfig { get; set; }

    public virtual ICollection<Account> Accounts { get; set; }
    public virtual ICollection<CourseCategory> CourseCategories { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
    public virtual ICollection<Event> Events { get; set; }
    public virtual ICollection<File> Files { get; set; }
    public virtual ICollection<Label> Labels { get; set; }
    public virtual ICollection<LinePhrase> LinePhrases { get; set; }
    public virtual ICollection<Machine> Machines { get; set; }
    public virtual ICollection<OrganizationMember> OrganizationMembers { get; set; }
    public virtual ICollection<OrganizationMessage> OrganizationMessages { get; set; }
    public virtual ICollection<OrganizeAuthorization> OrganizeAuthorizations { get; set; }
    public virtual ICollection<OrganizeGroup> OrganizeGroups { get; set; }
    public virtual ICollection<PatientGroup> PatientGroups { get; set; }
    public virtual ICollection<ProductSerial> ProductSerials { get; set; }
    public virtual ICollection<QuestionnaireOrganize> QuestionnaireOrganizes { get; set; }
    public virtual ICollection<Role> Roles { get; set; }
    public virtual ICollection<Script> Scripts { get; set; }
    public virtual ICollection<SmsPhrase> SmsPhrases { get; set; }
    public virtual ICollection<VideoConCall> VideoConCalls { get; set; }

    public virtual ICollection<File> FilesNavigation { get; set; }

    //include a collection navigation property
    public virtual ICollection<OrganizationKioskVideo>? OrganizationKioskVideos { get; set; }


  }
}
