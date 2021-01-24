using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsdeliveryTimeLang
    {
        public int WsdeliveryTimeLangId { get; set; }
        public int DeliveryTimeId { get; set; }
        public int LanguageId { get; set; }
        public string DeliveryTime { get; set; }

        public virtual WsdeliveryTime DeliveryTimeNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
