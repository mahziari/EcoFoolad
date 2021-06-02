using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class Wsdoc
    {
        public Wsdoc()
        {
            WsdocItems = new HashSet<WsdocItems>();
            WsdocLang = new HashSet<WsdocLang>();
        }

        public int DocId { get; set; }
        public int OprId { get; set; }
        public int DocNumber { get; set; }
        public string DocDate { get; set; }
        public int? SenderId { get; set; }
        public string SenderName { get; set; }
        public string FactorNumber { get; set; }
        public string Description { get; set; }
        public short? IsFix { get; set; }
        public int Whid { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Month1 { get; set; }
        public int Fpid { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? OrderId { get; set; }
        public Guid? Guid { get; set; }
        public int? BuyOrderId { get; set; }
        public string SendAddress { get; set; }
        public string DriverName { get; set; }
        public string DriverTel { get; set; }
        public string FreightName { get; set; }
        public string BijakNumber { get; set; }
        public string CarNumber { get; set; }
        public DateTime? DocDateTime { get; set; }
        public int? WhidI { get; set; }
        public int? CompanyId { get; set; }
        public int? CompanyPersonId { get; set; }
        public int? ProjectId { get; set; }
        public string CmpTitle { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? DocLinkAccCodeId { get; set; }
        public string DocLinkAccCode { get; set; }
        public int? DocLinkAccDocId { get; set; }
        public string DocLinkAccDocNumber { get; set; }
        public int? DocLinkAccVoucherId { get; set; }
        public string DocLinkAccVoucherNumber { get; set; }

        public virtual WsbuyOrder BuyOrder { get; set; }
        public virtual CrmCompany Company { get; set; }
        public virtual CrmCompanyPersons CompanyPerson { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual WsfinancialPeriod Fp { get; set; }
        public virtual Languages Language { get; set; }
        public virtual WsdocOpr Opr { get; set; }
        public virtual Wsorder Order { get; set; }
        public virtual CrmProjects Project { get; set; }
        public virtual Users User { get; set; }
        public virtual WsWareHouse Wh { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<WsdocLang> WsdocLang { get; set; }
    }
}
