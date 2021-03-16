using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities.IdealCrm
{
    public partial class CrmFoSetting
    {
        public CrmFoSetting()
        {
            CrmFoSettingLang = new HashSet<CrmFoSettingLang>();
        }

        public int FoSettingId { get; set; }
        public int? CmpDefaultGroupId { get; set; }
        public int? CmpDefaultSubGroupId { get; set; }
        public int? CmpDefaultGroupIdIi { get; set; }
        public int? CmpDefaultGroupIdIii { get; set; }
        public int? CmpDefaultGroupIdIv { get; set; }
        public int? CmpDefaultTypeId { get; set; }
        public int? CmpDefaultPresentationId { get; set; }
        public int CmpDefaultReferUserId { get; set; }
        public string PrjDefaultTitle { get; set; }
        public int PrjDefaultStarterUserId { get; set; }
        public int? PrjDefaultGradeId { get; set; }
        public int? PrjDefaultPriorityId { get; set; }
        public int? PrjDefaultGroupId { get; set; }
        public int PrjDefaultCnvsStatusGroupId { get; set; }
        public string PrjDefaultPostFix { get; set; }
        public bool? PrjDefaultFocmpCanSee { get; set; }
        public bool? PrjInsertCrmProjectsForbiddenFufdpactive { get; set; }
        public bool? PrjInsertProjectInformationsDefualtFieldActive { get; set; }
        public int CnvsDefaultTopicId { get; set; }
        public string CnvsDefaultDesc { get; set; }
        public int CnvsDefaultUserId { get; set; }
        public int CnvsDefaultReferUserId { get; set; }
        public string CnvsDefaultReferDesc { get; set; }
        public int CnvsDefaultStatusId { get; set; }
        public int? CnvsDefaultPriorityId { get; set; }
        public bool? EmailSendingIsActive { get; set; }
        public int? EmailSettingId { get; set; }
        public int? EmailUserInfoId { get; set; }
        public string EmailSubjectPatternFormula { get; set; }
        public string EmailBodyPatternFormula { get; set; }
        public bool? SmsSendingIsActive { get; set; }
        public string SmsWebServiceUserName { get; set; }
        public string SmsWebServicePassword { get; set; }
        public string SmsWebServiceNumber { get; set; }
        public string SmsWebServiceUrl { get; set; }
        public string SmsBodyPatternFormula { get; set; }
        public string FoLogEmailAdminI { get; set; }
        public string FoLogEmailAdminIi { get; set; }
        public int FirstRegisterUserId { get; set; }
        public DateTime FirstRegisterDate { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public int UserId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int LanguageId { get; set; }
        public string CnvsDescTooltip { get; set; }
        public string TicketDescTooltip { get; set; }
        public bool? PrdPriceVisible { get; set; }
        public int? PrdDisplayType { get; set; }
        public bool? TicketSubjSelectLoadDefaultContext { get; set; }
        public string TicketSubjectDefaultContext { get; set; }
        public string LoginTitle { get; set; }
        public string LoginFormTitle { get; set; }
        public string LoginBgImagePath { get; set; }
        public string LoginBgColor { get; set; }
        public string LoginBtnBgColor { get; set; }
        public string LoginBtnFontColor { get; set; }
        public string LoginLinkColor { get; set; }
        public string LoginRegLinkTitle { get; set; }
        public int? LoginPosition { get; set; }
        public string LoginTextBorderFcolor { get; set; }
        public string LoginTextBorderTcolor { get; set; }
        public string RegTitle { get; set; }
        public string RegFormTitle { get; set; }
        public string RegBgImagePath { get; set; }
        public string RegBgColor { get; set; }
        public string RegBtnBgColor { get; set; }
        public string RegBtnFontColor { get; set; }
        public string RegLinkColor { get; set; }
        public string RegLoginLinkTitle { get; set; }
        public int? RegPosition { get; set; }
        public string RegTextBorderFcolor { get; set; }
        public string RegTextBorderTcolor { get; set; }
        public int? RegDyFormId { get; set; }
        public bool? ShpSidebarMenuVisible { get; set; }
        public string ShpLogoPathWidth110 { get; set; }
        public string ShpLogoPathWidth215 { get; set; }
        public int? ShpHomeGalleryIid { get; set; }
        public int? ShpHomeGalleryIiid { get; set; }
        public int? ShpHomeGalleryIiiid { get; set; }
        public string ShpHomeTopHeaderBgColor { get; set; }
        public string ShpHomeTopHeaderFontColor { get; set; }
        public string ShpHomePrdPartTitle { get; set; }
        public bool? PrdFcrvisible { get; set; }
        public bool? PrdPriceWithFcrvisible { get; set; }
        public bool? PrdPriceInDecimalVisible { get; set; }
        public bool? SmsSendByWeb { get; set; }
        public bool? SmsSendByGsm { get; set; }

        public virtual CrmCompanyGroups CmpDefaultGroup { get; set; }
        public virtual CrmCompanyGroupsIi CmpDefaultGroupIdIiNavigation { get; set; }
        public virtual CrmCompanyGroupsIii CmpDefaultGroupIdIiiNavigation { get; set; }
        public virtual CrmCompanyGroupsIv CmpDefaultGroupIdIvNavigation { get; set; }
        public virtual CrmCompanyPresentation CmpDefaultPresentation { get; set; }
        public virtual Users CmpDefaultReferUser { get; set; }
        public virtual CrmCompanySubGroups CmpDefaultSubGroup { get; set; }
        public virtual CrmCompanyType CmpDefaultType { get; set; }
        public virtual CrmConversationPriority CnvsDefaultPriority { get; set; }
        public virtual Users CnvsDefaultReferUser { get; set; }
        public virtual CrmConversationStatus CnvsDefaultStatus { get; set; }
        public virtual CrmConversationTopics CnvsDefaultTopic { get; set; }
        public virtual Users CnvsDefaultUser { get; set; }
        public virtual EmailSetting EmailSetting { get; set; }
        public virtual EmailUsersInfo EmailUserInfo { get; set; }
        public virtual Users FirstRegisterUser { get; set; }
        public virtual Languages Language { get; set; }
        public virtual CrmConversationStatusGroups PrjDefaultCnvsStatusGroup { get; set; }
        public virtual CrmProjectGrade PrjDefaultGrade { get; set; }
        public virtual CrmProjectGroups PrjDefaultGroup { get; set; }
        public virtual CrmProjectPriority PrjDefaultPriority { get; set; }
        public virtual Users PrjDefaultStarterUser { get; set; }
        public virtual CrmDyForms RegDyForm { get; set; }
        public virtual CrmCmsGallery ShpHomeGalleryI { get; set; }
        public virtual CrmCmsGallery ShpHomeGalleryIi { get; set; }
        public virtual CrmCmsGallery ShpHomeGalleryIii { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<CrmFoSettingLang> CrmFoSettingLang { get; set; }
    }
}
