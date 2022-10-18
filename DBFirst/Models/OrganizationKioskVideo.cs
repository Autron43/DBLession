using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBFirst.Models
{ 
  /// <summary>
  /// 機構與可見的Kiosk影片
  /// </summary> 
  public class OrganizationKioskVideo
  {

    #region 關聯
    public int OrganizationId { get; set; }
    public int FileId { get; set; }

    [ForeignKey("OrganizationId")]
    public virtual Organization? Organization { get; set; }
    [ForeignKey("FileId")]
    public virtual File? File { get; set; }

    #endregion
  }
}