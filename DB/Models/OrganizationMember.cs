
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class OrganizationMember
  {
    public int Id { get; set; }
    public int OrganizationId { get; set; }
    public string MemberName { get; set; }
    public string MemberIntroduction { get; set; }
    public int? MemberPhotoId { get; set; }
    public int DisplayOrder { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    #region 關聯

    [ForeignKey("OrganizationId")]
    public virtual Organization Organization { get; set; }

    #endregion
  }
}
