using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class PrintFormatType
    {
        public PrintFormatType()
        {
            PrintFormat = new HashSet<PrintFormat>();
            PrintFormatTypeLang = new HashSet<PrintFormatTypeLang>();
        }

        public int PrintFormatTypeId { get; set; }
        public string PrintFormatType1 { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
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
        public virtual ICollection<PrintFormat> PrintFormat { get; set; }
        public virtual ICollection<PrintFormatTypeLang> PrintFormatTypeLang { get; set; }
    }
}
