using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmAddressing
    {
        public int AddressingId { get; set; }
        public int MasterId { get; set; }
        public int TypeId { get; set; }
        public string PreTel { get; set; }
        public string Tel { get; set; }
        public string TelUpTo { get; set; }
        public string TelDesc { get; set; }
        public string Mobile { get; set; }
        public string Fax { get; set; }
        public int? CountryId { get; set; }
        public int? ProvinceId { get; set; }
        public int? CityId { get; set; }
        public string Address { get; set; }
        public string AddressDesc { get; set; }
        public string ZipCode { get; set; }
        public string PostBox { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }
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
        public virtual CrmAddressingType Type { get; set; }
        public virtual Users User { get; set; }
    }
}
