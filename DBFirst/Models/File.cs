using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
  public partial class File
  {
    public File()
    {
      
    }

    public int Id { get; set; }
    public string? Name { get; set; }
    public string FileName { get; set; } = null!;
    public string? FileUrl { get; set; }
    public double Size { get; set; }
    public int Type { get; set; }
    public string Source { get; set; } = null!;
    public bool Enabled { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid UpdatedBy { get; set; }
    public int OrganizationId { get; set; }
    public string? ExternalLink { get; set; }
    public string? ExternalLinkName { get; set; }
    public string? OriginId { get; set; }
    public int AccessType { get; set; }
    public string? ImageHash { get; set; }
    public int? Order { get; set; }

    public virtual Organization Organization { get; set; } = null!;

    //include a collection navigation property
    public virtual ICollection<OrganizationKioskVideo>? OrganizationKioskVideos { get; set; }
  }
}
