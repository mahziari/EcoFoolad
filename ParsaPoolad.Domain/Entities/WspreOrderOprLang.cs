using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WspreOrderOprLang
    {
        public int WspreOrderOprLangId { get; set; }
        public int PreOrderOprId { get; set; }
        public int? LanguageId { get; set; }
        public string PreOrderOpr { get; set; }
        public string Description { get; set; }

        public virtual Languages Language { get; set; }
        public virtual WspreOrderOpr PreOrderOprNavigation { get; set; }
    }
}
