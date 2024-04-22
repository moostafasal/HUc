using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresUser
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? LastLogin { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsSuperuser { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Username { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string FullName { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string FullNameEn { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsStaff { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsActive { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Univenumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? LastCertificateDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? BrithDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Postion { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Edu { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Dorea { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? HiringDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MotherName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? CarryName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? CarryRt { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? CarryJob { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? CarryPhone { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? IdNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? GenField { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SpifField { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ExamNumbers { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SecectNumbers { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Specfic { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Code { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Rnumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? GrdNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? GrdNumberDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? RecordNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? RecordNumberDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? GridNumberDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? Date2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Gev { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Area { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Store { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Zqaq { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Dar { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Sex { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Totel { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? Pres { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? UniversyAvg { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Sequence { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? GridTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SchooName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MdName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Role { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsForword { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsSigned { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsWidhdrow { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PersonalPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? IdPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? DadPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? LivePhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SecPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? OuthPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ApplicationPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? BachelorsId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? MasterId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? NationalityCountryId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PhDId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? CertificateId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Channel { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? CountryId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DepId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? EndYearId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? HireTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? InationalityId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? NationalityId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PostionTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PreviHireId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? ReligionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? StartYearId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TitelId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? WayId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? WindowId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MedicalExamination { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Commitment { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ContractAgreement { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PrepDocument { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool SummerTraining { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? RegistrationPhoto { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool CheckedAndLocked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? EndorsementAddress { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool OldAccounts { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? FirstInClass { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Roletype { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? AddById { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string FakePasswordEn { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? MiddleSchoolGraduationYear { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? BirthYear { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SuperiorPhoneNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? CreatedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? ModifiedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AppliactionType { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AppliactionNote { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? WaitById { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? StudentStatus { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Adress { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? CitIdNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MotherNameEn { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PlaceOfBrith { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SecondName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? FilldeForm { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PassportNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MinistryInfo { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? UnivPassword { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool MinistrySigned { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? FingerprintLoc { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? FingerprintId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? GenFieldId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? SpifFieldId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SginUpCode { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string EnFullName { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? ResignationDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? DirectDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool FingerprintNotReq { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? EmptyDays { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? DocumentsCheck { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public TimeOnly? EvningTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public TimeOnly? MoringTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? UniversyAvgInWords { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? FirstInClassUniversyAvgInWords { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? GridOrderDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? GridOrderNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AssociationReceiptFile { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AssociationReceiptRecord { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MainStatus { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Contract { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Cv { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? UniversyCirtifat { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? UniversyOrder { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Others { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PersonalFile { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? WorkOrder { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? TitleOrder { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? CitIdNumberDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? CitIdNumberEndDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? FrinshTotel { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsDors { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? NumberOfClass { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Passport { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? PassportNumberDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? PassportNumberEndDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial479 { get; set; }

    public virtual ICollection<AccountEmailaddress> AccountEmailaddresses { get; set; } = new List<AccountEmailaddress>();

    public virtual ICollection<AccountingFingerprintDay> AccountingFingerprintDays { get; set; } = new List<AccountingFingerprintDay>();

    public virtual ICollection<AccountingOtherAllowance> AccountingOtherAllowances { get; set; } = new List<AccountingOtherAllowance>();

    public virtual ICollection<AccountingSalary> AccountingSalaries { get; set; } = new List<AccountingSalary>();

    public virtual ICollection<AuditlogLogentry> AuditlogLogentries { get; set; } = new List<AuditlogLogentry>();

    public virtual UseresCollege? Bachelors { get; set; }

    public virtual UseresCertificate? Certificate { get; set; }

    public virtual UseresCountry? Country { get; set; }

    public virtual DepartmentsDepartment? Dep { get; set; }

    public virtual ICollection<DepartmentsMaterialCommentsAndRating> DepartmentsMaterialCommentsAndRatings { get; set; } = new List<DepartmentsMaterialCommentsAndRating>();

    public virtual ICollection<DepartmentsMaterialLab> DepartmentsMaterialLabs { get; set; } = new List<DepartmentsMaterialLab>();

    public virtual ICollection<DepartmentsMaterialfilesCommentsAndRating> DepartmentsMaterialfilesCommentsAndRatings { get; set; } = new List<DepartmentsMaterialfilesCommentsAndRating>();

    public virtual ICollection<DepartmentsMaterial> DepartmentsMaterials { get; set; } = new List<DepartmentsMaterial>();

    public virtual ICollection<DepartmentsStudentIssue> DepartmentsStudentIssues { get; set; } = new List<DepartmentsStudentIssue>();

    public virtual ICollection<DepartmentsStudentinfromtion> DepartmentsStudentinfromtions { get; set; } = new List<DepartmentsStudentinfromtion>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();

    public virtual ICollection<DjangoPrivateChat2Dialogsmodel> DjangoPrivateChat2DialogsmodelUser1s { get; set; } = new List<DjangoPrivateChat2Dialogsmodel>();

    public virtual ICollection<DjangoPrivateChat2Dialogsmodel> DjangoPrivateChat2DialogsmodelUser2s { get; set; } = new List<DjangoPrivateChat2Dialogsmodel>();

    public virtual ICollection<DjangoPrivateChat2Messagemodel> DjangoPrivateChat2MessagemodelRecipients { get; set; } = new List<DjangoPrivateChat2Messagemodel>();

    public virtual ICollection<DjangoPrivateChat2Messagemodel> DjangoPrivateChat2MessagemodelSenders { get; set; } = new List<DjangoPrivateChat2Messagemodel>();

    public virtual ICollection<DjangoPrivateChat2Uploadedfile> DjangoPrivateChat2Uploadedfiles { get; set; } = new List<DjangoPrivateChat2Uploadedfile>();

    public virtual DepartmentsYear? EndYear { get; set; }

    public virtual UseresGenField? GenFieldNavigation { get; set; }

    public virtual UseresHireType? HireType { get; set; }

    public virtual ICollection<HucsiteNewsUser> HucsiteNewsUsers { get; set; } = new List<HucsiteNewsUser>();

    public virtual UseresInationality? Inationality { get; set; }

    public virtual ICollection<ManagementsGraduationProject> ManagementsGraduationProjectStudents { get; set; } = new List<ManagementsGraduationProject>();

    public virtual ICollection<ManagementsGraduationProject> ManagementsGraduationProjectUsers { get; set; } = new List<ManagementsGraduationProject>();

    public virtual ICollection<ManagementsInsideInAndOutUser> ManagementsInsideInAndOutUsers { get; set; } = new List<ManagementsInsideInAndOutUser>();

    public virtual ICollection<ManagementsResearch> ManagementsResearches { get; set; } = new List<ManagementsResearch>();

    public virtual ICollection<ManagementsTeachingAssignment> ManagementsTeachingAssignments { get; set; } = new List<ManagementsTeachingAssignment>();

    public virtual ICollection<ManagementsVacationDay> ManagementsVacationDays { get; set; } = new List<ManagementsVacationDay>();

    public virtual UseresCollege? Master { get; set; }

    public virtual UseresNationality? Nationality { get; set; }

    public virtual UseresCountry? NationalityCountry { get; set; }

    public virtual UseresCollege? PhD { get; set; }

    public virtual UseresPostionType? PostionType { get; set; }

    public virtual UseresPreviHire? PreviHire { get; set; }

    public virtual ICollection<RegistrationBugsandsuggest> RegistrationBugsandsuggests { get; set; } = new List<RegistrationBugsandsuggest>();

    public virtual ICollection<RegistrationPreparatoryDocumentsStudentsReceipt> RegistrationPreparatoryDocumentsStudentsReceipts { get; set; } = new List<RegistrationPreparatoryDocumentsStudentsReceipt>();

    public virtual ICollection<RegistrationRequest> RegistrationRequests { get; set; } = new List<RegistrationRequest>();

    public virtual ICollection<RegistrationValidityRespondStudent> RegistrationValidityRespondStudents { get; set; } = new List<RegistrationValidityRespondStudent>();

    public virtual UseresReligion? Religion { get; set; }

    public virtual ICollection<ReversionRevision> ReversionRevisions { get; set; } = new List<ReversionRevision>();

    public virtual ICollection<SocialaccountSocialaccount> SocialaccountSocialaccounts { get; set; } = new List<SocialaccountSocialaccount>();

    public virtual UseresSpifField? SpifFieldNavigation { get; set; }

    public virtual DepartmentsYear? StartYear { get; set; }

    public virtual UseresTitel? Titel { get; set; }

    public virtual UseresType? Type { get; set; }

    public virtual ICollection<UseresGivenAuthority> UseresGivenAuthorities { get; set; } = new List<UseresGivenAuthority>();

    public virtual ICollection<UseresStudentDocument> UseresStudentDocuments { get; set; } = new List<UseresStudentDocument>();

    public virtual ICollection<UseresThirdPartUser> UseresThirdPartUsers { get; set; } = new List<UseresThirdPartUser>();

    public virtual ICollection<UseresUserDep> UseresUserDeps { get; set; } = new List<UseresUserDep>();

    public virtual ICollection<UseresUserGroup> UseresUserGroups { get; set; } = new List<UseresUserGroup>();

    public virtual ICollection<UseresUserUserPermission> UseresUserUserPermissions { get; set; } = new List<UseresUserUserPermission>();

    public virtual UseresWay? Way { get; set; }

    public virtual UseresWindow? Window { get; set; }
}
