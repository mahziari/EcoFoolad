﻿using System;
using System.Collections.Generic;

namespace  Domain.Entities.IdealCrm
{
    public partial class CrmDyFormFieldMasterValueDetails
    {
        public int FormFieldMasterValueDetailId { get; set; }
        public int MasterValueId { get; set; }
        public int FormId { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsChecked { get; set; }
        public int? CheckerUserId { get; set; }
        public DateTime? CheckedDate { get; set; }
        public string CheckedDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }

        public virtual Users CheckerUser { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual CrmDyForms Form { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmDyFormFieldMasterValues MasterValue { get; set; }
        public virtual Users User { get; set; }
    }
}
