using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsdocLang
    {
        public int WsdocLangId { get; set; }
        public int DocId { get; set; }
        public int LanguageId { get; set; }
        public string SenderName { get; set; }
        public string Description { get; set; }
        public string SendAddress { get; set; }
        public string DriverName { get; set; }
        public string FreightName { get; set; }
        public string CmpTitle { get; set; }

        public virtual Wsdoc Doc { get; set; }
        public virtual Languages Language { get; set; }
    }
}
