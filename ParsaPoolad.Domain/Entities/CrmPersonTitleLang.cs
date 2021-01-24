﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmPersonTitleLang
    {
        public int CrmPersonTitleLangId { get; set; }
        public int PersonTitleId { get; set; }
        public int LanguageId { get; set; }
        public string PersonTitle { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmPersonTitle PersonTitleNavigation { get; set; }
    }
}
