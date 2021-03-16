using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductColor
    {
        public WsproductColor()
        {
            WsproductColorLang = new HashSet<WsproductColorLang>();
            WsproductImportFromExcel = new HashSet<WsproductImportFromExcel>();
            Wsproducts = new HashSet<Wsproducts>();
        }

        public int ProductColorId { get; set; }
        public string Color { get; set; }
        public string ColorDescription { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string ColorEn { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsproductColorLang> WsproductColorLang { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcel { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
    }
}
