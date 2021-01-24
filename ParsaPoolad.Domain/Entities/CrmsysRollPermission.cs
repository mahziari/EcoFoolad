using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class CrmsysRollPermission
    {
        public int Id { get; set; }
        public int RollId { get; set; }
        public int FormId { get; set; }
        public int? FormActionId { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmsysForms Form { get; set; }
        public virtual CrmsysFormActions FormAction { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmsysRolls Roll { get; set; }
    }
}
