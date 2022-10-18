namespace DB.EnumFields
{
  public enum OrganizationLineNotifyType
  {
    LineNotify = 0,
    ChannelPush = 1
  }

  public enum LineSessionStatus
  {
    Binding = 0,
    Register = 1,
    VitalSign = 2,
    ImageUploadAtk = 3,
    AddContactPerson = 4
  }

  public enum TainanUserCovidStatus
  {
    Normal = 0,
    Quarantine = 1,
    PatientContact = 2
  }
}
