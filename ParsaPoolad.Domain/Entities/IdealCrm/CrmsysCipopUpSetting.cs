﻿using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmsysCipopUpSetting
    {
        public int CipopUpSettingId { get; set; }
        public bool IsActive { get; set; }
        public string SettingTitle { get; set; }
        public bool? UseClientNameForNetworking { get; set; }
        public bool? PopUpDeActive { get; set; }
        public bool? PopUpWinFormIdeActive { get; set; }
        public bool? PopUpDeActiveForUnknownNumber { get; set; }
        public bool? PopUpJustForcmpReferUser { get; set; }
        public bool? PopUpJustForcmpReferUserAndLinked { get; set; }
        public string PatternFormulaPopUp { get; set; }
        public string PatternForLineNumber { get; set; }
        public string PatternForCallTime { get; set; }
        public string PatternForPhoneNumber { get; set; }
        public string PatternForcmpName { get; set; }
        public string PatternForcmpPrsName { get; set; }
        public string PatternForPhoneName { get; set; }
        public string PatternForLastcnvscmpPerson { get; set; }
        public string PatternForLastProject { get; set; }
        public string PatternForLastcnvsRefUser { get; set; }
        public string PatternForLastcnvsStatus { get; set; }
        public string PatternForcmpReferUser { get; set; }
        public string PatternForcmpActivityType { get; set; }
        public string PatternForcmpCountry { get; set; }
        public string PatternForcmpProvince { get; set; }
        public string PatternForcmpCity { get; set; }
        public string PatternForcmpPresentation { get; set; }
        public string PatternForcmpCompanyType { get; set; }
        public string PatternForcmpCompanyGroup { get; set; }
        public string PatternForcmpSubGroupName { get; set; }
        public string PatternForcmpCompanyGroupIi { get; set; }
        public string PatternForcmpCompanyGroupIii { get; set; }
        public string PatternForcmpCompanyGroupIv { get; set; }
        public string PatternForcmpCiword { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int FirstRegisterUserId { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public Guid Guid { get; set; }
        public string AppType { get; set; }
        public int? LanguageId { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users User { get; set; }
    }
}
