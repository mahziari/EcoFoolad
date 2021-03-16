using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class WsproductsRate
    {
        public int ProductRateId { get; set; }
        public int PrdId { get; set; }
        public int StarRate { get; set; }
        public int? CrmCompanyId { get; set; }
        public string Ipaddress { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int? UserId { get; set; }
        public int Fpid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual CrmCompany CrmCompany { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Wsproducts Prd { get; set; }
        public virtual Users User { get; set; }
    }
}
