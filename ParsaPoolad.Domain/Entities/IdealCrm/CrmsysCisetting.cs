using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysCisetting
    {
        public int Id { get; set; }
        public string DeviceName { get; set; }
        public string ComPort { get; set; }
        public string ComSetting { get; set; }
        public int? StartLineNumber { get; set; }
        public string CiserverIp { get; set; }
        public string SrvName { get; set; }
        public string Dbname { get; set; }
        public string Suser { get; set; }
        public string Spass { get; set; }
        public bool? IsActive { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? DeviceTypeId { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual CrmsysCideviceType DeviceType { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
