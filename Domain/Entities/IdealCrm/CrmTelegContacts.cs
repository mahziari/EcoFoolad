﻿using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmTelegContacts
    {
        public int TelegContactId { get; set; }
        public long? ChatId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public string Title { get; set; }
        public int? UnReadMessageCount { get; set; }
        public DateTime? LastMessageDate { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyPersonId { get; set; }
        public byte[] Picture { get; set; }
        public bool? IsActive { get; set; }
        public int? UserId { get; set; }
        public short? Year1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? SettingId { get; set; }

        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmTelegSetting Setting { get; set; }
        public virtual Users User { get; set; }
    }
}
