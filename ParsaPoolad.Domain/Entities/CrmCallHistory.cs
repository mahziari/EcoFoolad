using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmCallHistory
    {
        public int CallHistoryId { get; set; }
        public int CallTypeId { get; set; }
        public string PhoneNumber { get; set; }
        public int? CompanyId { get; set; }
        public string CallTime { get; set; }
        public string CallDate { get; set; }
        public string CallDay { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? LineNumber { get; set; }
        public string CallerIddetectData { get; set; }
        public Guid? Guid { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Duration { get; set; }
        public int? CompanyPersonId { get; set; }
        public int? NumberEditedUserId { get; set; }
        public string Note { get; set; }
        public int? NoteRegisterUserId { get; set; }
        public int? NoteEditedUserId { get; set; }
        public string RecFileName { get; set; }
        public string AppType { get; set; }
        public string Data { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public DateTime? CallDateTime { get; set; }
        public string TrunkCallId { get; set; }
        public string TrunkName { get; set; }
        public string TrunkSource { get; set; }
        public string TrunkDestination { get; set; }
        public string TrunkFileLocation { get; set; }
        public string TrunkDestinationCycle { get; set; }
        public string PreRecFileName { get; set; }

        public virtual CrmCallType CallType { get; set; }
        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users NoteEditedUser { get; set; }
        public virtual Users NoteRegisterUser { get; set; }
        public virtual Users NumberEditedUser { get; set; }
        public virtual Users User { get; set; }
    }
}
