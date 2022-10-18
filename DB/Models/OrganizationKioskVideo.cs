using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using NuGet.ProjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.DotNet.ProjectModel.Graph;

namespace DB.Models
{
  /// <summary>
  /// 機構與可見的Kiosk影片
  /// </summary>
  public class OrganizationKioskVideo
  {
    
    public int OrganizationId { get; set; }
    public int FileId { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }
    [ForeignKey("FileId")]
    public virtual File File { get; set; }
    
    #endregion
  }

  class hasKey1
  {
    ModelBuilder.Entity<OrganizationKioskVideo>(BuildAction: EntityTypeBuilder<OrganizationKioskVideo> Entity =>
      {
      entity.HasKey(OrganizationKioskVideo keyExpression: e => new { e.OrganizationId.e.FileId});
    });
}
