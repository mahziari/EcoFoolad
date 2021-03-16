using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductCostGroup
    {
        public WsproductCostGroup()
        {
            WsproductCost = new HashSet<WsproductCost>();
            WsproductCostGroupLang = new HashSet<WsproductCostGroupLang>();
            WsproductImportFromExcel = new HashSet<WsproductImportFromExcel>();
        }

        public int ProductCostGroupId { get; set; }
        public string ProductCostGroupName { get; set; }
        public string ProductCostGroupDesc { get; set; }
        public int? OrderView { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductCostGroupLang> WsproductCostGroupLang { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcel { get; set; }
    }
}
