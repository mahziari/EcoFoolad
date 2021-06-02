﻿using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmLeave
    {
        public int LeaveId { get; set; }
        public int? LeaveTypeId { get; set; }
        public int? RequestUserId { get; set; }
        public int? ReplaceUserId { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int? DayCount { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string HourCount { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public int? KindId { get; set; }
        public string Place { get; set; }
        public int? CompanyId { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public int? VehicleTypeId { get; set; }
        public int? StayTypeId { get; set; }
        public int? LeaveStatusId { get; set; }
        public int? VerifierUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
