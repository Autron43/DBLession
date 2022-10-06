using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
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
}
