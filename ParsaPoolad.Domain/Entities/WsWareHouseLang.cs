using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsWareHouseLang
    {
        public int WsWareHouseLangId { get; set; }
        public int WareHouseId { get; set; }
        public int LanguageId { get; set; }
        public string WrhsName { get; set; }
        public string WrhsAddress { get; set; }
        public string WrhsArea { get; set; }
        public string WrhsPerson { get; set; }
        public string WrhsDescription { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WsWareHouse WareHouse { get; set; }
    }
}
