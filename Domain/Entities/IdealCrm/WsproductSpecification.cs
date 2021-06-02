using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class WsproductSpecification
    {
        public WsproductSpecification()
        {
            WsproductSpecificationLang = new HashSet<WsproductSpecificationLang>();
        }

        public int ProductSpecificationId { get; set; }
        public int PrdId { get; set; }
        public string Specification { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }
        public string SpecificationI { get; set; }
        public string SpecificationIi { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<WsproductSpecificationLang> WsproductSpecificationLang { get; set; }
    }
}
