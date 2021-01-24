﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmInternalMessageGroupLang
    {
        public int CrmInternalMessageGroupLangId { get; set; }
        public int InternalMessageGroupId { get; set; }
        public int LanguageId { get; set; }
        public string InternalMessageGroup { get; set; }

        public virtual CrmInternalMessageGroup InternalMessageGroupNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
