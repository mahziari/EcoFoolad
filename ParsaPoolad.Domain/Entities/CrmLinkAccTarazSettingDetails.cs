﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmLinkAccTarazSettingDetails
    {
        public CrmLinkAccTarazSettingDetails()
        {
            CrmLinkAccTarazSettingDetailsLang = new HashSet<CrmLinkAccTarazSettingDetailsLang>();
        }

        public int LinkAccTarazSettingDetailId { get; set; }
        public int LinkAccTarazSettingId { get; set; }
        public int? ObjectId { get; set; }
        public string PartField { get; set; }
        public string PartValue { get; set; }
        public string Description { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmLinkAccTarazSetting LinkAccTarazSetting { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingDetailsLang> CrmLinkAccTarazSettingDetailsLang { get; set; }
    }
}
