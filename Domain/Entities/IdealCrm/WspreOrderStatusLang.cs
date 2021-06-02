using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WspreOrderStatusLang
    {
        public int WspreOrderStatusLangId { get; set; }
        public int PreOrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string PreOrderStatus { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderStatus PreOrderStatusNavigation { get; set; }
    }
}
