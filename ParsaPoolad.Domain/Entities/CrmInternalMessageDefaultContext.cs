﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmInternalMessageDefaultContext
    {
        public CrmInternalMessageDefaultContext()
        {
            CrmInternalMessageDefaultContextLang = new HashSet<CrmInternalMessageDefaultContextLang>();
        }

        public int InternalMessageDefaultContextId { get; set; }
        public int ContextUserId { get; set; }
        public string Col1 { get; set; }
        public string Col2 { get; set; }
        public string Col3 { get; set; }
        public string Col4 { get; set; }
        public string Col5 { get; set; }
        public string Col6 { get; set; }
        public string Col7 { get; set; }
        public string Col8 { get; set; }
        public string Col9 { get; set; }
        public string Col10 { get; set; }
        public string Col11 { get; set; }
        public string Col12 { get; set; }
        public string Col13 { get; set; }
        public string Col14 { get; set; }
        public string Col15 { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmInternalMessageDefaultContextLang> CrmInternalMessageDefaultContextLang { get; set; }
    }
}
