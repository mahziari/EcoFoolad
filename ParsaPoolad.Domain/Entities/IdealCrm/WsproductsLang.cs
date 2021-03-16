using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductsLang
    {
        public int WsproductsLangId { get; set; }
        public int ProductId { get; set; }
        public int LanguageId { get; set; }
        public string PrdName { get; set; }
        public string PrdLatinName { get; set; }
        public string PrdType { get; set; }
        public string PrdDesign { get; set; }
        public string PrdSize { get; set; }
        public string PrdDescription { get; set; }
        public string PrdModel { get; set; }
        public string PrdShptitle { get; set; }
        public string PrdShpmodel { get; set; }
        public string PrdShpdescription { get; set; }
        public string PrdShpdescriptionIi { get; set; }

        public virtual Languages Language { get; set; }
        public virtual Wsproducts Product { get; set; }
    }
}
