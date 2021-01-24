using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SmsGsmmodemSetting
    {
        public int Id { get; set; }
        public string Mode { get; set; }
        public string Protocol { get; set; }
        public string Parameter { get; set; }
        public string PinCode { get; set; }
        public bool? ConcatenatedSms { get; set; }
        public bool? FlashSms { get; set; }
        public bool? RequestSendReport { get; set; }
        public bool? AutoDeleteNewSms { get; set; }
        public bool? AutoDeleteAllReports { get; set; }
        public int? RetryTimes { get; set; }
        public int? SendInterval { get; set; }
        public int? SendTimeout { get; set; }
        public string Message { get; set; }
        public bool? SendWithDelay { get; set; }
        public int? DelayTime { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string SimNumber { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public bool? SendingIsActive { get; set; }
        public bool? LineIsActive { get; set; }
        public string DeviceName { get; set; }
        public string GsmManufacturer { get; set; }
        public string GsmModel { get; set; }
        public string GsmImei { get; set; }
        public string GsmNetworkInfo { get; set; }
        public string GsmBatteryLevel { get; set; }
        public string GsmSignalLevel { get; set; }
        public string GsmFirmware { get; set; }
        public string GsmHardware { get; set; }
        public string GsmTime { get; set; }
        public string GsmSmscnumber { get; set; }
        public string ConnectStatus { get; set; }
        public string LastSendError { get; set; }
        public int? SendStop { get; set; }
        public string SendFtime { get; set; }
        public string SendTtime { get; set; }
        public int? DeviceUniqeOrderIdForServiceSelect { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
