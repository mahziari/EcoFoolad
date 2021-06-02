using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class SmsDeliveryStatusLang
    {
        public int SmsDeliveryStatusLangId { get; set; }
        public int Id { get; set; }
        public int LanguageId { get; set; }
        public string DeliveryStatus { get; set; }

        public virtual SmsDeliveryStatus IdNavigation { get; set; }
        public virtual Languages Language { get; set; }
    }
}
