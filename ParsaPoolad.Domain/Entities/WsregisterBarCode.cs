using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class WsregisterBarCode
    {
        public int Id { get; set; }
        public int? DocId { get; set; }
        public string BarCode { get; set; }
        public int? DocItemId { get; set; }
        public int? PrdId { get; set; }
        public string PrdName { get; set; }
        public string Description { get; set; }
        public int? BarcodeMode { get; set; }
        public int UserId { get; set; }
        public int Fpid { get; set; }
        public int Whid { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public int? Opr { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
    }
}
