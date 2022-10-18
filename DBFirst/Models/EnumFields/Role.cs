using System;
using System.ComponentModel.DataAnnotations;

namespace DB.EnumFields
{
  /// <summary>
  /// 角色類型
  /// </summary>
  public enum RoleType
  {
    /// <summary>
    /// 系統管理者 
    /// </summary>
    [Display(Name = "SysAdmin")]
    SysAdmin = 1,
    /// <summary>
    /// 機構管理者 
    /// </summary>
    [Display(Name = "OrgAdmin")]
    OrgAdmin = 2,
    /// <summary>
    /// 機構醫師
    /// </summary>
    [Display(Name = "OrgDoctor")]
    OrgDoctor = 3,
    /// <summary>
    /// 機構護理師/個管師/志工
    /// </summary>
    [Display(Name = "OrgVolunteer")]
    OrgVolunteer = 4,
    /// <summary>
    /// 一般使用者
    /// </summary>
    [Display(Name = "Member")]
    Member = 5,
    /// <summary>
    /// mphrShop核銷人員
    /// </summary>
    [Display(Name = "ShopWriteOff")]
    ShopWriteOff = 6,
  }

  /// <summary>
  /// 對應menu_all.xml的key
  /// </summary>
  public enum PagePermissionKey
  {
    A001, A003, A010,
    B001, B002, B003,
    C001, C002, C003,
    D001, D002, D003,
    E001, E010, E020, E040, E041, E050,
    F001, F002, F003, F004, F005, F006, F007,
    G001, G002, G003, G004, G005, G006, G007,
    H001,
    Q001, Q002, Q003,
    Z001, Z002, Z003, Z004, Z005, Z006, Z007, Z008, Z011,
    //個人資料
    P001
  }

  [Flags]
  public enum RoleAuthType
  {
    SysAdmin = 1 << RoleType.SysAdmin,
    OrgAdmin = 1 << RoleType.OrgAdmin,
    OrgDoctor = 1 << RoleType.OrgDoctor,
    OrgVolunteer = 1 << RoleType.OrgVolunteer,
    Member = 1 << RoleType.Member,
  }

  /// <summary>
  /// 將 RoleType 映射為 RoleAuthType
  /// </summary>
  public static class RoleTypeExtention
  {
    public static RoleAuthType ConverToRoleAuthType(this RoleType roleType)
    {
      return (RoleAuthType)(1 << (int)roleType);
    }
  }
}
