using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmUserNotes
    {
        public int NoteId { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string Note1 { get; set; }
        public string Note2 { get; set; }
        public string Note3 { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
