using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class ProvinceLang
    {
        public int ProvinceLangId { get; set; }
        public int LanguageId { get; set; }
        public int ProvinceId { get; set; }
        public string Province { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Province ProvinceNavigation { get; set; }
    }
}
