namespace DB.EnumFields
{
  public enum ShopTransactionType
  {
    /// <summary>
    /// 存入
    /// </summary>
    Deposit = 1,
    /// <summary>
    /// 提出
    /// </summary>
    Withdrawal = 2
  }

  public enum ShopTokenReason
  {
    /// <summary>
    /// 未特別指明原因
    /// </summary>
    Unknown = 0,
    /// <summary>
    /// 兌換商品
    /// </summary>
    ExchangeItem = 1,
    /// <summary>
    /// 取消兌換商品
    /// </summary>
    CancelExchangeItem = -1,
    /// <summary>
    /// 首次使用
    /// </summary>
    FirstUse = 10,
    ///// <summary>
    ///// 透過一卡通或悠遊卡成功註冊
    ///// </summary>
    //FillCardNo = 11,
    /// <summary>
    /// 透過健保卡成功註冊
    /// </summary>
    FillIdentityNo = 12,
    /// <summary>
    /// 完善個資 姓名 手機號碼 Email 地址
    /// </summary>
    FillProfile = 13,
    /// <summary>
    /// 每日VitalSign
    /// </summary>
    DailyVitalSign = 20,
    /// <summary>
    /// 當月使用線上量表，每種量表填寫完成一個月最多算1次
    /// </summary>
    MonthSurvey = 21,
    /// <summary>
    /// 當月使用線上滿意度調查表1次，一個月最多算1次
    /// </summary>
    MonthSatisfaction = 22,
    /// <summary>
    /// 每月獎勵 量測達5次
    /// </summary>
    BonusMonth5 = 30,
    /// <summary>
    /// 每月獎勵 量測達10次
    /// </summary>
    BonusMonth10 = 31,
    /// <summary>
    /// 每月獎勵 量測達20次
    /// </summary>
    BonusMonth20 = 32,
    /// <summary>
    /// 每月獎勵 量測達30次
    /// </summary>
    BonusMonth30 = 33,
    /// <summary>
    /// 每季獎勵 量測達15
    /// </summary>
    BonusSeason15 = 40,
    /// <summary>
    /// 每季獎勵 量測達30
    /// </summary>
    BonusSeason30 = 41,
    /// <summary>
    /// 每季獎勵 量測達60
    /// </summary>
    BonusSeason60 = 42,
    /// <summary>
    /// 每季獎勵 量測達90
    /// </summary>
    BonusSeason90 = 43,
    /// <summary>
    /// 還原並清空點數
    /// </summary>
    BonusReset = 99
  }

  public enum ShopTokenType
  {
    /// <summary>
    /// 健康福利點
    /// </summary>
    HealthPoint = 0,
    /// <summary>
    /// 時分券
    /// </summary>
    TimeToken = 1
  }

  public enum ShopProductShipment
  {
    Unknown = 0,
    //郵寄
    ByMail = 1,
    //面交
    InPerson = 2
  }

  public enum ShopProductStatus
  {
    /// <summary>
    /// 上架
    /// </summary>
    Sale = 0,
    /// <summary>
    /// 待上架
    /// </summary>
    Waiting = 10,
    /// <summary>
    /// 下架
    /// </summary>
    NotSale = 20,
    /// <summary>
    /// 假刪除
    /// </summary>
    Delete = 30,
  }

  public enum ShopPurchaseLogType
  {
    /// <summary>
    /// 訂單
    /// </summary>
    Order = 0,
    /// <summary>
    /// 核銷
    /// </summary>
    WriteOff = 10,
    /// <summary>
    /// 已取消
    /// </summary>
    Cancel = 20,
    /// <summary>
    /// 付款未完成
    /// </summary>
    PayUnfinished = 30,
  }

  public enum ProductStatusAfterSaleType
  {
    /// <summary>
    /// 可以兌換的
    /// </summary>
    OK = 0,
    /// <summary>
    /// 時間未到不能換
    /// </summary>
    NotYet = 10,
    /// <summary>
    /// 數量0，被換完
    /// </summary>
    IsOver = 20,
    /// <summary>
    /// 時間過了不能換了
    /// </summary>
    TooLate = 30,
    /// <summary>
    /// 還沒上架拉
    /// </summary>
    IsNotSale = 40,
    /// <summary>
    /// notFount
    /// </summary>
    ItemNotFound = 50
  }

  public enum TokenCostType
  {
    /// <summary>
    /// 扣點成功
    /// </summary>
    OK = 0,
    /// <summary>
    /// 已達每人最高兌換次數
    /// </summary>
    NoMoreForYou = 10,
    /// <summary>
    /// 商品剩餘量不足
    /// </summary>
    ProductRemainShortage = 20,
    /// <summary>
    /// 帳號紅利點數不足
    /// </summary>
    AccountPointShortage = 30,
    /// <summary>
    /// 商品數量小於1
    /// </summary>
    AmountError = 40,

  }
}
