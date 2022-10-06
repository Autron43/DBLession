
using mPHR.Services.Database.EnumFields;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mPHR.Services.Database.Models
{
  public class ShopReceiverInfo
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 帳號GID
    /// </summary>
    public Guid AccountGid { get; set; }

    /// <summary>
    /// 收件者姓名
    /// </summary>
    public string ReceiverName { get; set; }

    /// <summary>
    /// 收件者地址
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// 收件者電話
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// 寄送方式
    /// </summary>
    public ShopProductShipment Shipment { get; set; }

    /// <summary>
    /// 是否為預設
    /// </summary>
    public bool Default { get; set; }

    /// <summary>
    /// 購買紀錄Id
    /// </summary>
    public int ShopPurchaseLogId { get; set; }

    /// <summary>
    /// 建立日期
    /// </summary>
    public DateTime CreatedAt { get; set; }

    public Guid CreatedBy { get; set; }

    public DateTime UpdatedAt { get; set; }

    public Guid UpdateBy { get; set; }

    #region 關聯欄位

    [ForeignKey("ShopPurchaseLogId")]
    public virtual ShopPurchaseLog ShopPurchaseLog { get; set; }

    #endregion
  }
}
