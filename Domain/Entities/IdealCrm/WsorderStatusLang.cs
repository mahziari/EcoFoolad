using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsorderStatusLang
    {
        public int WsorderStatusLangId { get; set; }
        public int OrderStatusId { get; set; }
        public int LanguageId { get; set; }
        public string OrderStatus { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsorderStatus OrderStatusNavigation { get; set; }
    }
}
