﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class SmsDefaultBodyTextGroupsLang
    {
        public int SmsDefaultBodyTextGroupsLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }

        public virtual SmsDefaultBodyTextGroups IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
