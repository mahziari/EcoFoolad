using System;
using System.Collections.Generic;

namespace ParsaPoolad.Domain.Entities
{
    public partial class Languages
    {
        public Languages()
        {
            City = new HashSet<City>();
            CityLang = new HashSet<CityLang>();
            Country = new HashSet<Country>();
            CountryLang = new HashSet<CountryLang>();
            CrmAddressing = new HashSet<CrmAddressing>();
            CrmAddressingType = new HashSet<CrmAddressingType>();
            CrmBankingAccountType = new HashSet<CrmBankingAccountType>();
            CrmBankingAccounts = new HashSet<CrmBankingAccounts>();
            CrmBankingBanks = new HashSet<CrmBankingBanks>();
            CrmBankingBranches = new HashSet<CrmBankingBranches>();
            CrmCallBlackList = new HashSet<CrmCallBlackList>();
            CrmCallHistory = new HashSet<CrmCallHistory>();
            CrmCallType = new HashSet<CrmCallType>();
            CrmCallTypeLang = new HashSet<CrmCallTypeLang>();
            CrmCmsComments = new HashSet<CrmCmsComments>();
            CrmCmsCommentsLang = new HashSet<CrmCmsCommentsLang>();
            CrmCmsFiles = new HashSet<CrmCmsFiles>();
            CrmCmsFilesLang = new HashSet<CrmCmsFilesLang>();
            CrmCmsGallery = new HashSet<CrmCmsGallery>();
            CrmCmsGalleryItems = new HashSet<CrmCmsGalleryItems>();
            CrmCmsGalleryItemsLang = new HashSet<CrmCmsGalleryItemsLang>();
            CrmCmsGalleryLang = new HashSet<CrmCmsGalleryLang>();
            CrmCmsLikes = new HashSet<CrmCmsLikes>();
            CrmCmsMenus = new HashSet<CrmCmsMenus>();
            CrmCmsMenusLang = new HashSet<CrmCmsMenusLang>();
            CrmCmsNews = new HashSet<CrmCmsNews>();
            CrmCmsNewsGroups = new HashSet<CrmCmsNewsGroups>();
            CrmCmsNewsGroupsLang = new HashSet<CrmCmsNewsGroupsLang>();
            CrmCmsNewsLang = new HashSet<CrmCmsNewsLang>();
            CrmCmsObjectTypes = new HashSet<CrmCmsObjectTypes>();
            CrmCmsPages = new HashSet<CrmCmsPages>();
            CrmCmsPagesLang = new HashSet<CrmCmsPagesLang>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenCity = new HashSet<CrmCompanyForbiddenCity>();
            CrmCompanyForbiddenCompany = new HashSet<CrmCompanyForbiddenCompany>();
            CrmCompanyForbiddenDepartment = new HashSet<CrmCompanyForbiddenDepartment>();
            CrmCompanyForbiddenGroup = new HashSet<CrmCompanyForbiddenGroup>();
            CrmCompanyForbiddenGroupIv = new HashSet<CrmCompanyForbiddenGroupIv>();
            CrmCompanyForbiddenProvince = new HashSet<CrmCompanyForbiddenProvince>();
            CrmCompanyForbiddenSubGroup = new HashSet<CrmCompanyForbiddenSubGroup>();
            CrmCompanyGroups = new HashSet<CrmCompanyGroups>();
            CrmCompanyGroupsIi = new HashSet<CrmCompanyGroupsIi>();
            CrmCompanyGroupsIiLang = new HashSet<CrmCompanyGroupsIiLang>();
            CrmCompanyGroupsIii = new HashSet<CrmCompanyGroupsIii>();
            CrmCompanyGroupsIiiLang = new HashSet<CrmCompanyGroupsIiiLang>();
            CrmCompanyGroupsIv = new HashSet<CrmCompanyGroupsIv>();
            CrmCompanyGroupsIvLang = new HashSet<CrmCompanyGroupsIvLang>();
            CrmCompanyGroupsLang = new HashSet<CrmCompanyGroupsLang>();
            CrmCompanyGroupsMulti = new HashSet<CrmCompanyGroupsMulti>();
            CrmCompanyGroupsMultiLang = new HashSet<CrmCompanyGroupsMultiLang>();
            CrmCompanyJustAccessCity = new HashSet<CrmCompanyJustAccessCity>();
            CrmCompanyJustAccessCompany = new HashSet<CrmCompanyJustAccessCompany>();
            CrmCompanyJustAccessDepartment = new HashSet<CrmCompanyJustAccessDepartment>();
            CrmCompanyJustAccessGroup = new HashSet<CrmCompanyJustAccessGroup>();
            CrmCompanyJustAccessGroupIv = new HashSet<CrmCompanyJustAccessGroupIv>();
            CrmCompanyJustAccessProvince = new HashSet<CrmCompanyJustAccessProvince>();
            CrmCompanyJustAccessSubGroup = new HashSet<CrmCompanyJustAccessSubGroup>();
            CrmCompanyLang = new HashSet<CrmCompanyLang>();
            CrmCompanyLoGo = new HashSet<CrmCompanyLoGo>();
            CrmCompanyMultiGroups = new HashSet<CrmCompanyMultiGroups>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsLang = new HashSet<CrmCompanyPersonsLang>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTemplateLang = new HashSet<CrmCompanyPersonsTemplateLang>();
            CrmCompanyPersonsTmp = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyPersonsTmpLang = new HashSet<CrmCompanyPersonsTmpLang>();
            CrmCompanyPictureAlbums = new HashSet<CrmCompanyPictureAlbums>();
            CrmCompanyPictures = new HashSet<CrmCompanyPictures>();
            CrmCompanyPresentation = new HashSet<CrmCompanyPresentation>();
            CrmCompanyPresentationLang = new HashSet<CrmCompanyPresentationLang>();
            CrmCompanySubGroups = new HashSet<CrmCompanySubGroups>();
            CrmCompanySubGroupsLang = new HashSet<CrmCompanySubGroupsLang>();
            CrmCompanyTitle = new HashSet<CrmCompanyTitle>();
            CrmCompanyTitleLang = new HashSet<CrmCompanyTitleLang>();
            CrmCompanyTmp = new HashSet<CrmCompanyTmp>();
            CrmCompanyTmpLang = new HashSet<CrmCompanyTmpLang>();
            CrmCompanyType = new HashSet<CrmCompanyType>();
            CrmCompanyTypeLang = new HashSet<CrmCompanyTypeLang>();
            CrmCompanyUserForbidden = new HashSet<CrmCompanyUserForbidden>();
            CrmConversation = new HashSet<CrmConversation>();
            CrmConversationDefaultContext = new HashSet<CrmConversationDefaultContext>();
            CrmConversationDefaultContextLang = new HashSet<CrmConversationDefaultContextLang>();
            CrmConversationLang = new HashSet<CrmConversationLang>();
            CrmConversationPriority = new HashSet<CrmConversationPriority>();
            CrmConversationPriorityLang = new HashSet<CrmConversationPriorityLang>();
            CrmConversationReferUsers = new HashSet<CrmConversationReferUsers>();
            CrmConversationStatus = new HashSet<CrmConversationStatus>();
            CrmConversationStatusGroups = new HashSet<CrmConversationStatusGroups>();
            CrmConversationStatusGroupsLang = new HashSet<CrmConversationStatusGroupsLang>();
            CrmConversationStatusLang = new HashSet<CrmConversationStatusLang>();
            CrmConversationTmp = new HashSet<CrmConversationTmp>();
            CrmConversationTmpLang = new HashSet<CrmConversationTmpLang>();
            CrmConversationTopics = new HashSet<CrmConversationTopics>();
            CrmConversationTopicsLang = new HashSet<CrmConversationTopicsLang>();
            CrmDyFormFieldMasterValueDetails = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldMasterValues = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldTypes = new HashSet<CrmDyFormFieldTypes>();
            CrmDyFormFieldTypesLang = new HashSet<CrmDyFormFieldTypesLang>();
            CrmDyFormFieldValues = new HashSet<CrmDyFormFieldValues>();
            CrmDyFormFieldValuesLang = new HashSet<CrmDyFormFieldValuesLang>();
            CrmDyFormFields = new HashSet<CrmDyFormFields>();
            CrmDyFormFieldsLang = new HashSet<CrmDyFormFieldsLang>();
            CrmDyFormRegularExpressions = new HashSet<CrmDyFormRegularExpressions>();
            CrmDyFormRegularExpressionsLang = new HashSet<CrmDyFormRegularExpressionsLang>();
            CrmDyFormUserAccess = new HashSet<CrmDyFormUserAccess>();
            CrmDyFormWorkflowSteps = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyFormWorkflowStepsLang = new HashSet<CrmDyFormWorkflowStepsLang>();
            CrmDyFormWorkflows = new HashSet<CrmDyFormWorkflows>();
            CrmDyFormWorkflowsLang = new HashSet<CrmDyFormWorkflowsLang>();
            CrmDyForms = new HashSet<CrmDyForms>();
            CrmDyFormsLang = new HashSet<CrmDyFormsLang>();
            CrmFileDirectoryType = new HashSet<CrmFileDirectoryType>();
            CrmFileDirectoryTypeLang = new HashSet<CrmFileDirectoryTypeLang>();
            CrmFileDirectoryTypeOpr = new HashSet<CrmFileDirectoryTypeOpr>();
            CrmFileDirectoryTypeOprLang = new HashSet<CrmFileDirectoryTypeOprLang>();
            CrmFilesDirectory = new HashSet<CrmFilesDirectory>();
            CrmFilesDirectoryLang = new HashSet<CrmFilesDirectoryLang>();
            CrmFilesDirectoryTemplate = new HashSet<CrmFilesDirectoryTemplate>();
            CrmFilesDirectoryTemplateType = new HashSet<CrmFilesDirectoryTemplateType>();
            CrmFoSetting = new HashSet<CrmFoSetting>();
            CrmFoSettingLang = new HashSet<CrmFoSettingLang>();
            CrmFund = new HashSet<CrmFund>();
            CrmFundGroups = new HashSet<CrmFundGroups>();
            CrmFundGroupsLang = new HashSet<CrmFundGroupsLang>();
            CrmFundLang = new HashSet<CrmFundLang>();
            CrmInternalMessage = new HashSet<CrmInternalMessage>();
            CrmInternalMessageDefaultContext = new HashSet<CrmInternalMessageDefaultContext>();
            CrmInternalMessageDefaultContextLang = new HashSet<CrmInternalMessageDefaultContextLang>();
            CrmInternalMessageDetails = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageGroup = new HashSet<CrmInternalMessageGroup>();
            CrmInternalMessageGroupLang = new HashSet<CrmInternalMessageGroupLang>();
            CrmInternalMessageLang = new HashSet<CrmInternalMessageLang>();
            CrmInternalMessagePriority = new HashSet<CrmInternalMessagePriority>();
            CrmInternalMessagePriorityLang = new HashSet<CrmInternalMessagePriorityLang>();
            CrmInternalMessageSelectReceiver = new HashSet<CrmInternalMessageSelectReceiver>();
            CrmInternalMessageTreeType = new HashSet<CrmInternalMessageTreeType>();
            CrmInternalMessageTreeTypeLang = new HashSet<CrmInternalMessageTreeTypeLang>();
            CrmInternalMessageType = new HashSet<CrmInternalMessageType>();
            CrmInternalMessageTypeLang = new HashSet<CrmInternalMessageTypeLang>();
            CrmKnowledgeTank = new HashSet<CrmKnowledgeTank>();
            CrmKnowledgeTankGroup = new HashSet<CrmKnowledgeTankGroup>();
            CrmKnowledgeTankGroupLang = new HashSet<CrmKnowledgeTankGroupLang>();
            CrmKnowledgeTankGroupPermission = new HashSet<CrmKnowledgeTankGroupPermission>();
            CrmKnowledgeTankLang = new HashSet<CrmKnowledgeTankLang>();
            CrmKnowledgeTankPriority = new HashSet<CrmKnowledgeTankPriority>();
            CrmKnowledgeTankPriorityLang = new HashSet<CrmKnowledgeTankPriorityLang>();
            CrmLeave = new HashSet<CrmLeave>();
            CrmLeaveKinds = new HashSet<CrmLeaveKinds>();
            CrmLeaveStatus = new HashSet<CrmLeaveStatus>();
            CrmLeaveStayType = new HashSet<CrmLeaveStayType>();
            CrmLeaveType = new HashSet<CrmLeaveType>();
            CrmLeaveVehicleType = new HashSet<CrmLeaveVehicleType>();
            CrmLinkAccNoAvSetting = new HashSet<CrmLinkAccNoAvSetting>();
            CrmLinkAccNoAvSettingDetails = new HashSet<CrmLinkAccNoAvSettingDetails>();
            CrmLinkAccNoAvSettingDetailsLang = new HashSet<CrmLinkAccNoAvSettingDetailsLang>();
            CrmLinkAccNoAvSettingLang = new HashSet<CrmLinkAccNoAvSettingLang>();
            CrmLinkAccSetting = new HashSet<CrmLinkAccSetting>();
            CrmLinkAccSettingDetails = new HashSet<CrmLinkAccSettingDetails>();
            CrmLinkAccSettingDetailsLang = new HashSet<CrmLinkAccSettingDetailsLang>();
            CrmLinkAccSettingLang = new HashSet<CrmLinkAccSettingLang>();
            CrmLinkAccSystems = new HashSet<CrmLinkAccSystems>();
            CrmLinkAccTarazSetting = new HashSet<CrmLinkAccTarazSetting>();
            CrmLinkAccTarazSettingDetails = new HashSet<CrmLinkAccTarazSettingDetails>();
            CrmLinkAccTarazSettingDetailsLang = new HashSet<CrmLinkAccTarazSettingDetailsLang>();
            CrmLinkAccTarazSettingLang = new HashSet<CrmLinkAccTarazSettingLang>();
            CrmLinkedType = new HashSet<CrmLinkedType>();
            CrmLinkedTypeLang = new HashSet<CrmLinkedTypeLang>();
            CrmLinkedUsers = new HashSet<CrmLinkedUsers>();
            CrmOperationsType = new HashSet<CrmOperationsType>();
            CrmOperationsTypeLang = new HashSet<CrmOperationsTypeLang>();
            CrmPersonDepartments = new HashSet<CrmPersonDepartments>();
            CrmPersonDepartmentsLang = new HashSet<CrmPersonDepartmentsLang>();
            CrmPersonGroups = new HashSet<CrmPersonGroups>();
            CrmPersonGroupsLang = new HashSet<CrmPersonGroupsLang>();
            CrmPersonJobs = new HashSet<CrmPersonJobs>();
            CrmPersonJobsLang = new HashSet<CrmPersonJobsLang>();
            CrmPersonPicture = new HashSet<CrmPersonPicture>();
            CrmPersonTitle = new HashSet<CrmPersonTitle>();
            CrmPersonTitleLang = new HashSet<CrmPersonTitleLang>();
            CrmPersonType = new HashSet<CrmPersonType>();
            CrmPersonTypeLang = new HashSet<CrmPersonTypeLang>();
            CrmProjectDefualtValue = new HashSet<CrmProjectDefualtValue>();
            CrmProjectDefualtValueLang = new HashSet<CrmProjectDefualtValueLang>();
            CrmProjectFieldTitle = new HashSet<CrmProjectFieldTitle>();
            CrmProjectFieldTitleLang = new HashSet<CrmProjectFieldTitleLang>();
            CrmProjectFieldValueType = new HashSet<CrmProjectFieldValueType>();
            CrmProjectGrade = new HashSet<CrmProjectGrade>();
            CrmProjectGradeLang = new HashSet<CrmProjectGradeLang>();
            CrmProjectGroups = new HashSet<CrmProjectGroups>();
            CrmProjectGroupsLang = new HashSet<CrmProjectGroupsLang>();
            CrmProjectGroupsMulti = new HashSet<CrmProjectGroupsMulti>();
            CrmProjectGroupsMultiI = new HashSet<CrmProjectGroupsMultiI>();
            CrmProjectGroupsMultiILang = new HashSet<CrmProjectGroupsMultiILang>();
            CrmProjectGroupsMultiLang = new HashSet<CrmProjectGroupsMultiLang>();
            CrmProjectInformations = new HashSet<CrmProjectInformations>();
            CrmProjectInformationsLang = new HashSet<CrmProjectInformationsLang>();
            CrmProjectMultiGroups = new HashSet<CrmProjectMultiGroups>();
            CrmProjectMultiIgroups = new HashSet<CrmProjectMultiIgroups>();
            CrmProjectPriority = new HashSet<CrmProjectPriority>();
            CrmProjectPriorityLang = new HashSet<CrmProjectPriorityLang>();
            CrmProjectTitles = new HashSet<CrmProjectTitles>();
            CrmProjectTitlesLang = new HashSet<CrmProjectTitlesLang>();
            CrmProjects = new HashSet<CrmProjects>();
            CrmProjectsForbiddenForUser = new HashSet<CrmProjectsForbiddenForUser>();
            CrmProjectsForbiddenForUserLang = new HashSet<CrmProjectsForbiddenForUserLang>();
            CrmProjectsLang = new HashSet<CrmProjectsLang>();
            CrmProjectsTmp = new HashSet<CrmProjectsTmp>();
            CrmProjectsTmpLang = new HashSet<CrmProjectsTmpLang>();
            CrmShowTableFieldInFo = new HashSet<CrmShowTableFieldInFo>();
            CrmSystemParts = new HashSet<CrmSystemParts>();
            CrmSystemPartsLang = new HashSet<CrmSystemPartsLang>();
            CrmTelegBotChatMessage = new HashSet<CrmTelegBotChatMessage>();
            CrmTelegBotContacts = new HashSet<CrmTelegBotContacts>();
            CrmTelegBotMessageType = new HashSet<CrmTelegBotMessageType>();
            CrmTelegBotSetting = new HashSet<CrmTelegBotSetting>();
            CrmTelegChatMessage = new HashSet<CrmTelegChatMessage>();
            CrmTelegContacts = new HashSet<CrmTelegContacts>();
            CrmTelegMessageType = new HashSet<CrmTelegMessageType>();
            CrmTelegSetting = new HashSet<CrmTelegSetting>();
            CrmTempEmails = new HashSet<CrmTempEmails>();
            CrmTimeAttendance = new HashSet<CrmTimeAttendance>();
            CrmTimeAttendanceBase = new HashSet<CrmTimeAttendanceBase>();
            CrmTimeAttendanceLog = new HashSet<CrmTimeAttendanceLog>();
            CrmUserNotes = new HashSet<CrmUserNotes>();
            CrmUserTaskGroups = new HashSet<CrmUserTaskGroups>();
            CrmUserTaskGroupsLang = new HashSet<CrmUserTaskGroupsLang>();
            CrmUserTaskPriorities = new HashSet<CrmUserTaskPriorities>();
            CrmUserTaskPrioritiesLang = new HashSet<CrmUserTaskPrioritiesLang>();
            CrmUserTasks = new HashSet<CrmUserTasks>();
            CrmUserTasksLang = new HashSet<CrmUserTasksLang>();
            CrmVersionUpgrade = new HashSet<CrmVersionUpgrade>();
            CrmVersionUpgradeDetails = new HashSet<CrmVersionUpgradeDetails>();
            CrmVersions = new HashSet<CrmVersions>();
            CrmWebSetting = new HashSet<CrmWebSetting>();
            CrmsysCideviceType = new HashSet<CrmsysCideviceType>();
            CrmsysCipopUpSetting = new HashSet<CrmsysCipopUpSetting>();
            CrmsysCisetting = new HashSet<CrmsysCisetting>();
            CrmsysDbobjects = new HashSet<CrmsysDbobjects>();
            CrmsysDbobjectsLang = new HashSet<CrmsysDbobjectsLang>();
            CrmsysDbtempInfo = new HashSet<CrmsysDbtempInfo>();
            CrmsysDbtempInfoType = new HashSet<CrmsysDbtempInfoType>();
            CrmsysFormActions = new HashSet<CrmsysFormActions>();
            CrmsysFormActionsLang = new HashSet<CrmsysFormActionsLang>();
            CrmsysFormObjectProperties = new HashSet<CrmsysFormObjectProperties>();
            CrmsysFormObjectPropertiesLang = new HashSet<CrmsysFormObjectPropertiesLang>();
            CrmsysForms = new HashSet<CrmsysForms>();
            CrmsysFormsLang = new HashSet<CrmsysFormsLang>();
            CrmsysRollPermission = new HashSet<CrmsysRollPermission>();
            CrmsysRolls = new HashSet<CrmsysRolls>();
            CrmsysRollsLang = new HashSet<CrmsysRollsLang>();
            CrmsysSetting = new HashSet<CrmsysSetting>();
            CrmsysSettingLang = new HashSet<CrmsysSettingLang>();
            CrmtmpManageTellNumber = new HashSet<CrmtmpManageTellNumber>();
            Education = new HashSet<Education>();
            EducationLang = new HashSet<EducationLang>();
            EmailDefaultBodyText = new HashSet<EmailDefaultBodyText>();
            EmailDefaultBodyTextLang = new HashSet<EmailDefaultBodyTextLang>();
            EmailReceive = new HashSet<EmailReceive>();
            EmailReceiveAttachments = new HashSet<EmailReceiveAttachments>();
            EmailReceiveFolders = new HashSet<EmailReceiveFolders>();
            EmailSendAttachment = new HashSet<EmailSendAttachment>();
            EmailSendDetail = new HashSet<EmailSendDetail>();
            EmailSendHeader = new HashSet<EmailSendHeader>();
            EmailSetting = new HashSet<EmailSetting>();
            EmailUserDefaultSetting = new HashSet<EmailUserDefaultSetting>();
            EmailUserTempTank = new HashSet<EmailUserTempTank>();
            EmailUsersInfo = new HashSet<EmailUsersInfo>();
            MobApiAndTableDetail = new HashSet<MobApiAndTableDetail>();
            MobCompanyAppInfo = new HashSet<MobCompanyAppInfo>();
            MyWebsites = new HashSet<MyWebsites>();
            PayRollItemTypes = new HashSet<PayRollItemTypes>();
            PayRollItemTypesLang = new HashSet<PayRollItemTypesLang>();
            PayRollItems = new HashSet<PayRollItems>();
            PayRollItemsLang = new HashSet<PayRollItemsLang>();
            PayRollUserCycle = new HashSet<PayRollUserCycle>();
            PayRollUserCycleItemValues = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserCycleLang = new HashSet<PayRollUserCycleLang>();
            PayRollUserDefaultItems = new HashSet<PayRollUserDefaultItems>();
            PayRollUserPaymentTypes = new HashSet<PayRollUserPaymentTypes>();
            PayRollUserPaymentTypesLang = new HashSet<PayRollUserPaymentTypesLang>();
            PayRollUserPayments = new HashSet<PayRollUserPayments>();
            PayRollUserPaymentsLang = new HashSet<PayRollUserPaymentsLang>();
            PrintFormat = new HashSet<PrintFormat>();
            PrintFormatLang = new HashSet<PrintFormatLang>();
            PrintFormatType = new HashSet<PrintFormatType>();
            PrintFormatTypeLang = new HashSet<PrintFormatTypeLang>();
            Projects = new HashSet<Projects>();
            ProjectsLang = new HashSet<ProjectsLang>();
            Province = new HashSet<Province>();
            ProvinceLang = new HashSet<ProvinceLang>();
            SecLetterDefaultSettings = new HashSet<SecLetterDefaultSettings>();
            SecLetterDefaultSettingsLang = new HashSet<SecLetterDefaultSettingsLang>();
            SecLetterType = new HashSet<SecLetterType>();
            SecLetterTypeLang = new HashSet<SecLetterTypeLang>();
            SecLetters = new HashSet<SecLetters>();
            SecLettersLang = new HashSet<SecLettersLang>();
            Sex = new HashSet<Sex>();
            SexLang = new HashSet<SexLang>();
            SmsDefaultBodyText = new HashSet<SmsDefaultBodyText>();
            SmsDefaultBodyTextGroups = new HashSet<SmsDefaultBodyTextGroups>();
            SmsDefaultBodyTextGroupsLang = new HashSet<SmsDefaultBodyTextGroupsLang>();
            SmsDefaultBodyTextLang = new HashSet<SmsDefaultBodyTextLang>();
            SmsDeliveryStatus = new HashSet<SmsDeliveryStatus>();
            SmsDeliveryStatusLang = new HashSet<SmsDeliveryStatusLang>();
            SmsGsmmodemDelivery = new HashSet<SmsGsmmodemDelivery>();
            SmsGsmmodemSetting = new HashSet<SmsGsmmodemSetting>();
            SmsGsmreceives = new HashSet<SmsGsmreceives>();
            SmsGsmsendingTank = new HashSet<SmsGsmsendingTank>();
            SmsProviders = new HashSet<SmsProviders>();
            SmsReceive = new HashSet<SmsReceive>();
            SmsReceiveFromWsdl = new HashSet<SmsReceiveFromWsdl>();
            SmsSendDetail = new HashSet<SmsSendDetail>();
            SmsSendHeader = new HashSet<SmsSendHeader>();
            SmsSendType = new HashSet<SmsSendType>();
            SmsSendTypeLang = new HashSet<SmsSendTypeLang>();
            SmsSetting = new HashSet<SmsSetting>();
            SmsTempMobileNumbers = new HashSet<SmsTempMobileNumbers>();
            SmsUserSendCredit = new HashSet<SmsUserSendCredit>();
            SmsUserSendCreditLang = new HashSet<SmsUserSendCreditLang>();
            UserDepartmentTicketReferUsers = new HashSet<UserDepartmentTicketReferUsers>();
            UserDepartments = new HashSet<UserDepartments>();
            UserDepartmentsLang = new HashSet<UserDepartmentsLang>();
            UserLanguages = new HashSet<UserLanguages>();
            UserLoginAllowedTimes = new HashSet<UserLoginAllowedTimes>();
            UserSignature = new HashSet<UserSignature>();
            Users = new HashSet<Users>();
            UsersLang = new HashSet<UsersLang>();
            UsersPermission = new HashSet<UsersPermission>();
            UsersPermissionLang = new HashSet<UsersPermissionLang>();
            WsWareHouse = new HashSet<WsWareHouse>();
            WsWareHouseLang = new HashSet<WsWareHouseLang>();
            WsbuyOrder = new HashSet<WsbuyOrder>();
            WsbuyOrderItemSerials = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItemSerialsLang = new HashSet<WsbuyOrderItemSerialsLang>();
            WsbuyOrderItems = new HashSet<WsbuyOrderItems>();
            WsbuyOrderItemsLang = new HashSet<WsbuyOrderItemsLang>();
            WsbuyOrderLang = new HashSet<WsbuyOrderLang>();
            WsbuyOrderOpr = new HashSet<WsbuyOrderOpr>();
            WsbuyOrderOprLang = new HashSet<WsbuyOrderOprLang>();
            WsbuyOrderPaymentTypes = new HashSet<WsbuyOrderPaymentTypes>();
            WsbuyOrderPaymentTypesLang = new HashSet<WsbuyOrderPaymentTypesLang>();
            WsbuyOrderPayments = new HashSet<WsbuyOrderPayments>();
            WsbuyOrderPaymentsLang = new HashSet<WsbuyOrderPaymentsLang>();
            WsbuyOrderStatus = new HashSet<WsbuyOrderStatus>();
            WsbuyOrderStatusLang = new HashSet<WsbuyOrderStatusLang>();
            WscreditDuration = new HashSet<WscreditDuration>();
            WscreditDurationLang = new HashSet<WscreditDurationLang>();
            WscurrencyUnits = new HashSet<WscurrencyUnits>();
            WscurrencyUnitsLang = new HashSet<WscurrencyUnitsLang>();
            WsdeliveryTime = new HashSet<WsdeliveryTime>();
            WsdeliveryTimeLang = new HashSet<WsdeliveryTimeLang>();
            Wsdoc = new HashSet<Wsdoc>();
            WsdocItemSerials = new HashSet<WsdocItemSerials>();
            WsdocItemSerialsLang = new HashSet<WsdocItemSerialsLang>();
            WsdocItems = new HashSet<WsdocItems>();
            WsdocItemsLang = new HashSet<WsdocItemsLang>();
            WsdocLang = new HashSet<WsdocLang>();
            WsdocOpr = new HashSet<WsdocOpr>();
            WsdocOprLang = new HashSet<WsdocOprLang>();
            WsfinancialPeriod = new HashSet<WsfinancialPeriod>();
            Wsguaranty = new HashSet<Wsguaranty>();
            WsguarantyLang = new HashSet<WsguarantyLang>();
            WslinkedProducts = new HashSet<WslinkedProducts>();
            Wslogo = new HashSet<Wslogo>();
            WslogoLang = new HashSet<WslogoLang>();
            Wsorder = new HashSet<Wsorder>();
            WsorderCommissionPayTypes = new HashSet<WsorderCommissionPayTypes>();
            WsorderCommissionPayTypesLang = new HashSet<WsorderCommissionPayTypesLang>();
            WsorderCommissions = new HashSet<WsorderCommissions>();
            WsorderCommissionsLang = new HashSet<WsorderCommissionsLang>();
            WsorderDefaultSetting = new HashSet<WsorderDefaultSetting>();
            WsorderDefaultSettingLang = new HashSet<WsorderDefaultSettingLang>();
            WsorderItemSerials = new HashSet<WsorderItemSerials>();
            WsorderItemSerialsLang = new HashSet<WsorderItemSerialsLang>();
            WsorderItems = new HashSet<WsorderItems>();
            WsorderItemsLang = new HashSet<WsorderItemsLang>();
            WsorderLang = new HashSet<WsorderLang>();
            WsorderOpr = new HashSet<WsorderOpr>();
            WsorderOprLang = new HashSet<WsorderOprLang>();
            WsorderPaymentTypes = new HashSet<WsorderPaymentTypes>();
            WsorderPaymentTypesLang = new HashSet<WsorderPaymentTypesLang>();
            WsorderPayments = new HashSet<WsorderPayments>();
            WsorderPaymentsLang = new HashSet<WsorderPaymentsLang>();
            WsorderStatus = new HashSet<WsorderStatus>();
            WsorderStatusLang = new HashSet<WsorderStatusLang>();
            WspayCondition = new HashSet<WspayCondition>();
            WspayConditionLang = new HashSet<WspayConditionLang>();
            WspreOrder = new HashSet<WspreOrder>();
            WspreOrderDefaultSetting = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderDefaultSettingLang = new HashSet<WspreOrderDefaultSettingLang>();
            WspreOrderItemSpecification = new HashSet<WspreOrderItemSpecification>();
            WspreOrderItemSpecificationLang = new HashSet<WspreOrderItemSpecificationLang>();
            WspreOrderItems = new HashSet<WspreOrderItems>();
            WspreOrderItemsLang = new HashSet<WspreOrderItemsLang>();
            WspreOrderLang = new HashSet<WspreOrderLang>();
            WspreOrderOpr = new HashSet<WspreOrderOpr>();
            WspreOrderOprLang = new HashSet<WspreOrderOprLang>();
            WspreOrderPayments = new HashSet<WspreOrderPayments>();
            WspreOrderPaymentsLang = new HashSet<WspreOrderPaymentsLang>();
            WspreOrderPrdGroupMustExistReasonGroups = new HashSet<WspreOrderPrdGroupMustExistReasonGroups>();
            WspreOrderPrdGroupMustExistReasonGroupsLang = new HashSet<WspreOrderPrdGroupMustExistReasonGroupsLang>();
            WspreOrderPrdGroupMustExistReasons = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            WspreOrderPrdGroupMustExistReasonsLang = new HashSet<WspreOrderPrdGroupMustExistReasonsLang>();
            WspreOrderStatus = new HashSet<WspreOrderStatus>();
            WspreOrderStatusLang = new HashSet<WspreOrderStatusLang>();
            WsproductColor = new HashSet<WsproductColor>();
            WsproductColorLang = new HashSet<WsproductColorLang>();
            WsproductCost = new HashSet<WsproductCost>();
            WsproductCostGroup = new HashSet<WsproductCostGroup>();
            WsproductCostGroupLang = new HashSet<WsproductCostGroupLang>();
            WsproductCostLang = new HashSet<WsproductCostLang>();
            WsproductFirstGroup = new HashSet<WsproductFirstGroup>();
            WsproductFirstGroupLang = new HashSet<WsproductFirstGroupLang>();
            WsproductGallery = new HashSet<WsproductGallery>();
            WsproductImportFromExcel = new HashSet<WsproductImportFromExcel>();
            WsproductImportFromExcelFields = new HashSet<WsproductImportFromExcelFields>();
            WsproductImportFromExcelFieldsLang = new HashSet<WsproductImportFromExcelFieldsLang>();
            WsproductPicture = new HashSet<WsproductPicture>();
            WsproductPictureLang = new HashSet<WsproductPictureLang>();
            WsproductPrice = new HashSet<WsproductPrice>();
            WsproductPriceGroup = new HashSet<WsproductPriceGroup>();
            WsproductPriceGroupLang = new HashSet<WsproductPriceGroupLang>();
            WsproductPriceLang = new HashSet<WsproductPriceLang>();
            WsproductSecondGroup = new HashSet<WsproductSecondGroup>();
            WsproductSecondGroupLang = new HashSet<WsproductSecondGroupLang>();
            WsproductShpStockManageTypes = new HashSet<WsproductShpStockManageTypes>();
            WsproductShpStockManageTypesLang = new HashSet<WsproductShpStockManageTypesLang>();
            WsproductSpecification = new HashSet<WsproductSpecification>();
            WsproductSpecificationLang = new HashSet<WsproductSpecificationLang>();
            WsproductUnits = new HashSet<WsproductUnits>();
            WsproductUnitsLang = new HashSet<WsproductUnitsLang>();
            Wsproducts = new HashSet<Wsproducts>();
            WsproductsLang = new HashSet<WsproductsLang>();
            WsproductsRate = new HashSet<WsproductsRate>();
            WsproductsUserDiscount = new HashSet<WsproductsUserDiscount>();
            WsproductsUserDiscountLang = new HashSet<WsproductsUserDiscountLang>();
            WsregisterBarCode = new HashSet<WsregisterBarCode>();
            WssettlementType = new HashSet<WssettlementType>();
            WssettlementTypeLang = new HashSet<WssettlementTypeLang>();
            Wssignature = new HashSet<Wssignature>();
            WstmpEnterBarcodeOperation = new HashSet<WstmpEnterBarcodeOperation>();
            WstmpEnterDocPrdWithBarcode = new HashSet<WstmpEnterDocPrdWithBarcode>();
            WstmpUserItemCopy = new HashSet<WstmpUserItemCopy>();
            WsuserFavproductItems = new HashSet<WsuserFavproductItems>();
            WsuserFavproductItemsLang = new HashSet<WsuserFavproductItemsLang>();
            WsuserFavproducts = new HashSet<WsuserFavproducts>();
            WsuserFavproductsLang = new HashSet<WsuserFavproductsLang>();
            WsverificationRequestDetails = new HashSet<WsverificationRequestDetails>();
            WsverificationRequestDetailsLang = new HashSet<WsverificationRequestDetailsLang>();
            WsverificationRequests = new HashSet<WsverificationRequests>();
            WsverificationRequestsLang = new HashSet<WsverificationRequestsLang>();
            WsverificationWorkFlowSteps = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowStepsLang = new HashSet<WsverificationWorkFlowStepsLang>();
            WsverificationWorkFlows = new HashSet<WsverificationWorkFlows>();
            WsverificationWorkFlowsLang = new HashSet<WsverificationWorkFlowsLang>();
        }

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public string LanguageCollation { get; set; }
        public string LanguageDirection { get; set; }
        public Guid? Guid { get; set; }
        public string AppType { get; set; }
        public int UserId { get; set; }
        public short Year1 { get; set; }
        public short Month1 { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public bool? IsActive { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public int? OrderView { get; set; }

        public virtual Users FirstRegisterUser { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<CityLang> CityLang { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<CountryLang> CountryLang { get; set; }
        public virtual ICollection<CrmAddressing> CrmAddressing { get; set; }
        public virtual ICollection<CrmAddressingType> CrmAddressingType { get; set; }
        public virtual ICollection<CrmBankingAccountType> CrmBankingAccountType { get; set; }
        public virtual ICollection<CrmBankingAccounts> CrmBankingAccounts { get; set; }
        public virtual ICollection<CrmBankingBanks> CrmBankingBanks { get; set; }
        public virtual ICollection<CrmBankingBranches> CrmBankingBranches { get; set; }
        public virtual ICollection<CrmCallBlackList> CrmCallBlackList { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistory { get; set; }
        public virtual ICollection<CrmCallType> CrmCallType { get; set; }
        public virtual ICollection<CrmCallTypeLang> CrmCallTypeLang { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsComments { get; set; }
        public virtual ICollection<CrmCmsCommentsLang> CrmCmsCommentsLang { get; set; }
        public virtual ICollection<CrmCmsFiles> CrmCmsFiles { get; set; }
        public virtual ICollection<CrmCmsFilesLang> CrmCmsFilesLang { get; set; }
        public virtual ICollection<CrmCmsGallery> CrmCmsGallery { get; set; }
        public virtual ICollection<CrmCmsGalleryItems> CrmCmsGalleryItems { get; set; }
        public virtual ICollection<CrmCmsGalleryItemsLang> CrmCmsGalleryItemsLang { get; set; }
        public virtual ICollection<CrmCmsGalleryLang> CrmCmsGalleryLang { get; set; }
        public virtual ICollection<CrmCmsLikes> CrmCmsLikes { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenus { get; set; }
        public virtual ICollection<CrmCmsMenusLang> CrmCmsMenusLang { get; set; }
        public virtual ICollection<CrmCmsNews> CrmCmsNews { get; set; }
        public virtual ICollection<CrmCmsNewsGroups> CrmCmsNewsGroups { get; set; }
        public virtual ICollection<CrmCmsNewsGroupsLang> CrmCmsNewsGroupsLang { get; set; }
        public virtual ICollection<CrmCmsNewsLang> CrmCmsNewsLang { get; set; }
        public virtual ICollection<CrmCmsObjectTypes> CrmCmsObjectTypes { get; set; }
        public virtual ICollection<CrmCmsPages> CrmCmsPages { get; set; }
        public virtual ICollection<CrmCmsPagesLang> CrmCmsPagesLang { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCity> CrmCompanyForbiddenCity { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCompany> CrmCompanyForbiddenCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenDepartment> CrmCompanyForbiddenDepartment { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroup> CrmCompanyForbiddenGroup { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroupIv> CrmCompanyForbiddenGroupIv { get; set; }
        public virtual ICollection<CrmCompanyForbiddenProvince> CrmCompanyForbiddenProvince { get; set; }
        public virtual ICollection<CrmCompanyForbiddenSubGroup> CrmCompanyForbiddenSubGroup { get; set; }
        public virtual ICollection<CrmCompanyGroups> CrmCompanyGroups { get; set; }
        public virtual ICollection<CrmCompanyGroupsIi> CrmCompanyGroupsIi { get; set; }
        public virtual ICollection<CrmCompanyGroupsIiLang> CrmCompanyGroupsIiLang { get; set; }
        public virtual ICollection<CrmCompanyGroupsIii> CrmCompanyGroupsIii { get; set; }
        public virtual ICollection<CrmCompanyGroupsIiiLang> CrmCompanyGroupsIiiLang { get; set; }
        public virtual ICollection<CrmCompanyGroupsIv> CrmCompanyGroupsIv { get; set; }
        public virtual ICollection<CrmCompanyGroupsIvLang> CrmCompanyGroupsIvLang { get; set; }
        public virtual ICollection<CrmCompanyGroupsLang> CrmCompanyGroupsLang { get; set; }
        public virtual ICollection<CrmCompanyGroupsMulti> CrmCompanyGroupsMulti { get; set; }
        public virtual ICollection<CrmCompanyGroupsMultiLang> CrmCompanyGroupsMultiLang { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCity> CrmCompanyJustAccessCity { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCompany> CrmCompanyJustAccessCompany { get; set; }
        public virtual ICollection<CrmCompanyJustAccessDepartment> CrmCompanyJustAccessDepartment { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroup> CrmCompanyJustAccessGroup { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroupIv> CrmCompanyJustAccessGroupIv { get; set; }
        public virtual ICollection<CrmCompanyJustAccessProvince> CrmCompanyJustAccessProvince { get; set; }
        public virtual ICollection<CrmCompanyJustAccessSubGroup> CrmCompanyJustAccessSubGroup { get; set; }
        public virtual ICollection<CrmCompanyLang> CrmCompanyLang { get; set; }
        public virtual ICollection<CrmCompanyLoGo> CrmCompanyLoGo { get; set; }
        public virtual ICollection<CrmCompanyMultiGroups> CrmCompanyMultiGroups { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsLang> CrmCompanyPersonsLang { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplateLang> CrmCompanyPersonsTemplateLang { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmp { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmpLang> CrmCompanyPersonsTmpLang { get; set; }
        public virtual ICollection<CrmCompanyPictureAlbums> CrmCompanyPictureAlbums { get; set; }
        public virtual ICollection<CrmCompanyPictures> CrmCompanyPictures { get; set; }
        public virtual ICollection<CrmCompanyPresentation> CrmCompanyPresentation { get; set; }
        public virtual ICollection<CrmCompanyPresentationLang> CrmCompanyPresentationLang { get; set; }
        public virtual ICollection<CrmCompanySubGroups> CrmCompanySubGroups { get; set; }
        public virtual ICollection<CrmCompanySubGroupsLang> CrmCompanySubGroupsLang { get; set; }
        public virtual ICollection<CrmCompanyTitle> CrmCompanyTitle { get; set; }
        public virtual ICollection<CrmCompanyTitleLang> CrmCompanyTitleLang { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmp { get; set; }
        public virtual ICollection<CrmCompanyTmpLang> CrmCompanyTmpLang { get; set; }
        public virtual ICollection<CrmCompanyType> CrmCompanyType { get; set; }
        public virtual ICollection<CrmCompanyTypeLang> CrmCompanyTypeLang { get; set; }
        public virtual ICollection<CrmCompanyUserForbidden> CrmCompanyUserForbidden { get; set; }
        public virtual ICollection<CrmConversation> CrmConversation { get; set; }
        public virtual ICollection<CrmConversationDefaultContext> CrmConversationDefaultContext { get; set; }
        public virtual ICollection<CrmConversationDefaultContextLang> CrmConversationDefaultContextLang { get; set; }
        public virtual ICollection<CrmConversationLang> CrmConversationLang { get; set; }
        public virtual ICollection<CrmConversationPriority> CrmConversationPriority { get; set; }
        public virtual ICollection<CrmConversationPriorityLang> CrmConversationPriorityLang { get; set; }
        public virtual ICollection<CrmConversationReferUsers> CrmConversationReferUsers { get; set; }
        public virtual ICollection<CrmConversationStatus> CrmConversationStatus { get; set; }
        public virtual ICollection<CrmConversationStatusGroups> CrmConversationStatusGroups { get; set; }
        public virtual ICollection<CrmConversationStatusGroupsLang> CrmConversationStatusGroupsLang { get; set; }
        public virtual ICollection<CrmConversationStatusLang> CrmConversationStatusLang { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmp { get; set; }
        public virtual ICollection<CrmConversationTmpLang> CrmConversationTmpLang { get; set; }
        public virtual ICollection<CrmConversationTopics> CrmConversationTopics { get; set; }
        public virtual ICollection<CrmConversationTopicsLang> CrmConversationTopicsLang { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetails { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValues { get; set; }
        public virtual ICollection<CrmDyFormFieldTypes> CrmDyFormFieldTypes { get; set; }
        public virtual ICollection<CrmDyFormFieldTypesLang> CrmDyFormFieldTypesLang { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValues { get; set; }
        public virtual ICollection<CrmDyFormFieldValuesLang> CrmDyFormFieldValuesLang { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFields { get; set; }
        public virtual ICollection<CrmDyFormFieldsLang> CrmDyFormFieldsLang { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressions> CrmDyFormRegularExpressions { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressionsLang> CrmDyFormRegularExpressionsLang { get; set; }
        public virtual ICollection<CrmDyFormUserAccess> CrmDyFormUserAccess { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowSteps { get; set; }
        public virtual ICollection<CrmDyFormWorkflowStepsLang> CrmDyFormWorkflowStepsLang { get; set; }
        public virtual ICollection<CrmDyFormWorkflows> CrmDyFormWorkflows { get; set; }
        public virtual ICollection<CrmDyFormWorkflowsLang> CrmDyFormWorkflowsLang { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyForms { get; set; }
        public virtual ICollection<CrmDyFormsLang> CrmDyFormsLang { get; set; }
        public virtual ICollection<CrmFileDirectoryType> CrmFileDirectoryType { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeLang> CrmFileDirectoryTypeLang { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeOpr> CrmFileDirectoryTypeOpr { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeOprLang> CrmFileDirectoryTypeOprLang { get; set; }
        public virtual ICollection<CrmFilesDirectory> CrmFilesDirectory { get; set; }
        public virtual ICollection<CrmFilesDirectoryLang> CrmFilesDirectoryLang { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplate> CrmFilesDirectoryTemplate { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplateType> CrmFilesDirectoryTemplateType { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSetting { get; set; }
        public virtual ICollection<CrmFoSettingLang> CrmFoSettingLang { get; set; }
        public virtual ICollection<CrmFund> CrmFund { get; set; }
        public virtual ICollection<CrmFundGroups> CrmFundGroups { get; set; }
        public virtual ICollection<CrmFundGroupsLang> CrmFundGroupsLang { get; set; }
        public virtual ICollection<CrmFundLang> CrmFundLang { get; set; }
        public virtual ICollection<CrmInternalMessage> CrmInternalMessage { get; set; }
        public virtual ICollection<CrmInternalMessageDefaultContext> CrmInternalMessageDefaultContext { get; set; }
        public virtual ICollection<CrmInternalMessageDefaultContextLang> CrmInternalMessageDefaultContextLang { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetails { get; set; }
        public virtual ICollection<CrmInternalMessageGroup> CrmInternalMessageGroup { get; set; }
        public virtual ICollection<CrmInternalMessageGroupLang> CrmInternalMessageGroupLang { get; set; }
        public virtual ICollection<CrmInternalMessageLang> CrmInternalMessageLang { get; set; }
        public virtual ICollection<CrmInternalMessagePriority> CrmInternalMessagePriority { get; set; }
        public virtual ICollection<CrmInternalMessagePriorityLang> CrmInternalMessagePriorityLang { get; set; }
        public virtual ICollection<CrmInternalMessageSelectReceiver> CrmInternalMessageSelectReceiver { get; set; }
        public virtual ICollection<CrmInternalMessageTreeType> CrmInternalMessageTreeType { get; set; }
        public virtual ICollection<CrmInternalMessageTreeTypeLang> CrmInternalMessageTreeTypeLang { get; set; }
        public virtual ICollection<CrmInternalMessageType> CrmInternalMessageType { get; set; }
        public virtual ICollection<CrmInternalMessageTypeLang> CrmInternalMessageTypeLang { get; set; }
        public virtual ICollection<CrmKnowledgeTank> CrmKnowledgeTank { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroup> CrmKnowledgeTankGroup { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupLang> CrmKnowledgeTankGroupLang { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupPermission> CrmKnowledgeTankGroupPermission { get; set; }
        public virtual ICollection<CrmKnowledgeTankLang> CrmKnowledgeTankLang { get; set; }
        public virtual ICollection<CrmKnowledgeTankPriority> CrmKnowledgeTankPriority { get; set; }
        public virtual ICollection<CrmKnowledgeTankPriorityLang> CrmKnowledgeTankPriorityLang { get; set; }
        public virtual ICollection<CrmLeave> CrmLeave { get; set; }
        public virtual ICollection<CrmLeaveKinds> CrmLeaveKinds { get; set; }
        public virtual ICollection<CrmLeaveStatus> CrmLeaveStatus { get; set; }
        public virtual ICollection<CrmLeaveStayType> CrmLeaveStayType { get; set; }
        public virtual ICollection<CrmLeaveType> CrmLeaveType { get; set; }
        public virtual ICollection<CrmLeaveVehicleType> CrmLeaveVehicleType { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSetting> CrmLinkAccNoAvSetting { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetails> CrmLinkAccNoAvSettingDetails { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetailsLang> CrmLinkAccNoAvSettingDetailsLang { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingLang> CrmLinkAccNoAvSettingLang { get; set; }
        public virtual ICollection<CrmLinkAccSetting> CrmLinkAccSetting { get; set; }
        public virtual ICollection<CrmLinkAccSettingDetails> CrmLinkAccSettingDetails { get; set; }
        public virtual ICollection<CrmLinkAccSettingDetailsLang> CrmLinkAccSettingDetailsLang { get; set; }
        public virtual ICollection<CrmLinkAccSettingLang> CrmLinkAccSettingLang { get; set; }
        public virtual ICollection<CrmLinkAccSystems> CrmLinkAccSystems { get; set; }
        public virtual ICollection<CrmLinkAccTarazSetting> CrmLinkAccTarazSetting { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingDetails> CrmLinkAccTarazSettingDetails { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingDetailsLang> CrmLinkAccTarazSettingDetailsLang { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingLang> CrmLinkAccTarazSettingLang { get; set; }
        public virtual ICollection<CrmLinkedType> CrmLinkedType { get; set; }
        public virtual ICollection<CrmLinkedTypeLang> CrmLinkedTypeLang { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsers { get; set; }
        public virtual ICollection<CrmOperationsType> CrmOperationsType { get; set; }
        public virtual ICollection<CrmOperationsTypeLang> CrmOperationsTypeLang { get; set; }
        public virtual ICollection<CrmPersonDepartments> CrmPersonDepartments { get; set; }
        public virtual ICollection<CrmPersonDepartmentsLang> CrmPersonDepartmentsLang { get; set; }
        public virtual ICollection<CrmPersonGroups> CrmPersonGroups { get; set; }
        public virtual ICollection<CrmPersonGroupsLang> CrmPersonGroupsLang { get; set; }
        public virtual ICollection<CrmPersonJobs> CrmPersonJobs { get; set; }
        public virtual ICollection<CrmPersonJobsLang> CrmPersonJobsLang { get; set; }
        public virtual ICollection<CrmPersonPicture> CrmPersonPicture { get; set; }
        public virtual ICollection<CrmPersonTitle> CrmPersonTitle { get; set; }
        public virtual ICollection<CrmPersonTitleLang> CrmPersonTitleLang { get; set; }
        public virtual ICollection<CrmPersonType> CrmPersonType { get; set; }
        public virtual ICollection<CrmPersonTypeLang> CrmPersonTypeLang { get; set; }
        public virtual ICollection<CrmProjectDefualtValue> CrmProjectDefualtValue { get; set; }
        public virtual ICollection<CrmProjectDefualtValueLang> CrmProjectDefualtValueLang { get; set; }
        public virtual ICollection<CrmProjectFieldTitle> CrmProjectFieldTitle { get; set; }
        public virtual ICollection<CrmProjectFieldTitleLang> CrmProjectFieldTitleLang { get; set; }
        public virtual ICollection<CrmProjectFieldValueType> CrmProjectFieldValueType { get; set; }
        public virtual ICollection<CrmProjectGrade> CrmProjectGrade { get; set; }
        public virtual ICollection<CrmProjectGradeLang> CrmProjectGradeLang { get; set; }
        public virtual ICollection<CrmProjectGroups> CrmProjectGroups { get; set; }
        public virtual ICollection<CrmProjectGroupsLang> CrmProjectGroupsLang { get; set; }
        public virtual ICollection<CrmProjectGroupsMulti> CrmProjectGroupsMulti { get; set; }
        public virtual ICollection<CrmProjectGroupsMultiI> CrmProjectGroupsMultiI { get; set; }
        public virtual ICollection<CrmProjectGroupsMultiILang> CrmProjectGroupsMultiILang { get; set; }
        public virtual ICollection<CrmProjectGroupsMultiLang> CrmProjectGroupsMultiLang { get; set; }
        public virtual ICollection<CrmProjectInformations> CrmProjectInformations { get; set; }
        public virtual ICollection<CrmProjectInformationsLang> CrmProjectInformationsLang { get; set; }
        public virtual ICollection<CrmProjectMultiGroups> CrmProjectMultiGroups { get; set; }
        public virtual ICollection<CrmProjectMultiIgroups> CrmProjectMultiIgroups { get; set; }
        public virtual ICollection<CrmProjectPriority> CrmProjectPriority { get; set; }
        public virtual ICollection<CrmProjectPriorityLang> CrmProjectPriorityLang { get; set; }
        public virtual ICollection<CrmProjectTitles> CrmProjectTitles { get; set; }
        public virtual ICollection<CrmProjectTitlesLang> CrmProjectTitlesLang { get; set; }
        public virtual ICollection<CrmProjects> CrmProjects { get; set; }
        public virtual ICollection<CrmProjectsForbiddenForUser> CrmProjectsForbiddenForUser { get; set; }
        public virtual ICollection<CrmProjectsForbiddenForUserLang> CrmProjectsForbiddenForUserLang { get; set; }
        public virtual ICollection<CrmProjectsLang> CrmProjectsLang { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmp { get; set; }
        public virtual ICollection<CrmProjectsTmpLang> CrmProjectsTmpLang { get; set; }
        public virtual ICollection<CrmShowTableFieldInFo> CrmShowTableFieldInFo { get; set; }
        public virtual ICollection<CrmSystemParts> CrmSystemParts { get; set; }
        public virtual ICollection<CrmSystemPartsLang> CrmSystemPartsLang { get; set; }
        public virtual ICollection<CrmTelegBotChatMessage> CrmTelegBotChatMessage { get; set; }
        public virtual ICollection<CrmTelegBotContacts> CrmTelegBotContacts { get; set; }
        public virtual ICollection<CrmTelegBotMessageType> CrmTelegBotMessageType { get; set; }
        public virtual ICollection<CrmTelegBotSetting> CrmTelegBotSetting { get; set; }
        public virtual ICollection<CrmTelegChatMessage> CrmTelegChatMessage { get; set; }
        public virtual ICollection<CrmTelegContacts> CrmTelegContacts { get; set; }
        public virtual ICollection<CrmTelegMessageType> CrmTelegMessageType { get; set; }
        public virtual ICollection<CrmTelegSetting> CrmTelegSetting { get; set; }
        public virtual ICollection<CrmTempEmails> CrmTempEmails { get; set; }
        public virtual ICollection<CrmTimeAttendance> CrmTimeAttendance { get; set; }
        public virtual ICollection<CrmTimeAttendanceBase> CrmTimeAttendanceBase { get; set; }
        public virtual ICollection<CrmTimeAttendanceLog> CrmTimeAttendanceLog { get; set; }
        public virtual ICollection<CrmUserNotes> CrmUserNotes { get; set; }
        public virtual ICollection<CrmUserTaskGroups> CrmUserTaskGroups { get; set; }
        public virtual ICollection<CrmUserTaskGroupsLang> CrmUserTaskGroupsLang { get; set; }
        public virtual ICollection<CrmUserTaskPriorities> CrmUserTaskPriorities { get; set; }
        public virtual ICollection<CrmUserTaskPrioritiesLang> CrmUserTaskPrioritiesLang { get; set; }
        public virtual ICollection<CrmUserTasks> CrmUserTasks { get; set; }
        public virtual ICollection<CrmUserTasksLang> CrmUserTasksLang { get; set; }
        public virtual ICollection<CrmVersionUpgrade> CrmVersionUpgrade { get; set; }
        public virtual ICollection<CrmVersionUpgradeDetails> CrmVersionUpgradeDetails { get; set; }
        public virtual ICollection<CrmVersions> CrmVersions { get; set; }
        public virtual ICollection<CrmWebSetting> CrmWebSetting { get; set; }
        public virtual ICollection<CrmsysCideviceType> CrmsysCideviceType { get; set; }
        public virtual ICollection<CrmsysCipopUpSetting> CrmsysCipopUpSetting { get; set; }
        public virtual ICollection<CrmsysCisetting> CrmsysCisetting { get; set; }
        public virtual ICollection<CrmsysDbobjects> CrmsysDbobjects { get; set; }
        public virtual ICollection<CrmsysDbobjectsLang> CrmsysDbobjectsLang { get; set; }
        public virtual ICollection<CrmsysDbtempInfo> CrmsysDbtempInfo { get; set; }
        public virtual ICollection<CrmsysDbtempInfoType> CrmsysDbtempInfoType { get; set; }
        public virtual ICollection<CrmsysFormActions> CrmsysFormActions { get; set; }
        public virtual ICollection<CrmsysFormActionsLang> CrmsysFormActionsLang { get; set; }
        public virtual ICollection<CrmsysFormObjectProperties> CrmsysFormObjectProperties { get; set; }
        public virtual ICollection<CrmsysFormObjectPropertiesLang> CrmsysFormObjectPropertiesLang { get; set; }
        public virtual ICollection<CrmsysForms> CrmsysForms { get; set; }
        public virtual ICollection<CrmsysFormsLang> CrmsysFormsLang { get; set; }
        public virtual ICollection<CrmsysRollPermission> CrmsysRollPermission { get; set; }
        public virtual ICollection<CrmsysRolls> CrmsysRolls { get; set; }
        public virtual ICollection<CrmsysRollsLang> CrmsysRollsLang { get; set; }
        public virtual ICollection<CrmsysSetting> CrmsysSetting { get; set; }
        public virtual ICollection<CrmsysSettingLang> CrmsysSettingLang { get; set; }
        public virtual ICollection<CrmtmpManageTellNumber> CrmtmpManageTellNumber { get; set; }
        public virtual ICollection<Education> Education { get; set; }
        public virtual ICollection<EducationLang> EducationLang { get; set; }
        public virtual ICollection<EmailDefaultBodyText> EmailDefaultBodyText { get; set; }
        public virtual ICollection<EmailDefaultBodyTextLang> EmailDefaultBodyTextLang { get; set; }
        public virtual ICollection<EmailReceive> EmailReceive { get; set; }
        public virtual ICollection<EmailReceiveAttachments> EmailReceiveAttachments { get; set; }
        public virtual ICollection<EmailReceiveFolders> EmailReceiveFolders { get; set; }
        public virtual ICollection<EmailSendAttachment> EmailSendAttachment { get; set; }
        public virtual ICollection<EmailSendDetail> EmailSendDetail { get; set; }
        public virtual ICollection<EmailSendHeader> EmailSendHeader { get; set; }
        public virtual ICollection<EmailSetting> EmailSetting { get; set; }
        public virtual ICollection<EmailUserDefaultSetting> EmailUserDefaultSetting { get; set; }
        public virtual ICollection<EmailUserTempTank> EmailUserTempTank { get; set; }
        public virtual ICollection<EmailUsersInfo> EmailUsersInfo { get; set; }
        public virtual ICollection<MobApiAndTableDetail> MobApiAndTableDetail { get; set; }
        public virtual ICollection<MobCompanyAppInfo> MobCompanyAppInfo { get; set; }
        public virtual ICollection<MyWebsites> MyWebsites { get; set; }
        public virtual ICollection<PayRollItemTypes> PayRollItemTypes { get; set; }
        public virtual ICollection<PayRollItemTypesLang> PayRollItemTypesLang { get; set; }
        public virtual ICollection<PayRollItems> PayRollItems { get; set; }
        public virtual ICollection<PayRollItemsLang> PayRollItemsLang { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycle { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValues { get; set; }
        public virtual ICollection<PayRollUserCycleLang> PayRollUserCycleLang { get; set; }
        public virtual ICollection<PayRollUserDefaultItems> PayRollUserDefaultItems { get; set; }
        public virtual ICollection<PayRollUserPaymentTypes> PayRollUserPaymentTypes { get; set; }
        public virtual ICollection<PayRollUserPaymentTypesLang> PayRollUserPaymentTypesLang { get; set; }
        public virtual ICollection<PayRollUserPayments> PayRollUserPayments { get; set; }
        public virtual ICollection<PayRollUserPaymentsLang> PayRollUserPaymentsLang { get; set; }
        public virtual ICollection<PrintFormat> PrintFormat { get; set; }
        public virtual ICollection<PrintFormatLang> PrintFormatLang { get; set; }
        public virtual ICollection<PrintFormatType> PrintFormatType { get; set; }
        public virtual ICollection<PrintFormatTypeLang> PrintFormatTypeLang { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<ProjectsLang> ProjectsLang { get; set; }
        public virtual ICollection<Province> Province { get; set; }
        public virtual ICollection<ProvinceLang> ProvinceLang { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettings { get; set; }
        public virtual ICollection<SecLetterDefaultSettingsLang> SecLetterDefaultSettingsLang { get; set; }
        public virtual ICollection<SecLetterType> SecLetterType { get; set; }
        public virtual ICollection<SecLetterTypeLang> SecLetterTypeLang { get; set; }
        public virtual ICollection<SecLetters> SecLetters { get; set; }
        public virtual ICollection<SecLettersLang> SecLettersLang { get; set; }
        public virtual ICollection<Sex> Sex { get; set; }
        public virtual ICollection<SexLang> SexLang { get; set; }
        public virtual ICollection<SmsDefaultBodyText> SmsDefaultBodyText { get; set; }
        public virtual ICollection<SmsDefaultBodyTextGroups> SmsDefaultBodyTextGroups { get; set; }
        public virtual ICollection<SmsDefaultBodyTextGroupsLang> SmsDefaultBodyTextGroupsLang { get; set; }
        public virtual ICollection<SmsDefaultBodyTextLang> SmsDefaultBodyTextLang { get; set; }
        public virtual ICollection<SmsDeliveryStatus> SmsDeliveryStatus { get; set; }
        public virtual ICollection<SmsDeliveryStatusLang> SmsDeliveryStatusLang { get; set; }
        public virtual ICollection<SmsGsmmodemDelivery> SmsGsmmodemDelivery { get; set; }
        public virtual ICollection<SmsGsmmodemSetting> SmsGsmmodemSetting { get; set; }
        public virtual ICollection<SmsGsmreceives> SmsGsmreceives { get; set; }
        public virtual ICollection<SmsGsmsendingTank> SmsGsmsendingTank { get; set; }
        public virtual ICollection<SmsProviders> SmsProviders { get; set; }
        public virtual ICollection<SmsReceive> SmsReceive { get; set; }
        public virtual ICollection<SmsReceiveFromWsdl> SmsReceiveFromWsdl { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetail { get; set; }
        public virtual ICollection<SmsSendHeader> SmsSendHeader { get; set; }
        public virtual ICollection<SmsSendType> SmsSendType { get; set; }
        public virtual ICollection<SmsSendTypeLang> SmsSendTypeLang { get; set; }
        public virtual ICollection<SmsSetting> SmsSetting { get; set; }
        public virtual ICollection<SmsTempMobileNumbers> SmsTempMobileNumbers { get; set; }
        public virtual ICollection<SmsUserSendCredit> SmsUserSendCredit { get; set; }
        public virtual ICollection<SmsUserSendCreditLang> SmsUserSendCreditLang { get; set; }
        public virtual ICollection<UserDepartmentTicketReferUsers> UserDepartmentTicketReferUsers { get; set; }
        public virtual ICollection<UserDepartments> UserDepartments { get; set; }
        public virtual ICollection<UserDepartmentsLang> UserDepartmentsLang { get; set; }
        public virtual ICollection<UserLanguages> UserLanguages { get; set; }
        public virtual ICollection<UserLoginAllowedTimes> UserLoginAllowedTimes { get; set; }
        public virtual ICollection<UserSignature> UserSignature { get; set; }
        public virtual ICollection<Users> Users { get; set; }
        public virtual ICollection<UsersLang> UsersLang { get; set; }
        public virtual ICollection<UsersPermission> UsersPermission { get; set; }
        public virtual ICollection<UsersPermissionLang> UsersPermissionLang { get; set; }
        public virtual ICollection<WsWareHouse> WsWareHouse { get; set; }
        public virtual ICollection<WsWareHouseLang> WsWareHouseLang { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrder { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerials { get; set; }
        public virtual ICollection<WsbuyOrderItemSerialsLang> WsbuyOrderItemSerialsLang { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItems { get; set; }
        public virtual ICollection<WsbuyOrderItemsLang> WsbuyOrderItemsLang { get; set; }
        public virtual ICollection<WsbuyOrderLang> WsbuyOrderLang { get; set; }
        public virtual ICollection<WsbuyOrderOpr> WsbuyOrderOpr { get; set; }
        public virtual ICollection<WsbuyOrderOprLang> WsbuyOrderOprLang { get; set; }
        public virtual ICollection<WsbuyOrderPaymentTypes> WsbuyOrderPaymentTypes { get; set; }
        public virtual ICollection<WsbuyOrderPaymentTypesLang> WsbuyOrderPaymentTypesLang { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPayments { get; set; }
        public virtual ICollection<WsbuyOrderPaymentsLang> WsbuyOrderPaymentsLang { get; set; }
        public virtual ICollection<WsbuyOrderStatus> WsbuyOrderStatus { get; set; }
        public virtual ICollection<WsbuyOrderStatusLang> WsbuyOrderStatusLang { get; set; }
        public virtual ICollection<WscreditDuration> WscreditDuration { get; set; }
        public virtual ICollection<WscreditDurationLang> WscreditDurationLang { get; set; }
        public virtual ICollection<WscurrencyUnits> WscurrencyUnits { get; set; }
        public virtual ICollection<WscurrencyUnitsLang> WscurrencyUnitsLang { get; set; }
        public virtual ICollection<WsdeliveryTime> WsdeliveryTime { get; set; }
        public virtual ICollection<WsdeliveryTimeLang> WsdeliveryTimeLang { get; set; }
        public virtual ICollection<Wsdoc> Wsdoc { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerials { get; set; }
        public virtual ICollection<WsdocItemSerialsLang> WsdocItemSerialsLang { get; set; }
        public virtual ICollection<WsdocItems> WsdocItems { get; set; }
        public virtual ICollection<WsdocItemsLang> WsdocItemsLang { get; set; }
        public virtual ICollection<WsdocLang> WsdocLang { get; set; }
        public virtual ICollection<WsdocOpr> WsdocOpr { get; set; }
        public virtual ICollection<WsdocOprLang> WsdocOprLang { get; set; }
        public virtual ICollection<WsfinancialPeriod> WsfinancialPeriod { get; set; }
        public virtual ICollection<Wsguaranty> Wsguaranty { get; set; }
        public virtual ICollection<WsguarantyLang> WsguarantyLang { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProducts { get; set; }
        public virtual ICollection<Wslogo> Wslogo { get; set; }
        public virtual ICollection<WslogoLang> WslogoLang { get; set; }
        public virtual ICollection<Wsorder> Wsorder { get; set; }
        public virtual ICollection<WsorderCommissionPayTypes> WsorderCommissionPayTypes { get; set; }
        public virtual ICollection<WsorderCommissionPayTypesLang> WsorderCommissionPayTypesLang { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissions { get; set; }
        public virtual ICollection<WsorderCommissionsLang> WsorderCommissionsLang { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSetting { get; set; }
        public virtual ICollection<WsorderDefaultSettingLang> WsorderDefaultSettingLang { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerials { get; set; }
        public virtual ICollection<WsorderItemSerialsLang> WsorderItemSerialsLang { get; set; }
        public virtual ICollection<WsorderItems> WsorderItems { get; set; }
        public virtual ICollection<WsorderItemsLang> WsorderItemsLang { get; set; }
        public virtual ICollection<WsorderLang> WsorderLang { get; set; }
        public virtual ICollection<WsorderOpr> WsorderOpr { get; set; }
        public virtual ICollection<WsorderOprLang> WsorderOprLang { get; set; }
        public virtual ICollection<WsorderPaymentTypes> WsorderPaymentTypes { get; set; }
        public virtual ICollection<WsorderPaymentTypesLang> WsorderPaymentTypesLang { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPayments { get; set; }
        public virtual ICollection<WsorderPaymentsLang> WsorderPaymentsLang { get; set; }
        public virtual ICollection<WsorderStatus> WsorderStatus { get; set; }
        public virtual ICollection<WsorderStatusLang> WsorderStatusLang { get; set; }
        public virtual ICollection<WspayCondition> WspayCondition { get; set; }
        public virtual ICollection<WspayConditionLang> WspayConditionLang { get; set; }
        public virtual ICollection<WspreOrder> WspreOrder { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSetting { get; set; }
        public virtual ICollection<WspreOrderDefaultSettingLang> WspreOrderDefaultSettingLang { get; set; }
        public virtual ICollection<WspreOrderItemSpecification> WspreOrderItemSpecification { get; set; }
        public virtual ICollection<WspreOrderItemSpecificationLang> WspreOrderItemSpecificationLang { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItems { get; set; }
        public virtual ICollection<WspreOrderItemsLang> WspreOrderItemsLang { get; set; }
        public virtual ICollection<WspreOrderLang> WspreOrderLang { get; set; }
        public virtual ICollection<WspreOrderOpr> WspreOrderOpr { get; set; }
        public virtual ICollection<WspreOrderOprLang> WspreOrderOprLang { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPayments { get; set; }
        public virtual ICollection<WspreOrderPaymentsLang> WspreOrderPaymentsLang { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasonGroups> WspreOrderPrdGroupMustExistReasonGroups { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasonGroupsLang> WspreOrderPrdGroupMustExistReasonGroupsLang { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasons { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasonsLang> WspreOrderPrdGroupMustExistReasonsLang { get; set; }
        public virtual ICollection<WspreOrderStatus> WspreOrderStatus { get; set; }
        public virtual ICollection<WspreOrderStatusLang> WspreOrderStatusLang { get; set; }
        public virtual ICollection<WsproductColor> WsproductColor { get; set; }
        public virtual ICollection<WsproductColorLang> WsproductColorLang { get; set; }
        public virtual ICollection<WsproductCost> WsproductCost { get; set; }
        public virtual ICollection<WsproductCostGroup> WsproductCostGroup { get; set; }
        public virtual ICollection<WsproductCostGroupLang> WsproductCostGroupLang { get; set; }
        public virtual ICollection<WsproductCostLang> WsproductCostLang { get; set; }
        public virtual ICollection<WsproductFirstGroup> WsproductFirstGroup { get; set; }
        public virtual ICollection<WsproductFirstGroupLang> WsproductFirstGroupLang { get; set; }
        public virtual ICollection<WsproductGallery> WsproductGallery { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcel { get; set; }
        public virtual ICollection<WsproductImportFromExcelFields> WsproductImportFromExcelFields { get; set; }
        public virtual ICollection<WsproductImportFromExcelFieldsLang> WsproductImportFromExcelFieldsLang { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPicture { get; set; }
        public virtual ICollection<WsproductPictureLang> WsproductPictureLang { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPrice { get; set; }
        public virtual ICollection<WsproductPriceGroup> WsproductPriceGroup { get; set; }
        public virtual ICollection<WsproductPriceGroupLang> WsproductPriceGroupLang { get; set; }
        public virtual ICollection<WsproductPriceLang> WsproductPriceLang { get; set; }
        public virtual ICollection<WsproductSecondGroup> WsproductSecondGroup { get; set; }
        public virtual ICollection<WsproductSecondGroupLang> WsproductSecondGroupLang { get; set; }
        public virtual ICollection<WsproductShpStockManageTypes> WsproductShpStockManageTypes { get; set; }
        public virtual ICollection<WsproductShpStockManageTypesLang> WsproductShpStockManageTypesLang { get; set; }
        public virtual ICollection<WsproductSpecification> WsproductSpecification { get; set; }
        public virtual ICollection<WsproductSpecificationLang> WsproductSpecificationLang { get; set; }
        public virtual ICollection<WsproductUnits> WsproductUnits { get; set; }
        public virtual ICollection<WsproductUnitsLang> WsproductUnitsLang { get; set; }
        public virtual ICollection<Wsproducts> Wsproducts { get; set; }
        public virtual ICollection<WsproductsLang> WsproductsLang { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRate { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscount { get; set; }
        public virtual ICollection<WsproductsUserDiscountLang> WsproductsUserDiscountLang { get; set; }
        public virtual ICollection<WsregisterBarCode> WsregisterBarCode { get; set; }
        public virtual ICollection<WssettlementType> WssettlementType { get; set; }
        public virtual ICollection<WssettlementTypeLang> WssettlementTypeLang { get; set; }
        public virtual ICollection<Wssignature> Wssignature { get; set; }
        public virtual ICollection<WstmpEnterBarcodeOperation> WstmpEnterBarcodeOperation { get; set; }
        public virtual ICollection<WstmpEnterDocPrdWithBarcode> WstmpEnterDocPrdWithBarcode { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopy { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItems { get; set; }
        public virtual ICollection<WsuserFavproductItemsLang> WsuserFavproductItemsLang { get; set; }
        public virtual ICollection<WsuserFavproducts> WsuserFavproducts { get; set; }
        public virtual ICollection<WsuserFavproductsLang> WsuserFavproductsLang { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetails { get; set; }
        public virtual ICollection<WsverificationRequestDetailsLang> WsverificationRequestDetailsLang { get; set; }
        public virtual ICollection<WsverificationRequests> WsverificationRequests { get; set; }
        public virtual ICollection<WsverificationRequestsLang> WsverificationRequestsLang { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowSteps { get; set; }
        public virtual ICollection<WsverificationWorkFlowStepsLang> WsverificationWorkFlowStepsLang { get; set; }
        public virtual ICollection<WsverificationWorkFlows> WsverificationWorkFlows { get; set; }
        public virtual ICollection<WsverificationWorkFlowsLang> WsverificationWorkFlowsLang { get; set; }
    }
}
