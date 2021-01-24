using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmShowTableFieldInFo
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public int? TableId { get; set; }
        public string FieldName { get; set; }
        public bool? Visible { get; set; }
        public int? OrderView { get; set; }
        public bool? IsActive { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public int FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid? Guid { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
