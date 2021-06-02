using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace  Domain.Entities.IdealCrm
{
    public partial class Users
    {
        public Users()
        {
            City = new HashSet<City>();
            Country = new HashSet<Country>();
            CrmAddressingFirstRegisterUser = new HashSet<CrmAddressing>();
            CrmAddressingType = new HashSet<CrmAddressingType>();
            CrmAddressingUser = new HashSet<CrmAddressing>();
            CrmBankingAccountType = new HashSet<CrmBankingAccountType>();
            CrmBankingAccounts = new HashSet<CrmBankingAccounts>();
            CrmBankingBanks = new HashSet<CrmBankingBanks>();
            CrmBankingBranches = new HashSet<CrmBankingBranches>();
            CrmCallBlackListBluser = new HashSet<CrmCallBlackList>();
            CrmCallBlackListFirstRegisterUser = new HashSet<CrmCallBlackList>();
            CrmCallBlackListUser = new HashSet<CrmCallBlackList>();
            CrmCallHistoryFirstRegisterUser = new HashSet<CrmCallHistory>();
            CrmCallHistoryNoteEditedUser = new HashSet<CrmCallHistory>();
            CrmCallHistoryNoteRegisterUser = new HashSet<CrmCallHistory>();
            CrmCallHistoryNumberEditedUser = new HashSet<CrmCallHistory>();
            CrmCallHistoryUser = new HashSet<CrmCallHistory>();
            CrmCallType = new HashSet<CrmCallType>();
            CrmCmsCommentsFirstRegisterUser = new HashSet<CrmCmsComments>();
            CrmCmsCommentsUser = new HashSet<CrmCmsComments>();
            CrmCmsCommentsVerifiedUser = new HashSet<CrmCmsComments>();
            CrmCmsFilesFirstRegisterUser = new HashSet<CrmCmsFiles>();
            CrmCmsFilesUser = new HashSet<CrmCmsFiles>();
            CrmCmsGalleryFirstRegisterUser = new HashSet<CrmCmsGallery>();
            CrmCmsGalleryItemsFirstRegisterUser = new HashSet<CrmCmsGalleryItems>();
            CrmCmsGalleryItemsUser = new HashSet<CrmCmsGalleryItems>();
            CrmCmsGalleryUser = new HashSet<CrmCmsGallery>();
            CrmCmsLikesFirstRegisterUser = new HashSet<CrmCmsLikes>();
            CrmCmsLikesUser = new HashSet<CrmCmsLikes>();
            CrmCmsMenusFirstRegisterUser = new HashSet<CrmCmsMenus>();
            CrmCmsMenusUser = new HashSet<CrmCmsMenus>();
            CrmCmsNewsFirstRegisterUser = new HashSet<CrmCmsNews>();
            CrmCmsNewsGroupsFirstRegisterUser = new HashSet<CrmCmsNewsGroups>();
            CrmCmsNewsGroupsUser = new HashSet<CrmCmsNewsGroups>();
            CrmCmsNewsUser = new HashSet<CrmCmsNews>();
            CrmCmsNewsVerifiedUser = new HashSet<CrmCmsNews>();
            CrmCmsObjectTypesFirstRegisterUser = new HashSet<CrmCmsObjectTypes>();
            CrmCmsObjectTypesUser = new HashSet<CrmCmsObjectTypes>();
            CrmCmsPagesFirstRegisterUser = new HashSet<CrmCmsPages>();
            CrmCmsPagesUser = new HashSet<CrmCmsPages>();
            CrmCompany = new HashSet<CrmCompany>();
            CrmCompanyForbiddenCityCrmUser = new HashSet<CrmCompanyForbiddenCity>();
            CrmCompanyForbiddenCityFirstRegisterUser = new HashSet<CrmCompanyForbiddenCity>();
            CrmCompanyForbiddenCityUser = new HashSet<CrmCompanyForbiddenCity>();
            CrmCompanyForbiddenCompanyCrmUser = new HashSet<CrmCompanyForbiddenCompany>();
            CrmCompanyForbiddenCompanyFirstRegisterUser = new HashSet<CrmCompanyForbiddenCompany>();
            CrmCompanyForbiddenCompanyUser = new HashSet<CrmCompanyForbiddenCompany>();
            CrmCompanyForbiddenDepartmentCrmUser = new HashSet<CrmCompanyForbiddenDepartment>();
            CrmCompanyForbiddenDepartmentFirstRegisterUser = new HashSet<CrmCompanyForbiddenDepartment>();
            CrmCompanyForbiddenDepartmentUser = new HashSet<CrmCompanyForbiddenDepartment>();
            CrmCompanyForbiddenGroupCrmUser = new HashSet<CrmCompanyForbiddenGroup>();
            CrmCompanyForbiddenGroupFirstRegisterUser = new HashSet<CrmCompanyForbiddenGroup>();
            CrmCompanyForbiddenGroupIvCrmUser = new HashSet<CrmCompanyForbiddenGroupIv>();
            CrmCompanyForbiddenGroupIvFirstRegisterUser = new HashSet<CrmCompanyForbiddenGroupIv>();
            CrmCompanyForbiddenGroupIvUser = new HashSet<CrmCompanyForbiddenGroupIv>();
            CrmCompanyForbiddenGroupUser = new HashSet<CrmCompanyForbiddenGroup>();
            CrmCompanyForbiddenProvinceCrmUser = new HashSet<CrmCompanyForbiddenProvince>();
            CrmCompanyForbiddenProvinceFirstRegisterUser = new HashSet<CrmCompanyForbiddenProvince>();
            CrmCompanyForbiddenProvinceUser = new HashSet<CrmCompanyForbiddenProvince>();
            CrmCompanyForbiddenSubGroupCrmUser = new HashSet<CrmCompanyForbiddenSubGroup>();
            CrmCompanyForbiddenSubGroupFirstRegisterUser = new HashSet<CrmCompanyForbiddenSubGroup>();
            CrmCompanyForbiddenSubGroupUser = new HashSet<CrmCompanyForbiddenSubGroup>();
            CrmCompanyGroups = new HashSet<CrmCompanyGroups>();
            CrmCompanyGroupsIi = new HashSet<CrmCompanyGroupsIi>();
            CrmCompanyGroupsIii = new HashSet<CrmCompanyGroupsIii>();
            CrmCompanyGroupsIv = new HashSet<CrmCompanyGroupsIv>();
            CrmCompanyGroupsMulti = new HashSet<CrmCompanyGroupsMulti>();
            CrmCompanyJustAccessCityCrmUser = new HashSet<CrmCompanyJustAccessCity>();
            CrmCompanyJustAccessCityFirstRegisterUser = new HashSet<CrmCompanyJustAccessCity>();
            CrmCompanyJustAccessCityUser = new HashSet<CrmCompanyJustAccessCity>();
            CrmCompanyJustAccessCompanyCrmUser = new HashSet<CrmCompanyJustAccessCompany>();
            CrmCompanyJustAccessCompanyFirstRegisterUser = new HashSet<CrmCompanyJustAccessCompany>();
            CrmCompanyJustAccessCompanyUser = new HashSet<CrmCompanyJustAccessCompany>();
            CrmCompanyJustAccessDepartmentCrmUser = new HashSet<CrmCompanyJustAccessDepartment>();
            CrmCompanyJustAccessDepartmentFirstRegisterUser = new HashSet<CrmCompanyJustAccessDepartment>();
            CrmCompanyJustAccessDepartmentUser = new HashSet<CrmCompanyJustAccessDepartment>();
            CrmCompanyJustAccessGroupCrmUser = new HashSet<CrmCompanyJustAccessGroup>();
            CrmCompanyJustAccessGroupFirstRegisterUser = new HashSet<CrmCompanyJustAccessGroup>();
            CrmCompanyJustAccessGroupIvCrmUser = new HashSet<CrmCompanyJustAccessGroupIv>();
            CrmCompanyJustAccessGroupIvFirstRegisterUser = new HashSet<CrmCompanyJustAccessGroupIv>();
            CrmCompanyJustAccessGroupIvUser = new HashSet<CrmCompanyJustAccessGroupIv>();
            CrmCompanyJustAccessGroupUser = new HashSet<CrmCompanyJustAccessGroup>();
            CrmCompanyJustAccessProvinceCrmUser = new HashSet<CrmCompanyJustAccessProvince>();
            CrmCompanyJustAccessProvinceFirstRegisterUser = new HashSet<CrmCompanyJustAccessProvince>();
            CrmCompanyJustAccessProvinceUser = new HashSet<CrmCompanyJustAccessProvince>();
            CrmCompanyJustAccessSubGroupCrmUser = new HashSet<CrmCompanyJustAccessSubGroup>();
            CrmCompanyJustAccessSubGroupFirstRegisterUser = new HashSet<CrmCompanyJustAccessSubGroup>();
            CrmCompanyJustAccessSubGroupUser = new HashSet<CrmCompanyJustAccessSubGroup>();
            CrmCompanyLoGoFirstRegisterUser = new HashSet<CrmCompanyLoGo>();
            CrmCompanyLoGoUser = new HashSet<CrmCompanyLoGo>();
            CrmCompanyMultiGroupsFirstRegisterUser = new HashSet<CrmCompanyMultiGroups>();
            CrmCompanyMultiGroupsUser = new HashSet<CrmCompanyMultiGroups>();
            CrmCompanyPersons = new HashSet<CrmCompanyPersons>();
            CrmCompanyPersonsTemplate = new HashSet<CrmCompanyPersonsTemplate>();
            CrmCompanyPersonsTmpFirstRegisterUser = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyPersonsTmpPrsFirstRegisterUser = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyPersonsTmpUser = new HashSet<CrmCompanyPersonsTmp>();
            CrmCompanyPictureAlbumsFirstRegisterUser = new HashSet<CrmCompanyPictureAlbums>();
            CrmCompanyPictureAlbumsUser = new HashSet<CrmCompanyPictureAlbums>();
            CrmCompanyPicturesFirstRegisterUser = new HashSet<CrmCompanyPictures>();
            CrmCompanyPicturesUser = new HashSet<CrmCompanyPictures>();
            CrmCompanyPresentation = new HashSet<CrmCompanyPresentation>();
            CrmCompanySubGroups = new HashSet<CrmCompanySubGroups>();
            CrmCompanyTitle = new HashSet<CrmCompanyTitle>();
            CrmCompanyTmpCmpCoordinateLastUser = new HashSet<CrmCompanyTmp>();
            CrmCompanyTmpCmpFirstRegisterUser = new HashSet<CrmCompanyTmp>();
            CrmCompanyTmpCmpReferUser = new HashSet<CrmCompanyTmp>();
            CrmCompanyTmpFirstRegisterUser = new HashSet<CrmCompanyTmp>();
            CrmCompanyTmpUser = new HashSet<CrmCompanyTmp>();
            CrmCompanyType = new HashSet<CrmCompanyType>();
            CrmCompanyUserForbiddenCrmUser = new HashSet<CrmCompanyUserForbidden>();
            CrmCompanyUserForbiddenFirstRegisterUser = new HashSet<CrmCompanyUserForbidden>();
            CrmCompanyUserForbiddenUser = new HashSet<CrmCompanyUserForbidden>();
            CrmConversationCnvsFirstRegisterUser = new HashSet<CrmConversation>();
            CrmConversationCnvsReferUser = new HashSet<CrmConversation>();
            CrmConversationCnvsUser = new HashSet<CrmConversation>();
            CrmConversationDefaultContext = new HashSet<CrmConversationDefaultContext>();
            CrmConversationFirstRegisterUser = new HashSet<CrmConversation>();
            CrmConversationPriority = new HashSet<CrmConversationPriority>();
            CrmConversationReferUsersFirstRegisterUser = new HashSet<CrmConversationReferUsers>();
            CrmConversationReferUsersReferUser = new HashSet<CrmConversationReferUsers>();
            CrmConversationReferUsersUser = new HashSet<CrmConversationReferUsers>();
            CrmConversationStatus = new HashSet<CrmConversationStatus>();
            CrmConversationStatusGroupsFocnvsReferUser = new HashSet<CrmConversationStatusGroups>();
            CrmConversationStatusGroupsUser = new HashSet<CrmConversationStatusGroups>();
            CrmConversationTmpCnvsFirstRegisterUser = new HashSet<CrmConversationTmp>();
            CrmConversationTmpCnvsReferUser = new HashSet<CrmConversationTmp>();
            CrmConversationTmpCnvsUser = new HashSet<CrmConversationTmp>();
            CrmConversationTmpFirstRegisterUser = new HashSet<CrmConversationTmp>();
            CrmConversationTmpUser = new HashSet<CrmConversationTmp>();
            CrmConversationTopics = new HashSet<CrmConversationTopics>();
            CrmConversationUser = new HashSet<CrmConversation>();
            CrmDyFormFieldMasterValueDetailsCheckerUser = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldMasterValueDetailsFirstRegisterUser = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldMasterValueDetailsUser = new HashSet<CrmDyFormFieldMasterValueDetails>();
            CrmDyFormFieldMasterValuesCheckerUser = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldMasterValuesFirstRegisterUser = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldMasterValuesUser = new HashSet<CrmDyFormFieldMasterValues>();
            CrmDyFormFieldTypesFirstRegisterUser = new HashSet<CrmDyFormFieldTypes>();
            CrmDyFormFieldTypesUser = new HashSet<CrmDyFormFieldTypes>();
            CrmDyFormFieldValuesFirstRegisterUser = new HashSet<CrmDyFormFieldValues>();
            CrmDyFormFieldValuesUser = new HashSet<CrmDyFormFieldValues>();
            CrmDyFormFieldsFirstRegisterUser = new HashSet<CrmDyFormFields>();
            CrmDyFormFieldsUser = new HashSet<CrmDyFormFields>();
            CrmDyFormRegularExpressionsFirstRegisterUser = new HashSet<CrmDyFormRegularExpressions>();
            CrmDyFormRegularExpressionsUser = new HashSet<CrmDyFormRegularExpressions>();
            CrmDyFormUserAccessCrmUser = new HashSet<CrmDyFormUserAccess>();
            CrmDyFormUserAccessFirstRegisterUser = new HashSet<CrmDyFormUserAccess>();
            CrmDyFormUserAccessUser = new HashSet<CrmDyFormUserAccess>();
            CrmDyFormWorkflowStepsFirstRegisterUser = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyFormWorkflowStepsUser = new HashSet<CrmDyFormWorkflowSteps>();
            CrmDyFormWorkflowsFirstRegisterUser = new HashSet<CrmDyFormWorkflows>();
            CrmDyFormWorkflowsUser = new HashSet<CrmDyFormWorkflows>();
            CrmDyFormsFirstRegisterUser = new HashSet<CrmDyForms>();
            CrmDyFormsUser = new HashSet<CrmDyForms>();
            CrmFileDirectoryType = new HashSet<CrmFileDirectoryType>();
            CrmFileDirectoryTypeOpr = new HashSet<CrmFileDirectoryTypeOpr>();
            CrmFilesDirectory = new HashSet<CrmFilesDirectory>();
            CrmFilesDirectoryTemplate = new HashSet<CrmFilesDirectoryTemplate>();
            CrmFilesDirectoryTemplateType = new HashSet<CrmFilesDirectoryTemplateType>();
            CrmFoSettingCmpDefaultReferUser = new HashSet<CrmFoSetting>();
            CrmFoSettingCnvsDefaultReferUser = new HashSet<CrmFoSetting>();
            CrmFoSettingCnvsDefaultUser = new HashSet<CrmFoSetting>();
            CrmFoSettingFirstRegisterUser = new HashSet<CrmFoSetting>();
            CrmFoSettingPrjDefaultStarterUser = new HashSet<CrmFoSetting>();
            CrmFoSettingUser = new HashSet<CrmFoSetting>();
            CrmFundCrmUser = new HashSet<CrmFund>();
            CrmFundFirstRegisterUser = new HashSet<CrmFund>();
            CrmFundGroupsFirstRegisterUser = new HashSet<CrmFundGroups>();
            CrmFundGroupsUser = new HashSet<CrmFundGroups>();
            CrmFundUser = new HashSet<CrmFund>();
            CrmInternalMessage = new HashSet<CrmInternalMessage>();
            CrmInternalMessageDefaultContext = new HashSet<CrmInternalMessageDefaultContext>();
            CrmInternalMessageDetailsFirstRegisterUser = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageDetailsMsgdFromUser = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageDetailsMsgdToUser = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageDetailsUser = new HashSet<CrmInternalMessageDetails>();
            CrmInternalMessageGroup = new HashSet<CrmInternalMessageGroup>();
            CrmInternalMessagePriority = new HashSet<CrmInternalMessagePriority>();
            CrmInternalMessageSelectReceiver = new HashSet<CrmInternalMessageSelectReceiver>();
            CrmInternalMessageTreeTypeFirstRegisterUser = new HashSet<CrmInternalMessageTreeType>();
            CrmInternalMessageTreeTypeUser = new HashSet<CrmInternalMessageTreeType>();
            CrmInternalMessageType = new HashSet<CrmInternalMessageType>();
            CrmKnowledgeTank = new HashSet<CrmKnowledgeTank>();
            CrmKnowledgeTankGroup = new HashSet<CrmKnowledgeTankGroup>();
            CrmKnowledgeTankGroupPermissionFirstRegisterUser = new HashSet<CrmKnowledgeTankGroupPermission>();
            CrmKnowledgeTankGroupPermissionUser = new HashSet<CrmKnowledgeTankGroupPermission>();
            CrmKnowledgeTankPriority = new HashSet<CrmKnowledgeTankPriority>();
            CrmLeave = new HashSet<CrmLeave>();
            CrmLeaveKinds = new HashSet<CrmLeaveKinds>();
            CrmLeaveStatus = new HashSet<CrmLeaveStatus>();
            CrmLeaveStayType = new HashSet<CrmLeaveStayType>();
            CrmLeaveType = new HashSet<CrmLeaveType>();
            CrmLeaveVehicleType = new HashSet<CrmLeaveVehicleType>();
            CrmLinkAccNoAvSettingDetailsFirstRegisterUser = new HashSet<CrmLinkAccNoAvSettingDetails>();
            CrmLinkAccNoAvSettingDetailsUser = new HashSet<CrmLinkAccNoAvSettingDetails>();
            CrmLinkAccNoAvSettingFirstRegisterUser = new HashSet<CrmLinkAccNoAvSetting>();
            CrmLinkAccNoAvSettingUser = new HashSet<CrmLinkAccNoAvSetting>();
            CrmLinkAccSettingDetailsFirstRegisterUser = new HashSet<CrmLinkAccSettingDetails>();
            CrmLinkAccSettingDetailsUser = new HashSet<CrmLinkAccSettingDetails>();
            CrmLinkAccSettingFirstRegisterUser = new HashSet<CrmLinkAccSetting>();
            CrmLinkAccSettingUser = new HashSet<CrmLinkAccSetting>();
            CrmLinkAccSystemsFirstRegisterUser = new HashSet<CrmLinkAccSystems>();
            CrmLinkAccSystemsUser = new HashSet<CrmLinkAccSystems>();
            CrmLinkAccTarazSettingDetailsFirstRegisterUser = new HashSet<CrmLinkAccTarazSettingDetails>();
            CrmLinkAccTarazSettingDetailsUser = new HashSet<CrmLinkAccTarazSettingDetails>();
            CrmLinkAccTarazSettingFirstRegisterUser = new HashSet<CrmLinkAccTarazSetting>();
            CrmLinkAccTarazSettingUser = new HashSet<CrmLinkAccTarazSetting>();
            CrmLinkedCompanyFirstRegisterUser = new HashSet<CrmLinkedCompany>();
            CrmLinkedCompanyUser = new HashSet<CrmLinkedCompany>();
            CrmLinkedType = new HashSet<CrmLinkedType>();
            CrmLinkedUsersCrmUser = new HashSet<CrmLinkedUsers>();
            CrmLinkedUsersFirstRegisterUser = new HashSet<CrmLinkedUsers>();
            CrmLinkedUsersLinkedUser = new HashSet<CrmLinkedUsers>();
            CrmLinkedUsersUser = new HashSet<CrmLinkedUsers>();
            CrmOperationsTypeFirstRegisterUser = new HashSet<CrmOperationsType>();
            CrmOperationsTypeUser = new HashSet<CrmOperationsType>();
            CrmPersonDepartments = new HashSet<CrmPersonDepartments>();
            CrmPersonGroups = new HashSet<CrmPersonGroups>();
            CrmPersonJobs = new HashSet<CrmPersonJobs>();
            CrmPersonPictureFirstRegisterUser = new HashSet<CrmPersonPicture>();
            CrmPersonPictureUser = new HashSet<CrmPersonPicture>();
            CrmPersonTitle = new HashSet<CrmPersonTitle>();
            CrmPersonType = new HashSet<CrmPersonType>();
            CrmProjectDefualtValue = new HashSet<CrmProjectDefualtValue>();
            CrmProjectFieldTitle = new HashSet<CrmProjectFieldTitle>();
            CrmProjectFieldValueType = new HashSet<CrmProjectFieldValueType>();
            CrmProjectGrade = new HashSet<CrmProjectGrade>();
            CrmProjectGroups = new HashSet<CrmProjectGroups>();
            CrmProjectGroupsMulti = new HashSet<CrmProjectGroupsMulti>();
            CrmProjectGroupsMultiI = new HashSet<CrmProjectGroupsMultiI>();
            CrmProjectInformationsFirstRegisterUser = new HashSet<CrmProjectInformations>();
            CrmProjectInformationsUser = new HashSet<CrmProjectInformations>();
            CrmProjectMultiGroupsFirstRegisterUser = new HashSet<CrmProjectMultiGroups>();
            CrmProjectMultiGroupsUser = new HashSet<CrmProjectMultiGroups>();
            CrmProjectMultiIgroupsFirstRegisterUser = new HashSet<CrmProjectMultiIgroups>();
            CrmProjectMultiIgroupsUser = new HashSet<CrmProjectMultiIgroups>();
            CrmProjectPriorityFirstRegisterUser = new HashSet<CrmProjectPriority>();
            CrmProjectPriorityUser = new HashSet<CrmProjectPriority>();
            CrmProjectTitlesFirstRegisterUser = new HashSet<CrmProjectTitles>();
            CrmProjectTitlesUser = new HashSet<CrmProjectTitles>();
            CrmProjectsFirstRegisterUser = new HashSet<CrmProjects>();
            CrmProjectsForbiddenForUserCrmUser = new HashSet<CrmProjectsForbiddenForUser>();
            CrmProjectsForbiddenForUserFirstRegisterUser = new HashSet<CrmProjectsForbiddenForUser>();
            CrmProjectsForbiddenForUserUser = new HashSet<CrmProjectsForbiddenForUser>();
            CrmProjectsPrjFinishedUser = new HashSet<CrmProjects>();
            CrmProjectsPrjFirstRegisterUser = new HashSet<CrmProjects>();
            CrmProjectsPrjStarterUser = new HashSet<CrmProjects>();
            CrmProjectsTmpFirstRegisterUser = new HashSet<CrmProjectsTmp>();
            CrmProjectsTmpPrjFinishedUser = new HashSet<CrmProjectsTmp>();
            CrmProjectsTmpPrjFirstRegisterUser = new HashSet<CrmProjectsTmp>();
            CrmProjectsTmpPrjStarterUser = new HashSet<CrmProjectsTmp>();
            CrmProjectsTmpUser = new HashSet<CrmProjectsTmp>();
            CrmProjectsUser = new HashSet<CrmProjects>();
            CrmShowTableFieldInFoFirstRegisterUser = new HashSet<CrmShowTableFieldInFo>();
            CrmShowTableFieldInFoUser = new HashSet<CrmShowTableFieldInFo>();
            CrmSystemPartsFirstRegisterUser = new HashSet<CrmSystemParts>();
            CrmSystemPartsUser = new HashSet<CrmSystemParts>();
            CrmTelegBotChatMessage = new HashSet<CrmTelegBotChatMessage>();
            CrmTelegBotContactsFirstRegisterUser = new HashSet<CrmTelegBotContacts>();
            CrmTelegBotContactsUser = new HashSet<CrmTelegBotContacts>();
            CrmTelegBotSettingFirstRegisterUser = new HashSet<CrmTelegBotSetting>();
            CrmTelegBotSettingUser = new HashSet<CrmTelegBotSetting>();
            CrmTelegChatMessage = new HashSet<CrmTelegChatMessage>();
            CrmTelegContactsFirstRegisterUser = new HashSet<CrmTelegContacts>();
            CrmTelegContactsUser = new HashSet<CrmTelegContacts>();
            CrmTelegSettingFirstRegisterUser = new HashSet<CrmTelegSetting>();
            CrmTelegSettingUser = new HashSet<CrmTelegSetting>();
            CrmTempEmailsFirstRegisterUser = new HashSet<CrmTempEmails>();
            CrmTempEmailsPrsRegisterUser = new HashSet<CrmTempEmails>();
            CrmTempEmailsUser = new HashSet<CrmTempEmails>();
            CrmTimeAttendanceBaseFirstRegisterUser = new HashSet<CrmTimeAttendanceBase>();
            CrmTimeAttendanceBaseUser = new HashSet<CrmTimeAttendanceBase>();
            CrmTimeAttendanceFirstRegisterUser = new HashSet<CrmTimeAttendance>();
            CrmTimeAttendanceLogFirstRegisterUser = new HashSet<CrmTimeAttendanceLog>();
            CrmTimeAttendanceLogTmlUser = new HashSet<CrmTimeAttendanceLog>();
            CrmTimeAttendanceLogUser = new HashSet<CrmTimeAttendanceLog>();
            CrmTimeAttendanceTmUser = new HashSet<CrmTimeAttendance>();
            CrmTimeAttendanceUser = new HashSet<CrmTimeAttendance>();
            CrmUserNotesFirstRegisterUser = new HashSet<CrmUserNotes>();
            CrmUserNotesUser = new HashSet<CrmUserNotes>();
            CrmUserTaskGroupsFirstRegisterUser = new HashSet<CrmUserTaskGroups>();
            CrmUserTaskGroupsUser = new HashSet<CrmUserTaskGroups>();
            CrmUserTaskPrioritiesFirstRegisterUser = new HashSet<CrmUserTaskPriorities>();
            CrmUserTaskPrioritiesUser = new HashSet<CrmUserTaskPriorities>();
            CrmUserTasksFirstRegisterUser = new HashSet<CrmUserTasks>();
            CrmUserTasksUser = new HashSet<CrmUserTasks>();
            CrmVersionUpgrade = new HashSet<CrmVersionUpgrade>();
            CrmVersionUpgradeDetails = new HashSet<CrmVersionUpgradeDetails>();
            CrmVersions = new HashSet<CrmVersions>();
            CrmWebSettingFirstRegisterUser = new HashSet<CrmWebSetting>();
            CrmWebSettingUser = new HashSet<CrmWebSetting>();
            CrmsysCideviceType = new HashSet<CrmsysCideviceType>();
            CrmsysCipopUpSettingFirstRegisterUser = new HashSet<CrmsysCipopUpSetting>();
            CrmsysCipopUpSettingUser = new HashSet<CrmsysCipopUpSetting>();
            CrmsysCisetting = new HashSet<CrmsysCisetting>();
            CrmsysDbobjects = new HashSet<CrmsysDbobjects>();
            CrmsysDbtempInfoFirstRegisterUser = new HashSet<CrmsysDbtempInfo>();
            CrmsysDbtempInfoType = new HashSet<CrmsysDbtempInfoType>();
            CrmsysDbtempInfoUser = new HashSet<CrmsysDbtempInfo>();
            CrmsysFormActions = new HashSet<CrmsysFormActions>();
            CrmsysFormObjectPropertiesFirstRegisterUser = new HashSet<CrmsysFormObjectProperties>();
            CrmsysFormObjectPropertiesUser = new HashSet<CrmsysFormObjectProperties>();
            CrmsysForms = new HashSet<CrmsysForms>();
            CrmsysRollPermission = new HashSet<CrmsysRollPermission>();
            CrmsysRolls = new HashSet<CrmsysRolls>();
            CrmsysSettingFirstRegisterUser = new HashSet<CrmsysSetting>();
            CrmsysSettingUser = new HashSet<CrmsysSetting>();
            CrmtmpManageTellNumberFirstRegisterUser = new HashSet<CrmtmpManageTellNumber>();
            CrmtmpManageTellNumberUser = new HashSet<CrmtmpManageTellNumber>();
            EducationFirstRegisterUser = new HashSet<Education>();
            EducationUser = new HashSet<Education>();
            EmailDefaultBodyTextFirstRegisterUser = new HashSet<EmailDefaultBodyText>();
            EmailDefaultBodyTextUser = new HashSet<EmailDefaultBodyText>();
            EmailReceiveAttachmentsFirstRegisterUser = new HashSet<EmailReceiveAttachments>();
            EmailReceiveAttachmentsUser = new HashSet<EmailReceiveAttachments>();
            EmailReceiveFirstRegisterUser = new HashSet<EmailReceive>();
            EmailReceiveFoldersFirstRegisterUser = new HashSet<EmailReceiveFolders>();
            EmailReceiveFoldersUser = new HashSet<EmailReceiveFolders>();
            EmailReceiveUser = new HashSet<EmailReceive>();
            EmailSendAttachment = new HashSet<EmailSendAttachment>();
            EmailSendDetail = new HashSet<EmailSendDetail>();
            EmailSendHeaderFirstRegisterUser = new HashSet<EmailSendHeader>();
            EmailSendHeaderUser = new HashSet<EmailSendHeader>();
            EmailSettingFirstRegisterUser = new HashSet<EmailSetting>();
            EmailSettingUser = new HashSet<EmailSetting>();
            EmailUserDefaultSettingFirstRegisterUser = new HashSet<EmailUserDefaultSetting>();
            EmailUserDefaultSettingUser = new HashSet<EmailUserDefaultSetting>();
            EmailUserTempTankFirstRegisterUser = new HashSet<EmailUserTempTank>();
            EmailUserTempTankUser = new HashSet<EmailUserTempTank>();
            EmailUsersInfoEuUser = new HashSet<EmailUsersInfo>();
            EmailUsersInfoFirstRegisterUser = new HashSet<EmailUsersInfo>();
            EmailUsersInfoUser = new HashSet<EmailUsersInfo>();
            InverseUserId1Navigation = new HashSet<Users>();
            LanguagesFirstRegisterUser = new HashSet<Languages>();
            LanguagesUser = new HashSet<Languages>();
            MobApiAndTableDetailFirstRegisterUser = new HashSet<MobApiAndTableDetail>();
            MobApiAndTableDetailUser = new HashSet<MobApiAndTableDetail>();
            MobCompanyAppInfoFirstRegisterUser = new HashSet<MobCompanyAppInfo>();
            MobCompanyAppInfoUser = new HashSet<MobCompanyAppInfo>();
            MyWebsites = new HashSet<MyWebsites>();
            PayRollItemTypesFirstRegisterUser = new HashSet<PayRollItemTypes>();
            PayRollItemTypesUser = new HashSet<PayRollItemTypes>();
            PayRollItemsFirstRegisterUser = new HashSet<PayRollItems>();
            PayRollItemsUser = new HashSet<PayRollItems>();
            PayRollUserCycleCrmUser = new HashSet<PayRollUserCycle>();
            PayRollUserCycleCycleVerifierUser = new HashSet<PayRollUserCycle>();
            PayRollUserCycleFirstRegisterUser = new HashSet<PayRollUserCycle>();
            PayRollUserCycleItemValuesCrmUser = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserCycleItemValuesFirstRegisterUser = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserCycleItemValuesUser = new HashSet<PayRollUserCycleItemValues>();
            PayRollUserCycleUser = new HashSet<PayRollUserCycle>();
            PayRollUserDefaultItemsCrmUser = new HashSet<PayRollUserDefaultItems>();
            PayRollUserDefaultItemsFirstRegisterUser = new HashSet<PayRollUserDefaultItems>();
            PayRollUserDefaultItemsUser = new HashSet<PayRollUserDefaultItems>();
            PayRollUserPaymentTypesFirstRegisterUser = new HashSet<PayRollUserPaymentTypes>();
            PayRollUserPaymentTypesUser = new HashSet<PayRollUserPaymentTypes>();
            PayRollUserPaymentsFirstRegisterUser = new HashSet<PayRollUserPayments>();
            PayRollUserPaymentsUser = new HashSet<PayRollUserPayments>();
            PrintFormatFirstRegisterUser = new HashSet<PrintFormat>();
            PrintFormatTypeFirstRegisterUser = new HashSet<PrintFormatType>();
            PrintFormatTypeUser = new HashSet<PrintFormatType>();
            PrintFormatUser = new HashSet<PrintFormat>();
            Projects = new HashSet<Projects>();
            ProvinceFirstRegisterUser = new HashSet<Province>();
            ProvinceUser = new HashSet<Province>();
            SecLetterDefaultSettingsFirstRegisterUser = new HashSet<SecLetterDefaultSettings>();
            SecLetterDefaultSettingsLdreferUser = new HashSet<SecLetterDefaultSettings>();
            SecLetterDefaultSettingsLdverifierRequest = new HashSet<SecLetterDefaultSettings>();
            SecLetterDefaultSettingsUser = new HashSet<SecLetterDefaultSettings>();
            SecLetterTypeFirstRegisterUser = new HashSet<SecLetterType>();
            SecLetterTypeUser = new HashSet<SecLetterType>();
            SecLettersFirstRegisterUser = new HashSet<SecLetters>();
            SecLettersLetterVerifier = new HashSet<SecLetters>();
            SecLettersLetterVerifierRequest = new HashSet<SecLetters>();
            SecLettersUser = new HashSet<SecLetters>();
            SexFirstRegisterUser = new HashSet<Sex>();
            SexUser = new HashSet<Sex>();
            SmsDefaultBodyTextFirstRegisterUser = new HashSet<SmsDefaultBodyText>();
            SmsDefaultBodyTextGroupsFirstRegisterUser = new HashSet<SmsDefaultBodyTextGroups>();
            SmsDefaultBodyTextGroupsUser = new HashSet<SmsDefaultBodyTextGroups>();
            SmsDefaultBodyTextUser = new HashSet<SmsDefaultBodyText>();
            SmsDeliveryStatus = new HashSet<SmsDeliveryStatus>();
            SmsGsmmodemDelivery = new HashSet<SmsGsmmodemDelivery>();
            SmsGsmmodemSettingFirstRegisterUser = new HashSet<SmsGsmmodemSetting>();
            SmsGsmmodemSettingUser = new HashSet<SmsGsmmodemSetting>();
            SmsGsmreceives = new HashSet<SmsGsmreceives>();
            SmsGsmsendingTank = new HashSet<SmsGsmsendingTank>();
            SmsProvidersFirstRegisterUser = new HashSet<SmsProviders>();
            SmsProvidersUser = new HashSet<SmsProviders>();
            SmsReceiveFirstRegisterUser = new HashSet<SmsReceive>();
            SmsReceiveFromWsdl = new HashSet<SmsReceiveFromWsdl>();
            SmsReceiveUser = new HashSet<SmsReceive>();
            SmsSendDetailFirstRegisterUser = new HashSet<SmsSendDetail>();
            SmsSendDetailSendUser = new HashSet<SmsSendDetail>();
            SmsSendDetailUser = new HashSet<SmsSendDetail>();
            SmsSendHeaderFirstRegisterUser = new HashSet<SmsSendHeader>();
            SmsSendHeaderSendUser = new HashSet<SmsSendHeader>();
            SmsSendHeaderUser = new HashSet<SmsSendHeader>();
            SmsSendType = new HashSet<SmsSendType>();
            SmsSettingFirstRegisterUser = new HashSet<SmsSetting>();
            SmsSettingUser = new HashSet<SmsSetting>();
            SmsTempMobileNumbersFirstRegisterUser = new HashSet<SmsTempMobileNumbers>();
            SmsTempMobileNumbersUser = new HashSet<SmsTempMobileNumbers>();
            SmsUserSendCreditCreditUser = new HashSet<SmsUserSendCredit>();
            SmsUserSendCreditFirstRegisterUser = new HashSet<SmsUserSendCredit>();
            SmsUserSendCreditUser = new HashSet<SmsUserSendCredit>();
            UserDepartmentTicketReferUsersFirstRegisterUser = new HashSet<UserDepartmentTicketReferUsers>();
            UserDepartmentTicketReferUsersReferUser = new HashSet<UserDepartmentTicketReferUsers>();
            UserDepartmentTicketReferUsersUser = new HashSet<UserDepartmentTicketReferUsers>();
            UserDepartmentsFirstRegisterUser = new HashSet<UserDepartments>();
            UserDepartmentsUser = new HashSet<UserDepartments>();
            UserLanguagesFirstRegisterUser = new HashSet<UserLanguages>();
            UserLanguagesUser = new HashSet<UserLanguages>();
            UserLanguagesUserId1Navigation = new HashSet<UserLanguages>();
            UserLoginAllowedTimesCrmUser = new HashSet<UserLoginAllowedTimes>();
            UserLoginAllowedTimesFirstRegisterUser = new HashSet<UserLoginAllowedTimes>();
            UserLoginAllowedTimesFirstUser = new HashSet<UserLoginAllowedTimes>();
            UserLoginAllowedTimesUser = new HashSet<UserLoginAllowedTimes>();
            UserSignatureFirstRegisterUser = new HashSet<UserSignature>();
            UserSignatureSignatureUser = new HashSet<UserSignature>();
            UserSignatureUser = new HashSet<UserSignature>();
            UsersLang = new HashSet<UsersLang>();
            UsersPermissionFirstRegisterUser = new HashSet<UsersPermission>();
            UsersPermissionUser = new HashSet<UsersPermission>();
            WsWareHouseFirstRegisterUser = new HashSet<WsWareHouse>();
            WsWareHouseUser = new HashSet<WsWareHouse>();
            WsbuyOrderBordFirstRegisterUser = new HashSet<WsbuyOrder>();
            WsbuyOrderBordReferUser = new HashSet<WsbuyOrder>();
            WsbuyOrderBordVerifier = new HashSet<WsbuyOrder>();
            WsbuyOrderFirstRegisterUser = new HashSet<WsbuyOrder>();
            WsbuyOrderItemSerialsFirstRegisterUser = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItemSerialsUser = new HashSet<WsbuyOrderItemSerials>();
            WsbuyOrderItemsFirstRegisterUser = new HashSet<WsbuyOrderItems>();
            WsbuyOrderItemsUser = new HashSet<WsbuyOrderItems>();
            WsbuyOrderOpr = new HashSet<WsbuyOrderOpr>();
            WsbuyOrderPaymentTypesFirstRegisterUser = new HashSet<WsbuyOrderPaymentTypes>();
            WsbuyOrderPaymentTypesUser = new HashSet<WsbuyOrderPaymentTypes>();
            WsbuyOrderPaymentsBordpayFirstRegisterUser = new HashSet<WsbuyOrderPayments>();
            WsbuyOrderPaymentsFirstRegisterUser = new HashSet<WsbuyOrderPayments>();
            WsbuyOrderPaymentsUser = new HashSet<WsbuyOrderPayments>();
            WsbuyOrderStatusFirstRegisterUser = new HashSet<WsbuyOrderStatus>();
            WsbuyOrderStatusUser = new HashSet<WsbuyOrderStatus>();
            WsbuyOrderUser = new HashSet<WsbuyOrder>();
            WscreditDurationFirstRegisterUser = new HashSet<WscreditDuration>();
            WscreditDurationUser = new HashSet<WscreditDuration>();
            WscurrencyUnitsFirstRegisterUser = new HashSet<WscurrencyUnits>();
            WscurrencyUnitsUser = new HashSet<WscurrencyUnits>();
            WsdeliveryTimeFirstRegisterUser = new HashSet<WsdeliveryTime>();
            WsdeliveryTimeUser = new HashSet<WsdeliveryTime>();
            WsdocFirstRegisterUser = new HashSet<Wsdoc>();
            WsdocItemSerialsFirstRegisterUser = new HashSet<WsdocItemSerials>();
            WsdocItemSerialsUser = new HashSet<WsdocItemSerials>();
            WsdocItemsFirstRegisterUser = new HashSet<WsdocItems>();
            WsdocItemsUser = new HashSet<WsdocItems>();
            WsdocOpr = new HashSet<WsdocOpr>();
            WsdocUser = new HashSet<Wsdoc>();
            WsfinancialPeriodFirstRegisterUser = new HashSet<WsfinancialPeriod>();
            WsfinancialPeriodUser = new HashSet<WsfinancialPeriod>();
            WsguarantyFirstRegisterUser = new HashSet<Wsguaranty>();
            WsguarantyUser = new HashSet<Wsguaranty>();
            WslinkedProductsFirstRegisterUser = new HashSet<WslinkedProducts>();
            WslinkedProductsUser = new HashSet<WslinkedProducts>();
            WslogoFirstRegisterUser = new HashSet<Wslogo>();
            WslogoUser = new HashSet<Wslogo>();
            WsorderCommissionPayTypesFirstRegisterUser = new HashSet<WsorderCommissionPayTypes>();
            WsorderCommissionPayTypesUser = new HashSet<WsorderCommissionPayTypes>();
            WsorderCommissionsCommIsPaidUser = new HashSet<WsorderCommissions>();
            WsorderCommissionsCommUser = new HashSet<WsorderCommissions>();
            WsorderCommissionsCommVerifierUser = new HashSet<WsorderCommissions>();
            WsorderCommissionsFirstRegisterUser = new HashSet<WsorderCommissions>();
            WsorderCommissionsUser = new HashSet<WsorderCommissions>();
            WsorderDefaultSettingFirstRegisterUser = new HashSet<WsorderDefaultSetting>();
            WsorderDefaultSettingReferUser = new HashSet<WsorderDefaultSetting>();
            WsorderDefaultSettingUser = new HashSet<WsorderDefaultSetting>();
            WsorderFirstRegisterUser = new HashSet<Wsorder>();
            WsorderItemSerialsFirstRegisterUser = new HashSet<WsorderItemSerials>();
            WsorderItemSerialsUser = new HashSet<WsorderItemSerials>();
            WsorderItemsFirstRegisterUser = new HashSet<WsorderItems>();
            WsorderItemsUser = new HashSet<WsorderItems>();
            WsorderOpr = new HashSet<WsorderOpr>();
            WsorderOrdFirstRegisterUser = new HashSet<Wsorder>();
            WsorderOrdReferUser = new HashSet<Wsorder>();
            WsorderOrdVerifier = new HashSet<Wsorder>();
            WsorderOrdVerifierRequest = new HashSet<Wsorder>();
            WsorderPaymentTypesFirstRegisterUser = new HashSet<WsorderPaymentTypes>();
            WsorderPaymentTypesUser = new HashSet<WsorderPaymentTypes>();
            WsorderPaymentsFirstRegisterUser = new HashSet<WsorderPayments>();
            WsorderPaymentsOrdpayFirstRegisterUser = new HashSet<WsorderPayments>();
            WsorderPaymentsUser = new HashSet<WsorderPayments>();
            WsorderPreOrderVerifier = new HashSet<Wsorder>();
            WsorderStatusFirstRegisterUser = new HashSet<WsorderStatus>();
            WsorderStatusUser = new HashSet<WsorderStatus>();
            WsorderUser = new HashSet<Wsorder>();
            WspayConditionFirstRegisterUser = new HashSet<WspayCondition>();
            WspayConditionUser = new HashSet<WspayCondition>();
            WspreOrderDefaultSettingFirstRegisterUser = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderDefaultSettingReferUser = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderDefaultSettingUser = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderDefaultSettingVerifierRequest = new HashSet<WspreOrderDefaultSetting>();
            WspreOrderFirstRegisterUser = new HashSet<WspreOrder>();
            WspreOrderItemSpecificationFirstRegisterUser = new HashSet<WspreOrderItemSpecification>();
            WspreOrderItemSpecificationUser = new HashSet<WspreOrderItemSpecification>();
            WspreOrderItemsFirstRegisterUser = new HashSet<WspreOrderItems>();
            WspreOrderItemsUser = new HashSet<WspreOrderItems>();
            WspreOrderOprFirstRegisterUser = new HashSet<WspreOrderOpr>();
            WspreOrderOprUser = new HashSet<WspreOrderOpr>();
            WspreOrderPaymentsFirstRegisterUser = new HashSet<WspreOrderPayments>();
            WspreOrderPaymentsPordpayFirstRegisterUser = new HashSet<WspreOrderPayments>();
            WspreOrderPaymentsUser = new HashSet<WspreOrderPayments>();
            WspreOrderPordFirstRegisterUser = new HashSet<WspreOrder>();
            WspreOrderPordReferUser = new HashSet<WspreOrder>();
            WspreOrderPordVerifier = new HashSet<WspreOrder>();
            WspreOrderPordVerifierRequest = new HashSet<WspreOrder>();
            WspreOrderPrdGroupMustExistReasonsFirstRegisterUser = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            WspreOrderPrdGroupMustExistReasonsUser = new HashSet<WspreOrderPrdGroupMustExistReasons>();
            WspreOrderStatusFirstRegisterUser = new HashSet<WspreOrderStatus>();
            WspreOrderStatusUser = new HashSet<WspreOrderStatus>();
            WspreOrderUser = new HashSet<WspreOrder>();
            WsproductColorFirstRegisterUser = new HashSet<WsproductColor>();
            WsproductColorUser = new HashSet<WsproductColor>();
            WsproductCostFirstRegisterUser = new HashSet<WsproductCost>();
            WsproductCostGroupFirstRegisterUser = new HashSet<WsproductCostGroup>();
            WsproductCostGroupUser = new HashSet<WsproductCostGroup>();
            WsproductCostUser = new HashSet<WsproductCost>();
            WsproductFirstGroup = new HashSet<WsproductFirstGroup>();
            WsproductGalleryFirstRegisterUser = new HashSet<WsproductGallery>();
            WsproductGalleryUser = new HashSet<WsproductGallery>();
            WsproductImportFromExcelFields = new HashSet<WsproductImportFromExcelFields>();
            WsproductImportFromExcelFirstRegisterUser = new HashSet<WsproductImportFromExcel>();
            WsproductImportFromExcelUser = new HashSet<WsproductImportFromExcel>();
            WsproductPictureFirstRegisterUser = new HashSet<WsproductPicture>();
            WsproductPictureUser = new HashSet<WsproductPicture>();
            WsproductPriceFirstRegisterUser = new HashSet<WsproductPrice>();
            WsproductPriceGroupFirstRegisterUser = new HashSet<WsproductPriceGroup>();
            WsproductPriceGroupUser = new HashSet<WsproductPriceGroup>();
            WsproductPriceUser = new HashSet<WsproductPrice>();
            WsproductSecondGroupFirstRegisterUser = new HashSet<WsproductSecondGroup>();
            WsproductSecondGroupUser = new HashSet<WsproductSecondGroup>();
            WsproductShpStockManageTypesFirstRegisterUser = new HashSet<WsproductShpStockManageTypes>();
            WsproductShpStockManageTypesUser = new HashSet<WsproductShpStockManageTypes>();
            WsproductSpecificationFirstRegisterUser = new HashSet<WsproductSpecification>();
            WsproductSpecificationUser = new HashSet<WsproductSpecification>();
            WsproductUnitsFirstRegisterUser = new HashSet<WsproductUnits>();
            WsproductUnitsUser = new HashSet<WsproductUnits>();
            WsproductsFirstRegisterUser = new HashSet<Wsproducts>();
            WsproductsRateFirstRegisterUser = new HashSet<WsproductsRate>();
            WsproductsRateUser = new HashSet<WsproductsRate>();
            WsproductsUser = new HashSet<Wsproducts>();
            WsproductsUserDiscountDiscountUser = new HashSet<WsproductsUserDiscount>();
            WsproductsUserDiscountFirstRegisterUser = new HashSet<WsproductsUserDiscount>();
            WsproductsUserDiscountUser = new HashSet<WsproductsUserDiscount>();
            WsregisterBarCode = new HashSet<WsregisterBarCode>();
            WssettlementTypeFirstRegisterUser = new HashSet<WssettlementType>();
            WssettlementTypeUser = new HashSet<WssettlementType>();
            WssignatureFirstRegisterUser = new HashSet<Wssignature>();
            WssignatureUser = new HashSet<Wssignature>();
            WstmpEnterBarcodeOperation = new HashSet<WstmpEnterBarcodeOperation>();
            WstmpEnterDocPrdWithBarcode = new HashSet<WstmpEnterDocPrdWithBarcode>();
            WstmpUserItemCopyFirstRegisterUser = new HashSet<WstmpUserItemCopy>();
            WstmpUserItemCopyUser = new HashSet<WstmpUserItemCopy>();
            WsuserFavproductItemsFirstRegisterUser = new HashSet<WsuserFavproductItems>();
            WsuserFavproductItemsUser = new HashSet<WsuserFavproductItems>();
            WsuserFavproductsFirstRegisterUser = new HashSet<WsuserFavproducts>();
            WsuserFavproductsUser = new HashSet<WsuserFavproducts>();
            WsverificationRequestDetailsFirstRegisterUser = new HashSet<WsverificationRequestDetails>();
            WsverificationRequestDetailsUser = new HashSet<WsverificationRequestDetails>();
            WsverificationRequestDetailsVerifyUser = new HashSet<WsverificationRequestDetails>();
            WsverificationRequestsFirstRegisterUser = new HashSet<WsverificationRequests>();
            WsverificationRequestsUser = new HashSet<WsverificationRequests>();
            WsverificationRequestsVerificationReqUser = new HashSet<WsverificationRequests>();
            WsverificationWorkFlowStepsAlternateVerifyUser = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowStepsFirstRegisterUser = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowStepsUser = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowStepsVerifyUser = new HashSet<WsverificationWorkFlowSteps>();
            WsverificationWorkFlowsFirstRegisterUser = new HashSet<WsverificationWorkFlows>();
            WsverificationWorkFlowsUser = new HashSet<WsverificationWorkFlows>();
        }

        public int UserId { get; set; }
        public int? Row { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string PersCode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string IsAdmin { get; set; }
        public bool? IsActive { get; set; }
        public string Description { get; set; }
        public int? UserId1 { get; set; }
        public short? Month1 { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string RegisterDatePersian { get; set; }
        public string Ipaddress { get; set; }
        public string Tel { get; set; }
        public string TelDesc { get; set; }
        public int? PositionId { get; set; }
        public int? SignatureId { get; set; }
        public int? DepartmentId { get; set; }
        public int? ResponsibleUserId { get; set; }
        public string ComputerName { get; set; }
        public Guid? Guid { get; set; }
        public bool? CallreIdDeActive { get; set; }
        public string CallreIdDeActiveLines { get; set; }
        public bool? DisableInternalMessageAllarmVoice { get; set; }
        public bool? DisableReceiveCnvsinfoAllarm { get; set; }
        public string EmailAttachFileLocation { get; set; }
        public string AppType { get; set; }
        public bool? CanSetFree { get; set; }
        public string UserCipatternFormulaPopUp { get; set; }
        public bool? UseClientNameForNetworking { get; set; }
        public int? LanguageId { get; set; }
        public bool? AllowCopyOtherLanguage { get; set; }
        public int? FirstRegisterUserId { get; set; }
        public string FirstRegisterDatePersian { get; set; }
        public DateTime? FirstRegisterDate { get; set; }
        public bool? UserIsActiveInWinApp { get; set; }
        public bool? UserIsActiveInWebApp { get; set; }
        public bool? UserIsActiveInMobApp { get; set; }
        public string CoordinateLatitude { get; set; }
        public string CoordinateLongitude { get; set; }
        public DateTime? CoordinateLastDate { get; set; }
        public string CoordinateLastDatePersian { get; set; }
        public bool? MobAppBaseInfoNeedUpdate { get; set; }
        public bool? UserIsActiveInFosetting { get; set; }
        public bool? UserAccessDailyChrtAllUsers { get; set; }
        public bool? UserAccessSaleChrtAllUsers { get; set; }
        public string MobAppBaseInfoNeedUpdateDetail { get; set; }
        public int? MaxNumberCmpDraft { get; set; }

        public virtual UserDepartments Department { get; set; }
        public virtual Languages Language { get; set; }
        public virtual Users UserId1Navigation { get; set; }
        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Country> Country { get; set; }
        public virtual ICollection<CrmAddressing> CrmAddressingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmAddressingType> CrmAddressingType { get; set; }
        public virtual ICollection<CrmAddressing> CrmAddressingUser { get; set; }
        public virtual ICollection<CrmBankingAccountType> CrmBankingAccountType { get; set; }
        public virtual ICollection<CrmBankingAccounts> CrmBankingAccounts { get; set; }
        public virtual ICollection<CrmBankingBanks> CrmBankingBanks { get; set; }
        public virtual ICollection<CrmBankingBranches> CrmBankingBranches { get; set; }
        public virtual ICollection<CrmCallBlackList> CrmCallBlackListBluser { get; set; }
        public virtual ICollection<CrmCallBlackList> CrmCallBlackListFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCallBlackList> CrmCallBlackListUser { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistoryFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistoryNoteEditedUser { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistoryNoteRegisterUser { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistoryNumberEditedUser { get; set; }
        public virtual ICollection<CrmCallHistory> CrmCallHistoryUser { get; set; }
        public virtual ICollection<CrmCallType> CrmCallType { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsCommentsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsCommentsUser { get; set; }
        public virtual ICollection<CrmCmsComments> CrmCmsCommentsVerifiedUser { get; set; }
        public virtual ICollection<CrmCmsFiles> CrmCmsFilesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsFiles> CrmCmsFilesUser { get; set; }
        public virtual ICollection<CrmCmsGallery> CrmCmsGalleryFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsGalleryItems> CrmCmsGalleryItemsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsGalleryItems> CrmCmsGalleryItemsUser { get; set; }
        public virtual ICollection<CrmCmsGallery> CrmCmsGalleryUser { get; set; }
        public virtual ICollection<CrmCmsLikes> CrmCmsLikesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsLikes> CrmCmsLikesUser { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenusFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsMenus> CrmCmsMenusUser { get; set; }
        public virtual ICollection<CrmCmsNews> CrmCmsNewsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsNewsGroups> CrmCmsNewsGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsNewsGroups> CrmCmsNewsGroupsUser { get; set; }
        public virtual ICollection<CrmCmsNews> CrmCmsNewsUser { get; set; }
        public virtual ICollection<CrmCmsNews> CrmCmsNewsVerifiedUser { get; set; }
        public virtual ICollection<CrmCmsObjectTypes> CrmCmsObjectTypesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsObjectTypes> CrmCmsObjectTypesUser { get; set; }
        public virtual ICollection<CrmCmsPages> CrmCmsPagesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCmsPages> CrmCmsPagesUser { get; set; }
        public virtual ICollection<CrmCompany> CrmCompany { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCity> CrmCompanyForbiddenCityCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCity> CrmCompanyForbiddenCityFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCity> CrmCompanyForbiddenCityUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCompany> CrmCompanyForbiddenCompanyCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCompany> CrmCompanyForbiddenCompanyFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenCompany> CrmCompanyForbiddenCompanyUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenDepartment> CrmCompanyForbiddenDepartmentCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenDepartment> CrmCompanyForbiddenDepartmentFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenDepartment> CrmCompanyForbiddenDepartmentUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroup> CrmCompanyForbiddenGroupCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroup> CrmCompanyForbiddenGroupFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroupIv> CrmCompanyForbiddenGroupIvCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroupIv> CrmCompanyForbiddenGroupIvFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroupIv> CrmCompanyForbiddenGroupIvUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenGroup> CrmCompanyForbiddenGroupUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenProvince> CrmCompanyForbiddenProvinceCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenProvince> CrmCompanyForbiddenProvinceFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenProvince> CrmCompanyForbiddenProvinceUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenSubGroup> CrmCompanyForbiddenSubGroupCrmUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenSubGroup> CrmCompanyForbiddenSubGroupFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyForbiddenSubGroup> CrmCompanyForbiddenSubGroupUser { get; set; }
        public virtual ICollection<CrmCompanyGroups> CrmCompanyGroups { get; set; }
        public virtual ICollection<CrmCompanyGroupsIi> CrmCompanyGroupsIi { get; set; }
        public virtual ICollection<CrmCompanyGroupsIii> CrmCompanyGroupsIii { get; set; }
        public virtual ICollection<CrmCompanyGroupsIv> CrmCompanyGroupsIv { get; set; }
        public virtual ICollection<CrmCompanyGroupsMulti> CrmCompanyGroupsMulti { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCity> CrmCompanyJustAccessCityCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCity> CrmCompanyJustAccessCityFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCity> CrmCompanyJustAccessCityUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCompany> CrmCompanyJustAccessCompanyCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCompany> CrmCompanyJustAccessCompanyFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessCompany> CrmCompanyJustAccessCompanyUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessDepartment> CrmCompanyJustAccessDepartmentCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessDepartment> CrmCompanyJustAccessDepartmentFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessDepartment> CrmCompanyJustAccessDepartmentUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroup> CrmCompanyJustAccessGroupCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroup> CrmCompanyJustAccessGroupFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroupIv> CrmCompanyJustAccessGroupIvCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroupIv> CrmCompanyJustAccessGroupIvFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroupIv> CrmCompanyJustAccessGroupIvUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessGroup> CrmCompanyJustAccessGroupUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessProvince> CrmCompanyJustAccessProvinceCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessProvince> CrmCompanyJustAccessProvinceFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessProvince> CrmCompanyJustAccessProvinceUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessSubGroup> CrmCompanyJustAccessSubGroupCrmUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessSubGroup> CrmCompanyJustAccessSubGroupFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyJustAccessSubGroup> CrmCompanyJustAccessSubGroupUser { get; set; }
        public virtual ICollection<CrmCompanyLoGo> CrmCompanyLoGoFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyLoGo> CrmCompanyLoGoUser { get; set; }
        public virtual ICollection<CrmCompanyMultiGroups> CrmCompanyMultiGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyMultiGroups> CrmCompanyMultiGroupsUser { get; set; }
        public virtual ICollection<CrmCompanyPersons> CrmCompanyPersons { get; set; }
        public virtual ICollection<CrmCompanyPersonsTemplate> CrmCompanyPersonsTemplate { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmpFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmpPrsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyPersonsTmp> CrmCompanyPersonsTmpUser { get; set; }
        public virtual ICollection<CrmCompanyPictureAlbums> CrmCompanyPictureAlbumsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyPictureAlbums> CrmCompanyPictureAlbumsUser { get; set; }
        public virtual ICollection<CrmCompanyPictures> CrmCompanyPicturesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyPictures> CrmCompanyPicturesUser { get; set; }
        public virtual ICollection<CrmCompanyPresentation> CrmCompanyPresentation { get; set; }
        public virtual ICollection<CrmCompanySubGroups> CrmCompanySubGroups { get; set; }
        public virtual ICollection<CrmCompanyTitle> CrmCompanyTitle { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmpCmpCoordinateLastUser { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmpCmpFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmpCmpReferUser { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmpFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyTmp> CrmCompanyTmpUser { get; set; }
        public virtual ICollection<CrmCompanyType> CrmCompanyType { get; set; }
        public virtual ICollection<CrmCompanyUserForbidden> CrmCompanyUserForbiddenCrmUser { get; set; }
        public virtual ICollection<CrmCompanyUserForbidden> CrmCompanyUserForbiddenFirstRegisterUser { get; set; }
        public virtual ICollection<CrmCompanyUserForbidden> CrmCompanyUserForbiddenUser { get; set; }
        public virtual ICollection<CrmConversation> CrmConversationCnvsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmConversation> CrmConversationCnvsReferUser { get; set; }
        public virtual ICollection<CrmConversation> CrmConversationCnvsUser { get; set; }
        public virtual ICollection<CrmConversationDefaultContext> CrmConversationDefaultContext { get; set; }
        public virtual ICollection<CrmConversation> CrmConversationFirstRegisterUser { get; set; }
        public virtual ICollection<CrmConversationPriority> CrmConversationPriority { get; set; }
        public virtual ICollection<CrmConversationReferUsers> CrmConversationReferUsersFirstRegisterUser { get; set; }
        public virtual ICollection<CrmConversationReferUsers> CrmConversationReferUsersReferUser { get; set; }
        public virtual ICollection<CrmConversationReferUsers> CrmConversationReferUsersUser { get; set; }
        public virtual ICollection<CrmConversationStatus> CrmConversationStatus { get; set; }
        public virtual ICollection<CrmConversationStatusGroups> CrmConversationStatusGroupsFocnvsReferUser { get; set; }
        public virtual ICollection<CrmConversationStatusGroups> CrmConversationStatusGroupsUser { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmpCnvsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmpCnvsReferUser { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmpCnvsUser { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmpFirstRegisterUser { get; set; }
        public virtual ICollection<CrmConversationTmp> CrmConversationTmpUser { get; set; }
        public virtual ICollection<CrmConversationTopics> CrmConversationTopics { get; set; }
        public virtual ICollection<CrmConversation> CrmConversationUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetailsCheckerUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValueDetails> CrmDyFormFieldMasterValueDetailsUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValuesCheckerUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValuesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormFieldMasterValues> CrmDyFormFieldMasterValuesUser { get; set; }
        public virtual ICollection<CrmDyFormFieldTypes> CrmDyFormFieldTypesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormFieldTypes> CrmDyFormFieldTypesUser { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValuesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormFieldValues> CrmDyFormFieldValuesUser { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFieldsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormFields> CrmDyFormFieldsUser { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressions> CrmDyFormRegularExpressionsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormRegularExpressions> CrmDyFormRegularExpressionsUser { get; set; }
        public virtual ICollection<CrmDyFormUserAccess> CrmDyFormUserAccessCrmUser { get; set; }
        public virtual ICollection<CrmDyFormUserAccess> CrmDyFormUserAccessFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormUserAccess> CrmDyFormUserAccessUser { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowStepsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormWorkflowSteps> CrmDyFormWorkflowStepsUser { get; set; }
        public virtual ICollection<CrmDyFormWorkflows> CrmDyFormWorkflowsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyFormWorkflows> CrmDyFormWorkflowsUser { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyFormsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmDyForms> CrmDyFormsUser { get; set; }
        public virtual ICollection<CrmFileDirectoryType> CrmFileDirectoryType { get; set; }
        public virtual ICollection<CrmFileDirectoryTypeOpr> CrmFileDirectoryTypeOpr { get; set; }
        public virtual ICollection<CrmFilesDirectory> CrmFilesDirectory { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplate> CrmFilesDirectoryTemplate { get; set; }
        public virtual ICollection<CrmFilesDirectoryTemplateType> CrmFilesDirectoryTemplateType { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingCmpDefaultReferUser { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingCnvsDefaultReferUser { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingCnvsDefaultUser { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingPrjDefaultStarterUser { get; set; }
        public virtual ICollection<CrmFoSetting> CrmFoSettingUser { get; set; }
        public virtual ICollection<CrmFund> CrmFundCrmUser { get; set; }
        public virtual ICollection<CrmFund> CrmFundFirstRegisterUser { get; set; }
        public virtual ICollection<CrmFundGroups> CrmFundGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmFundGroups> CrmFundGroupsUser { get; set; }
        public virtual ICollection<CrmFund> CrmFundUser { get; set; }
        public virtual ICollection<CrmInternalMessage> CrmInternalMessage { get; set; }
        public virtual ICollection<CrmInternalMessageDefaultContext> CrmInternalMessageDefaultContext { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetailsMsgdFromUser { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetailsMsgdToUser { get; set; }
        public virtual ICollection<CrmInternalMessageDetails> CrmInternalMessageDetailsUser { get; set; }
        public virtual ICollection<CrmInternalMessageGroup> CrmInternalMessageGroup { get; set; }
        public virtual ICollection<CrmInternalMessagePriority> CrmInternalMessagePriority { get; set; }
        public virtual ICollection<CrmInternalMessageSelectReceiver> CrmInternalMessageSelectReceiver { get; set; }
        public virtual ICollection<CrmInternalMessageTreeType> CrmInternalMessageTreeTypeFirstRegisterUser { get; set; }
        public virtual ICollection<CrmInternalMessageTreeType> CrmInternalMessageTreeTypeUser { get; set; }
        public virtual ICollection<CrmInternalMessageType> CrmInternalMessageType { get; set; }
        public virtual ICollection<CrmKnowledgeTank> CrmKnowledgeTank { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroup> CrmKnowledgeTankGroup { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupPermission> CrmKnowledgeTankGroupPermissionFirstRegisterUser { get; set; }
        public virtual ICollection<CrmKnowledgeTankGroupPermission> CrmKnowledgeTankGroupPermissionUser { get; set; }
        public virtual ICollection<CrmKnowledgeTankPriority> CrmKnowledgeTankPriority { get; set; }
        public virtual ICollection<CrmLeave> CrmLeave { get; set; }
        public virtual ICollection<CrmLeaveKinds> CrmLeaveKinds { get; set; }
        public virtual ICollection<CrmLeaveStatus> CrmLeaveStatus { get; set; }
        public virtual ICollection<CrmLeaveStayType> CrmLeaveStayType { get; set; }
        public virtual ICollection<CrmLeaveType> CrmLeaveType { get; set; }
        public virtual ICollection<CrmLeaveVehicleType> CrmLeaveVehicleType { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetails> CrmLinkAccNoAvSettingDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSettingDetails> CrmLinkAccNoAvSettingDetailsUser { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSetting> CrmLinkAccNoAvSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccNoAvSetting> CrmLinkAccNoAvSettingUser { get; set; }
        public virtual ICollection<CrmLinkAccSettingDetails> CrmLinkAccSettingDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccSettingDetails> CrmLinkAccSettingDetailsUser { get; set; }
        public virtual ICollection<CrmLinkAccSetting> CrmLinkAccSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccSetting> CrmLinkAccSettingUser { get; set; }
        public virtual ICollection<CrmLinkAccSystems> CrmLinkAccSystemsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccSystems> CrmLinkAccSystemsUser { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingDetails> CrmLinkAccTarazSettingDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccTarazSettingDetails> CrmLinkAccTarazSettingDetailsUser { get; set; }
        public virtual ICollection<CrmLinkAccTarazSetting> CrmLinkAccTarazSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkAccTarazSetting> CrmLinkAccTarazSettingUser { get; set; }
        public virtual ICollection<CrmLinkedCompany> CrmLinkedCompanyFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkedCompany> CrmLinkedCompanyUser { get; set; }
        public virtual ICollection<CrmLinkedType> CrmLinkedType { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsersCrmUser { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsersFirstRegisterUser { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsersLinkedUser { get; set; }
        public virtual ICollection<CrmLinkedUsers> CrmLinkedUsersUser { get; set; }
        public virtual ICollection<CrmOperationsType> CrmOperationsTypeFirstRegisterUser { get; set; }
        public virtual ICollection<CrmOperationsType> CrmOperationsTypeUser { get; set; }
        public virtual ICollection<CrmPersonDepartments> CrmPersonDepartments { get; set; }
        public virtual ICollection<CrmPersonGroups> CrmPersonGroups { get; set; }
        public virtual ICollection<CrmPersonJobs> CrmPersonJobs { get; set; }
        public virtual ICollection<CrmPersonPicture> CrmPersonPictureFirstRegisterUser { get; set; }
        public virtual ICollection<CrmPersonPicture> CrmPersonPictureUser { get; set; }
        public virtual ICollection<CrmPersonTitle> CrmPersonTitle { get; set; }
        public virtual ICollection<CrmPersonType> CrmPersonType { get; set; }
        public virtual ICollection<CrmProjectDefualtValue> CrmProjectDefualtValue { get; set; }
        public virtual ICollection<CrmProjectFieldTitle> CrmProjectFieldTitle { get; set; }
        public virtual ICollection<CrmProjectFieldValueType> CrmProjectFieldValueType { get; set; }
        public virtual ICollection<CrmProjectGrade> CrmProjectGrade { get; set; }
        public virtual ICollection<CrmProjectGroups> CrmProjectGroups { get; set; }
        public virtual ICollection<CrmProjectGroupsMulti> CrmProjectGroupsMulti { get; set; }
        public virtual ICollection<CrmProjectGroupsMultiI> CrmProjectGroupsMultiI { get; set; }
        public virtual ICollection<CrmProjectInformations> CrmProjectInformationsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectInformations> CrmProjectInformationsUser { get; set; }
        public virtual ICollection<CrmProjectMultiGroups> CrmProjectMultiGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectMultiGroups> CrmProjectMultiGroupsUser { get; set; }
        public virtual ICollection<CrmProjectMultiIgroups> CrmProjectMultiIgroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectMultiIgroups> CrmProjectMultiIgroupsUser { get; set; }
        public virtual ICollection<CrmProjectPriority> CrmProjectPriorityFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectPriority> CrmProjectPriorityUser { get; set; }
        public virtual ICollection<CrmProjectTitles> CrmProjectTitlesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectTitles> CrmProjectTitlesUser { get; set; }
        public virtual ICollection<CrmProjects> CrmProjectsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectsForbiddenForUser> CrmProjectsForbiddenForUserCrmUser { get; set; }
        public virtual ICollection<CrmProjectsForbiddenForUser> CrmProjectsForbiddenForUserFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectsForbiddenForUser> CrmProjectsForbiddenForUserUser { get; set; }
        public virtual ICollection<CrmProjects> CrmProjectsPrjFinishedUser { get; set; }
        public virtual ICollection<CrmProjects> CrmProjectsPrjFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjects> CrmProjectsPrjStarterUser { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmpFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmpPrjFinishedUser { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmpPrjFirstRegisterUser { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmpPrjStarterUser { get; set; }
        public virtual ICollection<CrmProjectsTmp> CrmProjectsTmpUser { get; set; }
        public virtual ICollection<CrmProjects> CrmProjectsUser { get; set; }
        public virtual ICollection<CrmShowTableFieldInFo> CrmShowTableFieldInFoFirstRegisterUser { get; set; }
        public virtual ICollection<CrmShowTableFieldInFo> CrmShowTableFieldInFoUser { get; set; }
        public virtual ICollection<CrmSystemParts> CrmSystemPartsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmSystemParts> CrmSystemPartsUser { get; set; }
        public virtual ICollection<CrmTelegBotChatMessage> CrmTelegBotChatMessage { get; set; }
        public virtual ICollection<CrmTelegBotContacts> CrmTelegBotContactsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTelegBotContacts> CrmTelegBotContactsUser { get; set; }
        public virtual ICollection<CrmTelegBotSetting> CrmTelegBotSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTelegBotSetting> CrmTelegBotSettingUser { get; set; }
        public virtual ICollection<CrmTelegChatMessage> CrmTelegChatMessage { get; set; }
        public virtual ICollection<CrmTelegContacts> CrmTelegContactsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTelegContacts> CrmTelegContactsUser { get; set; }
        public virtual ICollection<CrmTelegSetting> CrmTelegSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTelegSetting> CrmTelegSettingUser { get; set; }
        public virtual ICollection<CrmTempEmails> CrmTempEmailsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTempEmails> CrmTempEmailsPrsRegisterUser { get; set; }
        public virtual ICollection<CrmTempEmails> CrmTempEmailsUser { get; set; }
        public virtual ICollection<CrmTimeAttendanceBase> CrmTimeAttendanceBaseFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTimeAttendanceBase> CrmTimeAttendanceBaseUser { get; set; }
        public virtual ICollection<CrmTimeAttendance> CrmTimeAttendanceFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTimeAttendanceLog> CrmTimeAttendanceLogFirstRegisterUser { get; set; }
        public virtual ICollection<CrmTimeAttendanceLog> CrmTimeAttendanceLogTmlUser { get; set; }
        public virtual ICollection<CrmTimeAttendanceLog> CrmTimeAttendanceLogUser { get; set; }
        public virtual ICollection<CrmTimeAttendance> CrmTimeAttendanceTmUser { get; set; }
        public virtual ICollection<CrmTimeAttendance> CrmTimeAttendanceUser { get; set; }
        public virtual ICollection<CrmUserNotes> CrmUserNotesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmUserNotes> CrmUserNotesUser { get; set; }
        public virtual ICollection<CrmUserTaskGroups> CrmUserTaskGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<CrmUserTaskGroups> CrmUserTaskGroupsUser { get; set; }
        public virtual ICollection<CrmUserTaskPriorities> CrmUserTaskPrioritiesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmUserTaskPriorities> CrmUserTaskPrioritiesUser { get; set; }
        public virtual ICollection<CrmUserTasks> CrmUserTasksFirstRegisterUser { get; set; }
        public virtual ICollection<CrmUserTasks> CrmUserTasksUser { get; set; }
        public virtual ICollection<CrmVersionUpgrade> CrmVersionUpgrade { get; set; }
        public virtual ICollection<CrmVersionUpgradeDetails> CrmVersionUpgradeDetails { get; set; }
        public virtual ICollection<CrmVersions> CrmVersions { get; set; }
        public virtual ICollection<CrmWebSetting> CrmWebSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmWebSetting> CrmWebSettingUser { get; set; }
        public virtual ICollection<CrmsysCideviceType> CrmsysCideviceType { get; set; }
        public virtual ICollection<CrmsysCipopUpSetting> CrmsysCipopUpSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmsysCipopUpSetting> CrmsysCipopUpSettingUser { get; set; }
        public virtual ICollection<CrmsysCisetting> CrmsysCisetting { get; set; }
        public virtual ICollection<CrmsysDbobjects> CrmsysDbobjects { get; set; }
        public virtual ICollection<CrmsysDbtempInfo> CrmsysDbtempInfoFirstRegisterUser { get; set; }
        public virtual ICollection<CrmsysDbtempInfoType> CrmsysDbtempInfoType { get; set; }
        public virtual ICollection<CrmsysDbtempInfo> CrmsysDbtempInfoUser { get; set; }
        public virtual ICollection<CrmsysFormActions> CrmsysFormActions { get; set; }
        public virtual ICollection<CrmsysFormObjectProperties> CrmsysFormObjectPropertiesFirstRegisterUser { get; set; }
        public virtual ICollection<CrmsysFormObjectProperties> CrmsysFormObjectPropertiesUser { get; set; }
        public virtual ICollection<CrmsysForms> CrmsysForms { get; set; }
        public virtual ICollection<CrmsysRollPermission> CrmsysRollPermission { get; set; }
        public virtual ICollection<CrmsysRolls> CrmsysRolls { get; set; }
        public virtual ICollection<CrmsysSetting> CrmsysSettingFirstRegisterUser { get; set; }
        public virtual ICollection<CrmsysSetting> CrmsysSettingUser { get; set; }
        public virtual ICollection<CrmtmpManageTellNumber> CrmtmpManageTellNumberFirstRegisterUser { get; set; }
        public virtual ICollection<CrmtmpManageTellNumber> CrmtmpManageTellNumberUser { get; set; }
        public virtual ICollection<Education> EducationFirstRegisterUser { get; set; }
        public virtual ICollection<Education> EducationUser { get; set; }
        public virtual ICollection<EmailDefaultBodyText> EmailDefaultBodyTextFirstRegisterUser { get; set; }
        public virtual ICollection<EmailDefaultBodyText> EmailDefaultBodyTextUser { get; set; }
        public virtual ICollection<EmailReceiveAttachments> EmailReceiveAttachmentsFirstRegisterUser { get; set; }
        public virtual ICollection<EmailReceiveAttachments> EmailReceiveAttachmentsUser { get; set; }
        public virtual ICollection<EmailReceive> EmailReceiveFirstRegisterUser { get; set; }
        public virtual ICollection<EmailReceiveFolders> EmailReceiveFoldersFirstRegisterUser { get; set; }
        public virtual ICollection<EmailReceiveFolders> EmailReceiveFoldersUser { get; set; }
        public virtual ICollection<EmailReceive> EmailReceiveUser { get; set; }
        public virtual ICollection<EmailSendAttachment> EmailSendAttachment { get; set; }
        public virtual ICollection<EmailSendDetail> EmailSendDetail { get; set; }
        public virtual ICollection<EmailSendHeader> EmailSendHeaderFirstRegisterUser { get; set; }
        public virtual ICollection<EmailSendHeader> EmailSendHeaderUser { get; set; }
        public virtual ICollection<EmailSetting> EmailSettingFirstRegisterUser { get; set; }
        public virtual ICollection<EmailSetting> EmailSettingUser { get; set; }
        public virtual ICollection<EmailUserDefaultSetting> EmailUserDefaultSettingFirstRegisterUser { get; set; }
        public virtual ICollection<EmailUserDefaultSetting> EmailUserDefaultSettingUser { get; set; }
        public virtual ICollection<EmailUserTempTank> EmailUserTempTankFirstRegisterUser { get; set; }
        public virtual ICollection<EmailUserTempTank> EmailUserTempTankUser { get; set; }
        public virtual ICollection<EmailUsersInfo> EmailUsersInfoEuUser { get; set; }
        public virtual ICollection<EmailUsersInfo> EmailUsersInfoFirstRegisterUser { get; set; }
        public virtual ICollection<EmailUsersInfo> EmailUsersInfoUser { get; set; }
        public virtual ICollection<Users> InverseUserId1Navigation { get; set; }
        public virtual ICollection<Languages> LanguagesFirstRegisterUser { get; set; }
        public virtual ICollection<Languages> LanguagesUser { get; set; }
        public virtual ICollection<MobApiAndTableDetail> MobApiAndTableDetailFirstRegisterUser { get; set; }
        public virtual ICollection<MobApiAndTableDetail> MobApiAndTableDetailUser { get; set; }
        public virtual ICollection<MobCompanyAppInfo> MobCompanyAppInfoFirstRegisterUser { get; set; }
        public virtual ICollection<MobCompanyAppInfo> MobCompanyAppInfoUser { get; set; }
        public virtual ICollection<MyWebsites> MyWebsites { get; set; }
        public virtual ICollection<PayRollItemTypes> PayRollItemTypesFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollItemTypes> PayRollItemTypesUser { get; set; }
        public virtual ICollection<PayRollItems> PayRollItemsFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollItems> PayRollItemsUser { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycleCrmUser { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycleCycleVerifierUser { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycleFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValuesCrmUser { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValuesFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollUserCycleItemValues> PayRollUserCycleItemValuesUser { get; set; }
        public virtual ICollection<PayRollUserCycle> PayRollUserCycleUser { get; set; }
        public virtual ICollection<PayRollUserDefaultItems> PayRollUserDefaultItemsCrmUser { get; set; }
        public virtual ICollection<PayRollUserDefaultItems> PayRollUserDefaultItemsFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollUserDefaultItems> PayRollUserDefaultItemsUser { get; set; }
        public virtual ICollection<PayRollUserPaymentTypes> PayRollUserPaymentTypesFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollUserPaymentTypes> PayRollUserPaymentTypesUser { get; set; }
        public virtual ICollection<PayRollUserPayments> PayRollUserPaymentsFirstRegisterUser { get; set; }
        public virtual ICollection<PayRollUserPayments> PayRollUserPaymentsUser { get; set; }
        public virtual ICollection<PrintFormat> PrintFormatFirstRegisterUser { get; set; }
        public virtual ICollection<PrintFormatType> PrintFormatTypeFirstRegisterUser { get; set; }
        public virtual ICollection<PrintFormatType> PrintFormatTypeUser { get; set; }
        public virtual ICollection<PrintFormat> PrintFormatUser { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }
        public virtual ICollection<Province> ProvinceFirstRegisterUser { get; set; }
        public virtual ICollection<Province> ProvinceUser { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettingsFirstRegisterUser { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettingsLdreferUser { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettingsLdverifierRequest { get; set; }
        public virtual ICollection<SecLetterDefaultSettings> SecLetterDefaultSettingsUser { get; set; }
        public virtual ICollection<SecLetterType> SecLetterTypeFirstRegisterUser { get; set; }
        public virtual ICollection<SecLetterType> SecLetterTypeUser { get; set; }
        public virtual ICollection<SecLetters> SecLettersFirstRegisterUser { get; set; }
        public virtual ICollection<SecLetters> SecLettersLetterVerifier { get; set; }
        public virtual ICollection<SecLetters> SecLettersLetterVerifierRequest { get; set; }
        public virtual ICollection<SecLetters> SecLettersUser { get; set; }
        public virtual ICollection<Sex> SexFirstRegisterUser { get; set; }
        public virtual ICollection<Sex> SexUser { get; set; }
        public virtual ICollection<SmsDefaultBodyText> SmsDefaultBodyTextFirstRegisterUser { get; set; }
        public virtual ICollection<SmsDefaultBodyTextGroups> SmsDefaultBodyTextGroupsFirstRegisterUser { get; set; }
        public virtual ICollection<SmsDefaultBodyTextGroups> SmsDefaultBodyTextGroupsUser { get; set; }
        public virtual ICollection<SmsDefaultBodyText> SmsDefaultBodyTextUser { get; set; }
        public virtual ICollection<SmsDeliveryStatus> SmsDeliveryStatus { get; set; }
        public virtual ICollection<SmsGsmmodemDelivery> SmsGsmmodemDelivery { get; set; }
        public virtual ICollection<SmsGsmmodemSetting> SmsGsmmodemSettingFirstRegisterUser { get; set; }
        public virtual ICollection<SmsGsmmodemSetting> SmsGsmmodemSettingUser { get; set; }
        public virtual ICollection<SmsGsmreceives> SmsGsmreceives { get; set; }
        public virtual ICollection<SmsGsmsendingTank> SmsGsmsendingTank { get; set; }
        public virtual ICollection<SmsProviders> SmsProvidersFirstRegisterUser { get; set; }
        public virtual ICollection<SmsProviders> SmsProvidersUser { get; set; }
        public virtual ICollection<SmsReceive> SmsReceiveFirstRegisterUser { get; set; }
        public virtual ICollection<SmsReceiveFromWsdl> SmsReceiveFromWsdl { get; set; }
        public virtual ICollection<SmsReceive> SmsReceiveUser { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetailFirstRegisterUser { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetailSendUser { get; set; }
        public virtual ICollection<SmsSendDetail> SmsSendDetailUser { get; set; }
        public virtual ICollection<SmsSendHeader> SmsSendHeaderFirstRegisterUser { get; set; }
        public virtual ICollection<SmsSendHeader> SmsSendHeaderSendUser { get; set; }
        public virtual ICollection<SmsSendHeader> SmsSendHeaderUser { get; set; }
        public virtual ICollection<SmsSendType> SmsSendType { get; set; }
        public virtual ICollection<SmsSetting> SmsSettingFirstRegisterUser { get; set; }
        public virtual ICollection<SmsSetting> SmsSettingUser { get; set; }
        public virtual ICollection<SmsTempMobileNumbers> SmsTempMobileNumbersFirstRegisterUser { get; set; }
        public virtual ICollection<SmsTempMobileNumbers> SmsTempMobileNumbersUser { get; set; }
        public virtual ICollection<SmsUserSendCredit> SmsUserSendCreditCreditUser { get; set; }
        public virtual ICollection<SmsUserSendCredit> SmsUserSendCreditFirstRegisterUser { get; set; }
        public virtual ICollection<SmsUserSendCredit> SmsUserSendCreditUser { get; set; }
        public virtual ICollection<UserDepartmentTicketReferUsers> UserDepartmentTicketReferUsersFirstRegisterUser { get; set; }
        public virtual ICollection<UserDepartmentTicketReferUsers> UserDepartmentTicketReferUsersReferUser { get; set; }
        public virtual ICollection<UserDepartmentTicketReferUsers> UserDepartmentTicketReferUsersUser { get; set; }
        public virtual ICollection<UserDepartments> UserDepartmentsFirstRegisterUser { get; set; }
        public virtual ICollection<UserDepartments> UserDepartmentsUser { get; set; }
        public virtual ICollection<UserLanguages> UserLanguagesFirstRegisterUser { get; set; }
        public virtual ICollection<UserLanguages> UserLanguagesUser { get; set; }
        public virtual ICollection<UserLanguages> UserLanguagesUserId1Navigation { get; set; }
        public virtual ICollection<UserLoginAllowedTimes> UserLoginAllowedTimesCrmUser { get; set; }
        public virtual ICollection<UserLoginAllowedTimes> UserLoginAllowedTimesFirstRegisterUser { get; set; }
        public virtual ICollection<UserLoginAllowedTimes> UserLoginAllowedTimesFirstUser { get; set; }
        public virtual ICollection<UserLoginAllowedTimes> UserLoginAllowedTimesUser { get; set; }
        public virtual ICollection<UserSignature> UserSignatureFirstRegisterUser { get; set; }
        public virtual ICollection<UserSignature> UserSignatureSignatureUser { get; set; }
        public virtual ICollection<UserSignature> UserSignatureUser { get; set; }
        public virtual ICollection<UsersLang> UsersLang { get; set; }
        public virtual ICollection<UsersPermission> UsersPermissionFirstRegisterUser { get; set; }
        public virtual ICollection<UsersPermission> UsersPermissionUser { get; set; }
        public virtual ICollection<WsWareHouse> WsWareHouseFirstRegisterUser { get; set; }
        public virtual ICollection<WsWareHouse> WsWareHouseUser { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrderBordFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrderBordReferUser { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrderBordVerifier { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrderFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerialsFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderItemSerials> WsbuyOrderItemSerialsUser { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItemsFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderItems> WsbuyOrderItemsUser { get; set; }
        public virtual ICollection<WsbuyOrderOpr> WsbuyOrderOpr { get; set; }
        public virtual ICollection<WsbuyOrderPaymentTypes> WsbuyOrderPaymentTypesFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderPaymentTypes> WsbuyOrderPaymentTypesUser { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPaymentsBordpayFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPaymentsFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderPayments> WsbuyOrderPaymentsUser { get; set; }
        public virtual ICollection<WsbuyOrderStatus> WsbuyOrderStatusFirstRegisterUser { get; set; }
        public virtual ICollection<WsbuyOrderStatus> WsbuyOrderStatusUser { get; set; }
        public virtual ICollection<WsbuyOrder> WsbuyOrderUser { get; set; }
        public virtual ICollection<WscreditDuration> WscreditDurationFirstRegisterUser { get; set; }
        public virtual ICollection<WscreditDuration> WscreditDurationUser { get; set; }
        public virtual ICollection<WscurrencyUnits> WscurrencyUnitsFirstRegisterUser { get; set; }
        public virtual ICollection<WscurrencyUnits> WscurrencyUnitsUser { get; set; }
        public virtual ICollection<WsdeliveryTime> WsdeliveryTimeFirstRegisterUser { get; set; }
        public virtual ICollection<WsdeliveryTime> WsdeliveryTimeUser { get; set; }
        public virtual ICollection<Wsdoc> WsdocFirstRegisterUser { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerialsFirstRegisterUser { get; set; }
        public virtual ICollection<WsdocItemSerials> WsdocItemSerialsUser { get; set; }
        public virtual ICollection<WsdocItems> WsdocItemsFirstRegisterUser { get; set; }
        public virtual ICollection<WsdocItems> WsdocItemsUser { get; set; }
        public virtual ICollection<WsdocOpr> WsdocOpr { get; set; }
        public virtual ICollection<Wsdoc> WsdocUser { get; set; }
        public virtual ICollection<WsfinancialPeriod> WsfinancialPeriodFirstRegisterUser { get; set; }
        public virtual ICollection<WsfinancialPeriod> WsfinancialPeriodUser { get; set; }
        public virtual ICollection<Wsguaranty> WsguarantyFirstRegisterUser { get; set; }
        public virtual ICollection<Wsguaranty> WsguarantyUser { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProductsFirstRegisterUser { get; set; }
        public virtual ICollection<WslinkedProducts> WslinkedProductsUser { get; set; }
        public virtual ICollection<Wslogo> WslogoFirstRegisterUser { get; set; }
        public virtual ICollection<Wslogo> WslogoUser { get; set; }
        public virtual ICollection<WsorderCommissionPayTypes> WsorderCommissionPayTypesFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderCommissionPayTypes> WsorderCommissionPayTypesUser { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissionsCommIsPaidUser { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissionsCommUser { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissionsCommVerifierUser { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissionsFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderCommissions> WsorderCommissionsUser { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSettingFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSettingReferUser { get; set; }
        public virtual ICollection<WsorderDefaultSetting> WsorderDefaultSettingUser { get; set; }
        public virtual ICollection<Wsorder> WsorderFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerialsFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderItemSerials> WsorderItemSerialsUser { get; set; }
        public virtual ICollection<WsorderItems> WsorderItemsFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderItems> WsorderItemsUser { get; set; }
        public virtual ICollection<WsorderOpr> WsorderOpr { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdFirstRegisterUser { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdReferUser { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdVerifier { get; set; }
        public virtual ICollection<Wsorder> WsorderOrdVerifierRequest { get; set; }
        public virtual ICollection<WsorderPaymentTypes> WsorderPaymentTypesFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderPaymentTypes> WsorderPaymentTypesUser { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPaymentsFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPaymentsOrdpayFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderPayments> WsorderPaymentsUser { get; set; }
        public virtual ICollection<Wsorder> WsorderPreOrderVerifier { get; set; }
        public virtual ICollection<WsorderStatus> WsorderStatusFirstRegisterUser { get; set; }
        public virtual ICollection<WsorderStatus> WsorderStatusUser { get; set; }
        public virtual ICollection<Wsorder> WsorderUser { get; set; }
        public virtual ICollection<WspayCondition> WspayConditionFirstRegisterUser { get; set; }
        public virtual ICollection<WspayCondition> WspayConditionUser { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingReferUser { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingUser { get; set; }
        public virtual ICollection<WspreOrderDefaultSetting> WspreOrderDefaultSettingVerifierRequest { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderItemSpecification> WspreOrderItemSpecificationFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderItemSpecification> WspreOrderItemSpecificationUser { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItemsFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderItems> WspreOrderItemsUser { get; set; }
        public virtual ICollection<WspreOrderOpr> WspreOrderOprFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderOpr> WspreOrderOprUser { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPaymentsFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPaymentsPordpayFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderPayments> WspreOrderPaymentsUser { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordReferUser { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordVerifier { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderPordVerifierRequest { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasonsFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderPrdGroupMustExistReasons> WspreOrderPrdGroupMustExistReasonsUser { get; set; }
        public virtual ICollection<WspreOrderStatus> WspreOrderStatusFirstRegisterUser { get; set; }
        public virtual ICollection<WspreOrderStatus> WspreOrderStatusUser { get; set; }
        public virtual ICollection<WspreOrder> WspreOrderUser { get; set; }
        public virtual ICollection<WsproductColor> WsproductColorFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductColor> WsproductColorUser { get; set; }
        public virtual ICollection<WsproductCost> WsproductCostFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductCostGroup> WsproductCostGroupFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductCostGroup> WsproductCostGroupUser { get; set; }
        public virtual ICollection<WsproductCost> WsproductCostUser { get; set; }
        public virtual ICollection<WsproductFirstGroup> WsproductFirstGroup { get; set; }
        public virtual ICollection<WsproductGallery> WsproductGalleryFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductGallery> WsproductGalleryUser { get; set; }
        public virtual ICollection<WsproductImportFromExcelFields> WsproductImportFromExcelFields { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcelFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductImportFromExcel> WsproductImportFromExcelUser { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPictureFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductPicture> WsproductPictureUser { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPriceFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductPriceGroup> WsproductPriceGroupFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductPriceGroup> WsproductPriceGroupUser { get; set; }
        public virtual ICollection<WsproductPrice> WsproductPriceUser { get; set; }
        public virtual ICollection<WsproductSecondGroup> WsproductSecondGroupFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductSecondGroup> WsproductSecondGroupUser { get; set; }
        public virtual ICollection<WsproductShpStockManageTypes> WsproductShpStockManageTypesFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductShpStockManageTypes> WsproductShpStockManageTypesUser { get; set; }
        public virtual ICollection<WsproductSpecification> WsproductSpecificationFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductSpecification> WsproductSpecificationUser { get; set; }
        public virtual ICollection<WsproductUnits> WsproductUnitsFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductUnits> WsproductUnitsUser { get; set; }
        public virtual ICollection<Wsproducts> WsproductsFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRateFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductsRate> WsproductsRateUser { get; set; }
        public virtual ICollection<Wsproducts> WsproductsUser { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscountDiscountUser { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscountFirstRegisterUser { get; set; }
        public virtual ICollection<WsproductsUserDiscount> WsproductsUserDiscountUser { get; set; }
        public virtual ICollection<WsregisterBarCode> WsregisterBarCode { get; set; }
        public virtual ICollection<WssettlementType> WssettlementTypeFirstRegisterUser { get; set; }
        public virtual ICollection<WssettlementType> WssettlementTypeUser { get; set; }
        public virtual ICollection<Wssignature> WssignatureFirstRegisterUser { get; set; }
        public virtual ICollection<Wssignature> WssignatureUser { get; set; }
        public virtual ICollection<WstmpEnterBarcodeOperation> WstmpEnterBarcodeOperation { get; set; }
        public virtual ICollection<WstmpEnterDocPrdWithBarcode> WstmpEnterDocPrdWithBarcode { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopyFirstRegisterUser { get; set; }
        public virtual ICollection<WstmpUserItemCopy> WstmpUserItemCopyUser { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItemsFirstRegisterUser { get; set; }
        public virtual ICollection<WsuserFavproductItems> WsuserFavproductItemsUser { get; set; }
        public virtual ICollection<WsuserFavproducts> WsuserFavproductsFirstRegisterUser { get; set; }
        public virtual ICollection<WsuserFavproducts> WsuserFavproductsUser { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetailsFirstRegisterUser { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetailsUser { get; set; }
        public virtual ICollection<WsverificationRequestDetails> WsverificationRequestDetailsVerifyUser { get; set; }
        public virtual ICollection<WsverificationRequests> WsverificationRequestsFirstRegisterUser { get; set; }
        public virtual ICollection<WsverificationRequests> WsverificationRequestsUser { get; set; }
        public virtual ICollection<WsverificationRequests> WsverificationRequestsVerificationReqUser { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowStepsAlternateVerifyUser { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowStepsFirstRegisterUser { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowStepsUser { get; set; }
        public virtual ICollection<WsverificationWorkFlowSteps> WsverificationWorkFlowStepsVerifyUser { get; set; }
        public virtual ICollection<WsverificationWorkFlows> WsverificationWorkFlowsFirstRegisterUser { get; set; }
        public virtual ICollection<WsverificationWorkFlows> WsverificationWorkFlowsUser { get; set; }
    }
}
