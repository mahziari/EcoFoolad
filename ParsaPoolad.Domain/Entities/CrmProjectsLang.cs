﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmProjectsLang
    {
        public int CrmProjectsLangId { get; set; }
        public int ProjectId { get; set; }
        public int LanguageId { get; set; }
        public string PrjTitle { get; set; }
        public string PrjDesc { get; set; }
        public string PrjPostFix { get; set; }

        public virtual Languages Language { get; set; }
        public virtual CrmProjects Project { get; set; }
    }
}
