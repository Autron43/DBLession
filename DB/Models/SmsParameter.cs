using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
  public class SmsParameter
  {
    [Key]
    public int Id { get; set; }

    /// <summary>
    /// 簡訊商Id
    /// </summary>
    [Required]
    public int SmsSupplierId { get; set; }

    /// <summary>
    /// 簡訊商發送參數鍵值
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string Key { get; set; }

    /// <summary>
    /// 簡訊商發送參數鍵值
    /// </summary>
    [Required]
    [MaxLength(20)]
    public string Value { get; set; }


    [Required]
    public int Sort { get; set; }

    [ForeignKey("SmsSupplierId")]
    public virtual SmsSupplier SmsSupplier { get; set; }
  }
}