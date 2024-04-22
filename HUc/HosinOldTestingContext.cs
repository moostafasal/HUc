using System;
using System.Collections.Generic;
using HUc.Data;
using Microsoft.EntityFrameworkCore;

namespace HUc;

public partial class HosinOldTestingContext : DbContext
{
    public HosinOldTestingContext()
    {
    }

    public HosinOldTestingContext(DbContextOptions<HosinOldTestingContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccountEmailaddress> AccountEmailaddresses { get; set; }

    public virtual DbSet<AccountEmailconfirmation> AccountEmailconfirmations { get; set; }

    public virtual DbSet<AccountingAllowancesGroup> AccountingAllowancesGroups { get; set; }

    public virtual DbSet<AccountingAnnualInstallment> AccountingAnnualInstallments { get; set; }

    public virtual DbSet<AccountingDiscount> AccountingDiscounts { get; set; }

    public virtual DbSet<AccountingFingerprintDay> AccountingFingerprintDays { get; set; }

    public virtual DbSet<AccountingFingerprintHistory> AccountingFingerprintHistories { get; set; }

    public virtual DbSet<AccountingOtherAllowance> AccountingOtherAllowances { get; set; }

    public virtual DbSet<AccountingPenalty> AccountingPenalties { get; set; }

    public virtual DbSet<AccountingSalary> AccountingSalarys { get; set; }

    public virtual DbSet<AccountingStudentDiscount> AccountingStudentDiscounts { get; set; }

    public virtual DbSet<AccountingStudentPayment> AccountingStudentPayments { get; set; }

    public virtual DbSet<AccountingStudentTakeBack> AccountingStudentTakeBacks { get; set; }

    public virtual DbSet<AliMInvoice> AliMInvoices { get; set; }

    public virtual DbSet<AuditlogLogentry> AuditlogLogentries { get; set; }

    public virtual DbSet<AuthGroup> AuthGroups { get; set; }

    public virtual DbSet<AuthGroupPermission> AuthGroupPermissions { get; set; }

    public virtual DbSet<AuthPermission> AuthPermissions { get; set; }

    public virtual DbSet<DepartmentsBook> DepartmentsBooks { get; set; }

    public virtual DbSet<DepartmentsDegresToWord> DepartmentsDegresToWords { get; set; }

    public virtual DbSet<DepartmentsDepartment> DepartmentsDepartments { get; set; }

    public virtual DbSet<DepartmentsExamsSchedule> DepartmentsExamsSchedules { get; set; }

    public virtual DbSet<DepartmentsLecturesSchedule> DepartmentsLecturesSchedules { get; set; }

    public virtual DbSet<DepartmentsMaterial> DepartmentsMaterials { get; set; }

    public virtual DbSet<DepartmentsMaterialCommentsAndRating> DepartmentsMaterialCommentsAndRatings { get; set; }

    public virtual DbSet<DepartmentsMaterialLab> DepartmentsMaterialLabs { get; set; }

    public virtual DbSet<DepartmentsMaterialfile> DepartmentsMaterialfiles { get; set; }

    public virtual DbSet<DepartmentsMaterialfilesCommentsAndRating> DepartmentsMaterialfilesCommentsAndRatings { get; set; }

    public virtual DbSet<DepartmentsOrder> DepartmentsOrders { get; set; }

    public virtual DbSet<DepartmentsStage> DepartmentsStages { get; set; }

    public virtual DbSet<DepartmentsStudentAlert> DepartmentsStudentAlerts { get; set; }

    public virtual DbSet<DepartmentsStudentIssue> DepartmentsStudentIssues { get; set; }

    public virtual DbSet<DepartmentsStudentTraining> DepartmentsStudentTrainings { get; set; }

    public virtual DbSet<DepartmentsStudentinfromtion> DepartmentsStudentinfromtions { get; set; }

    public virtual DbSet<DepartmentsStudentmaterial> DepartmentsStudentmaterials { get; set; }

    public virtual DbSet<DepartmentsUniversitySchedule> DepartmentsUniversitySchedules { get; set; }

    public virtual DbSet<DepartmentsYear> DepartmentsYears { get; set; }

    public virtual DbSet<DjangoAdminLog> DjangoAdminLogs { get; set; }

    public virtual DbSet<DjangoContentType> DjangoContentTypes { get; set; }

    public virtual DbSet<DjangoCronCronjoblock> DjangoCronCronjoblocks { get; set; }

    public virtual DbSet<DjangoCronCronjoblog> DjangoCronCronjoblogs { get; set; }

    public virtual DbSet<DjangoMigration> DjangoMigrations { get; set; }

    public virtual DbSet<DjangoPrivateChat2Dialogsmodel> DjangoPrivateChat2Dialogsmodels { get; set; }

    public virtual DbSet<DjangoPrivateChat2Messagemodel> DjangoPrivateChat2Messagemodels { get; set; }

    public virtual DbSet<DjangoPrivateChat2Uploadedfile> DjangoPrivateChat2Uploadedfiles { get; set; }

    public virtual DbSet<DjangoSession> DjangoSessions { get; set; }

    public virtual DbSet<DjangoSite> DjangoSites { get; set; }

    public virtual DbSet<HucsiteFile> HucsiteFiles { get; set; }

    public virtual DbSet<HucsiteNews> HucsiteNews { get; set; }

    public virtual DbSet<HucsiteNewsDepartment> HucsiteNewsDepartments { get; set; }

    public virtual DbSet<HucsiteNewsImg> HucsiteNewsImgs { get; set; }

    public virtual DbSet<HucsiteNewsImg2> HucsiteNewsImg2s { get; set; }

    public virtual DbSet<HucsiteNewsUser> HucsiteNewsUsers { get; set; }

    public virtual DbSet<HucsitePhote> HucsitePhotes { get; set; }

    public virtual DbSet<HucsitePublicLink> HucsitePublicLinks { get; set; }

    public virtual DbSet<HucsiteSdj> HucsiteSdjs { get; set; }

    public virtual DbSet<ManagementsBooksDepartment> ManagementsBooksDepartments { get; set; }

    public virtual DbSet<ManagementsBooksTemplate> ManagementsBooksTemplates { get; set; }

    public virtual DbSet<ManagementsColegeRecord> ManagementsColegeRecords { get; set; }

    public virtual DbSet<ManagementsColegeRecordAnswerFile> ManagementsColegeRecordAnswerFiles { get; set; }

    public virtual DbSet<ManagementsColegeRecordDepartment> ManagementsColegeRecordDepartments { get; set; }

    public virtual DbSet<ManagementsColegeRecordPrioritiesFile> ManagementsColegeRecordPrioritiesFiles { get; set; }

    public virtual DbSet<ManagementsGraduationProject> ManagementsGraduationProjects { get; set; }

    public virtual DbSet<ManagementsGroupsCount> ManagementsGroupsCounts { get; set; }

    public virtual DbSet<ManagementsInsideInAndOut> ManagementsInsideInAndOuts { get; set; }

    public virtual DbSet<ManagementsInsideInAndOutUser> ManagementsInsideInAndOutUsers { get; set; }

    public virtual DbSet<ManagementsIssueCount> ManagementsIssueCounts { get; set; }

    public virtual DbSet<ManagementsIssueType> ManagementsIssueTypes { get; set; }

    public virtual DbSet<ManagementsIssuer> ManagementsIssuers { get; set; }

    public virtual DbSet<ManagementsKeyword> ManagementsKeywords { get; set; }

    public virtual DbSet<ManagementsLaboratorySpace> ManagementsLaboratorySpaces { get; set; }

    public virtual DbSet<ManagementsOffDay> ManagementsOffDays { get; set; }

    public virtual DbSet<ManagementsQuorumType> ManagementsQuorumTypes { get; set; }

    public virtual DbSet<ManagementsResearch> ManagementsResearchs { get; set; }

    public virtual DbSet<ManagementsTeachingAssignment> ManagementsTeachingAssignments { get; set; }

    public virtual DbSet<ManagementsVacationDay> ManagementsVacationDays { get; set; }

    public virtual DbSet<OmrSolverExamNumber> OmrSolverExamNumbers { get; set; }

    public virtual DbSet<OmrSolverQustion> OmrSolverQustions { get; set; }

    public virtual DbSet<OmrSolverStudentTest> OmrSolverStudentTests { get; set; }

    public virtual DbSet<RegistrationBugsandsuggest> RegistrationBugsandsuggests { get; set; }

    public virtual DbSet<RegistrationIdList> RegistrationIdLists { get; set; }

    public virtual DbSet<RegistrationModelId> RegistrationModelIds { get; set; }

    public virtual DbSet<RegistrationNamesTran> RegistrationNamesTrans { get; set; }

    public virtual DbSet<RegistrationPreparatoryDocumentsStudentsReceipt> RegistrationPreparatoryDocumentsStudentsReceipts { get; set; }

    public virtual DbSet<RegistrationRequest> RegistrationRequests { get; set; }

    public virtual DbSet<RegistrationValidityRespond> RegistrationValidityResponds { get; set; }

    public virtual DbSet<RegistrationValidityRespondStudent> RegistrationValidityRespondStudents { get; set; }

    public virtual DbSet<ReversionRevision> ReversionRevisions { get; set; }

    public virtual DbSet<ReversionVersion> ReversionVersions { get; set; }

    public virtual DbSet<SocialaccountSocialaccount> SocialaccountSocialaccounts { get; set; }

    public virtual DbSet<SocialaccountSocialapp> SocialaccountSocialapps { get; set; }

    public virtual DbSet<SocialaccountSocialappSite> SocialaccountSocialappSites { get; set; }

    public virtual DbSet<SocialaccountSocialtoken> SocialaccountSocialtokens { get; set; }

    public virtual DbSet<UseresAdministrativeAuthority> UseresAdministrativeAuthorities { get; set; }

    public virtual DbSet<UseresAdministrativeAuthorityGroup> UseresAdministrativeAuthorityGroups { get; set; }

    public virtual DbSet<UseresCertificate> UseresCertificates { get; set; }

    public virtual DbSet<UseresCollege> UseresColleges { get; set; }

    public virtual DbSet<UseresCountry> UseresCountries { get; set; }

    public virtual DbSet<UseresGenField> UseresGenFields { get; set; }

    public virtual DbSet<UseresGivenAuthority> UseresGivenAuthorities { get; set; }

    public virtual DbSet<UseresGroupAuthority> UseresGroupAuthorities { get; set; }

    public virtual DbSet<UseresGroupAuthorityDep> UseresGroupAuthorityDeps { get; set; }

    public virtual DbSet<UseresHireType> UseresHireTypes { get; set; }

    public virtual DbSet<UseresInationality> UseresInationalities { get; set; }

    public virtual DbSet<UseresNationality> UseresNationalities { get; set; }

    public virtual DbSet<UseresPostionType> UseresPostionTypes { get; set; }

    public virtual DbSet<UseresPreviHire> UseresPreviHires { get; set; }

    public virtual DbSet<UseresReligion> UseresReligions { get; set; }

    public virtual DbSet<UseresSpifField> UseresSpifFields { get; set; }

    public virtual DbSet<UseresStudentDocument> UseresStudentDocuments { get; set; }

    public virtual DbSet<UseresThirdPartUser> UseresThirdPartUsers { get; set; }

    public virtual DbSet<UseresTitel> UseresTitels { get; set; }

    public virtual DbSet<UseresType> UseresTypes { get; set; }

    public virtual DbSet<UseresUser> UseresUsers { get; set; }

    public virtual DbSet<UseresUserDep> UseresUserDeps { get; set; }

    public virtual DbSet<UseresUserGroup> UseresUserGroups { get; set; }

    public virtual DbSet<UseresUserUserPermission> UseresUserUserPermissions { get; set; }

    public virtual DbSet<UseresWay> UseresWays { get; set; }

    public virtual DbSet<UseresWindow> UseresWindows { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=185.138.122.28;Database=Hosin_Old_Testing;User Id=team1;Password=Teamwork123456@;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountEmailaddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_emailaddress_pkey");

            entity.ToTable("account_emailaddress", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.Email, "account_emailaddress_email_03be32b2_like").HasFillFactor(99);

            entity.HasIndex(e => e.Email, "account_emailaddress_email_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "account_emailaddress_user_id_2c513194").HasFillFactor(99);


            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("email");
            entity.Property(e => e.Primary)
                .HasComment("TRIAL")
                .HasColumnName("primary");
            entity.Property(e => e.Trial042)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL042");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");
            entity.Property(e => e.Verified)
                .HasComment("TRIAL")
                .HasColumnName("verified");

            entity.HasOne(d => d.User).WithMany(p => p.AccountEmailaddresses)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("account_emailaddress_user_id_2c513194_fk_useres_user_id");
        });

        modelBuilder.Entity<AccountEmailconfirmation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("account_emailconfirmation_pkey");

            entity.ToTable("account_emailconfirmation", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.EmailAddressId, "account_emailconfirmation_email_address_id_5b7f8c58").HasFillFactor(99);

            entity.HasIndex(e => e.Key, "account_emailconfirmation_key_f43612bd_like").HasFillFactor(99);

            entity.HasIndex(e => e.Key, "account_emailconfirmation_key_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasComment("TRIAL")
                .HasColumnName("created");
            entity.Property(e => e.EmailAddressId)
                .HasComment("TRIAL")
                .HasColumnName("email_address_id");
            entity.Property(e => e.Key)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("key");
            entity.Property(e => e.Sent)
                .HasComment("TRIAL")
                .HasColumnName("sent");
            entity.Property(e => e.Trial045)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL045");

            entity.HasOne(d => d.EmailAddress).WithMany(p => p.AccountEmailconfirmations)
                .HasForeignKey(d => d.EmailAddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("account_emailconfirm_email_address_id_5b7f8c58_fk_account_e");
        });

        modelBuilder.Entity<AccountingAllowancesGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_allowances_group_pkey");

            entity.ToTable("accounting_allowances_group", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Hd)
                .HasComment("TRIAL")
                .HasColumnName("hd");
            entity.Property(e => e.Mc)
                .HasComment("TRIAL")
                .HasColumnName("MC");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Phd)
                .HasComment("TRIAL")
                .HasColumnName("phd");
            entity.Property(e => e.Specialization)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.Trial045)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL045");
        });

        modelBuilder.Entity<AccountingAnnualInstallment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_annual_installments_pkey");

            entity.ToTable("accounting_annual_installments", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "accounting_annual_installments_department_id_af1d5d09").HasFillFactor(99);

            entity.HasIndex(e => e.YearId, "accounting_annual_installments_year_id_b15a640e").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Trial045)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL045");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");
            entity.Property(e => e.YearId)
                .HasComment("TRIAL")
                .HasColumnName("year_id");

            entity.HasOne(d => d.Department).WithMany(p => p.AccountingAnnualInstallments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_annual_in_department_id_af1d5d09_fk_Departmen");

            entity.HasOne(d => d.Year).WithMany(p => p.AccountingAnnualInstallments)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_annual_in_year_id_b15a640e_fk_Departmen");
        });

        modelBuilder.Entity<AccountingDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_discount_pkey");

            entity.ToTable("accounting_discount", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.YearId, "accounting_discount_year_id_4be91772").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CountAsPayment)
                .HasComment("TRIAL")
                .HasColumnName("count_as_payment");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Rate).HasComment("TRIAL");
            entity.Property(e => e.Trial048)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL048");
            entity.Property(e => e.YearId)
                .HasComment("TRIAL")
                .HasColumnName("year_id");

            entity.HasOne(d => d.Year).WithMany(p => p.AccountingDiscounts)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_discount_year_id_4be91772_fk_Departments_year_id");
        });

        modelBuilder.Entity<AccountingFingerprintDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_fingerprint_days_pkey");

            entity.ToTable("accounting_fingerprint_days", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "accounting_fingerprint_days_user_id_91deb8a0").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.EveingFingerPrint)
                .HasComment("TRIAL")
                .HasColumnName("eveing_finger_print");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.MoringFingerPrint)
                .HasComment("TRIAL")
                .HasColumnName("moring_finger_print");
            entity.Property(e => e.Trial048)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL048");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccountingFingerprintDays)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_fingerprint_days_user_id_91deb8a0_fk_useres_user_id");
        });

        modelBuilder.Entity<AccountingFingerprintHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_fingerprint_history_pkey");

            entity.ToTable("accounting_fingerprint_history", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.FingerprintDayId, "accounting_fingerprint_history_fingerprint_day_id_954e73c9").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.FingerprintDayId)
                .HasComment("TRIAL")
                .HasColumnName("fingerprint_day_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Trial058)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL058");

            entity.HasOne(d => d.FingerprintDay).WithMany(p => p.AccountingFingerprintHistories)
                .HasForeignKey(d => d.FingerprintDayId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_fingerpri_fingerprint_day_id_954e73c9_fk_accountin");
        });

        modelBuilder.Entity<AccountingOtherAllowance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_other_allowances_pkey");

            entity.ToTable("accounting_other_allowances", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "accounting_other_allowances_user_id_1700226e").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Trial074)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL074");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");

            entity.HasOne(d => d.User).WithMany(p => p.AccountingOtherAllowances)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_other_allowances_user_id_1700226e_fk_useres_user_id");
        });

        modelBuilder.Entity<AccountingPenalty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_penalties_pkey");

            entity.ToTable("accounting_penalties", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentinfromtionId, "accounting_penalties_studentinfromtion_id_7fda5638").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Trial074)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL074");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.AccountingPenalties)
                .HasForeignKey(d => d.StudentinfromtionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_penalties_studentinfromtion_id_7fda5638_fk_Departmen");
        });

        modelBuilder.Entity<AccountingSalary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_salarys_pkey");

            entity.ToTable("accounting_salarys", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "accounting_salarys_user_id_9b7a56b3").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AccountNumber)
                .HasComment("TRIAL")
                .HasColumnName("account_number");
            entity.Property(e => e.ActualTitleHours)
                .HasComment("TRIAL")
                .HasColumnName("actual_title_hours");
            entity.Property(e => e.BaseAllowances)
                .HasComment("TRIAL")
                .HasColumnName("base_allowances");
            entity.Property(e => e.CertificateAllowances)
                .HasComment("TRIAL")
                .HasColumnName("Certificate_allowances");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DaysToWork)
                .HasComment("TRIAL")
                .HasColumnName("days_to_work");
            entity.Property(e => e.DirectlyDeductions)
                .HasComment("TRIAL")
                .HasColumnName("directly_deductions");
            entity.Property(e => e.EntitlementAllowances)
                .HasComment("TRIAL")
                .HasColumnName("entitlement_allowances");
            entity.Property(e => e.LivingCost)
                .HasComment("TRIAL")
                .HasColumnName("living_cost");
            entity.Property(e => e.LoansDeductions)
                .HasComment("TRIAL")
                .HasColumnName("Loans_deductions");
            entity.Property(e => e.MissingDays)
                .HasComment("TRIAL")
                .HasColumnName("missing_days");
            entity.Property(e => e.MissingDaysDeductions)
                .HasComment("TRIAL")
                .HasColumnName("missing_days_deductions");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.NameedAllowances)
                .HasComment("TRIAL")
                .HasColumnName("nameed_allowances");
            entity.Property(e => e.Note)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.OtherAllowances)
                .HasComment("TRIAL")
                .HasColumnName("other_allowances");
            entity.Property(e => e.OtherDeductions)
                .HasComment("TRIAL")
                .HasColumnName("Other_deductions");
            entity.Property(e => e.PositonAllowances)
                .HasComment("TRIAL")
                .HasColumnName("positon_allowances");
            entity.Property(e => e.ResearchAllowances)
                .HasComment("TRIAL")
                .HasColumnName("research_allowances");
            entity.Property(e => e.ResearchDeductions)
                .HasComment("TRIAL")
                .HasColumnName("research_deductions");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("status");
            entity.Property(e => e.StudentsCount)
                .HasComment("TRIAL")
                .HasColumnName("students_count");
            entity.Property(e => e.SurnameAllowances)
                .HasComment("TRIAL")
                .HasColumnName("surname_allowances");
            entity.Property(e => e.TeachersCount)
                .HasComment("TRIAL")
                .HasColumnName("teachers_count");
            entity.Property(e => e.TeachingEffort)
                .HasComment("TRIAL")
                .HasColumnName("teaching_effort");
            entity.Property(e => e.Teachingload)
                .HasComment("TRIAL")
                .HasColumnName("teachingload");
            entity.Property(e => e.TitleHours)
                .HasComment("TRIAL")
                .HasColumnName("title_hours");
            entity.Property(e => e.TitleHoursDeductions)
                .HasComment("TRIAL")
                .HasColumnName("title_hours_deductions");
            entity.Property(e => e.TotalAllowances)
                .HasComment("TRIAL")
                .HasColumnName("total_allowances");
            entity.Property(e => e.Trial081)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL081");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.AccountingSalaries)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_salarys_user_id_9b7a56b3_fk_useres_user_id");
        });

        modelBuilder.Entity<AccountingStudentDiscount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_student_discount_pkey");

            entity.ToTable("accounting_student_discount", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DiscountId, "accounting_student_discount_discount_id_e8aa0468").HasFillFactor(99);

            entity.HasIndex(e => e.StudentinfromtionId, "accounting_student_discount_studentinfromtion_id_31a142bd").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DiscountId)
                .HasComment("TRIAL")
                .HasColumnName("discount_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Rate).HasComment("TRIAL");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Trial081)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL081");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");

            entity.HasOne(d => d.Discount).WithMany(p => p.AccountingStudentDiscounts)
                .HasForeignKey(d => d.DiscountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_student_d_discount_id_e8aa0468_fk_accountin");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.AccountingStudentDiscounts)
                .HasForeignKey(d => d.StudentinfromtionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_student_d_studentinfromtion_id_31a142bd_fk_Departmen");
        });

        modelBuilder.Entity<AccountingStudentPayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_student_payment_pkey");

            entity.ToTable("accounting_student_payment", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentinfromtionId, "accounting_student_payment_studentinfromtion_id_587a5b2c").HasFillFactor(99);

            entity.HasIndex(e => e.VoucherNumber, "accounting_student_payment_voucher_number_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Checked)
                .HasComment("TRIAL")
                .HasColumnName("checked");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.Deduction)
                .HasComment("TRIAL")
                .HasColumnName("deduction");
            entity.Property(e => e.Identity)
                .HasComment("TRIAL")
                .HasColumnName("identity");
            entity.Property(e => e.IdentityNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("identity_notes");
            entity.Property(e => e.Insurances).HasComment("TRIAL");
            entity.Property(e => e.InsurancesNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Insurances_notes");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.NonCurrentActivity)
                .HasComment("TRIAL")
                .HasColumnName("non_current_activity");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Other)
                .HasComment("TRIAL")
                .HasColumnName("other");
            entity.Property(e => e.OtherNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("other_notes");
            entity.Property(e => e.Payment)
                .HasComment("TRIAL")
                .HasColumnName("payment");
            entity.Property(e => e.PaymentNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("payment_notes");
            entity.Property(e => e.Penalty)
                .HasComment("TRIAL")
                .HasColumnName("penalty");
            entity.Property(e => e.PenaltyNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("penalty_notes");
            entity.Property(e => e.Predecessor)
                .HasComment("TRIAL")
                .HasColumnName("predecessor");
            entity.Property(e => e.Protest)
                .HasComment("TRIAL")
                .HasColumnName("protest");
            entity.Property(e => e.ProtestNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("protest_notes");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Support)
                .HasComment("TRIAL")
                .HasColumnName("support");
            entity.Property(e => e.SupportBook)
                .HasComment("TRIAL")
                .HasColumnName("support_book");
            entity.Property(e => e.SupportBookNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("support_book_notes");
            entity.Property(e => e.SupportNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("support_notes");
            entity.Property(e => e.Total)
                .HasComment("TRIAL")
                .HasColumnName("total");
            entity.Property(e => e.Training)
                .HasComment("TRIAL")
                .HasColumnName("training");
            entity.Property(e => e.TrainingNotes)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("training_notes");
            entity.Property(e => e.Trial087)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL087");
            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.VoucherNumber)
                .HasComment("TRIAL")
                .HasColumnName("voucher_number");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.AccountingStudentPayments)
                .HasForeignKey(d => d.StudentinfromtionId)
                .HasConstraintName("accounting_student_p_studentinfromtion_id_587a5b2c_fk_Departmen");
        });

        modelBuilder.Entity<AccountingStudentTakeBack>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("accounting_student_take_back_pkey");

            entity.ToTable("accounting_student_take_back", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentinfromtionId, "accounting_student_take_back_studentinfromtion_id_78454cfe").HasFillFactor(99);

            entity.HasIndex(e => e.VoucherNumber, "accounting_student_take_back_voucher_number_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Trial123)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL123");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");
            entity.Property(e => e.VoucherNumber)
                .HasComment("TRIAL")
                .HasColumnName("voucher_number");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.AccountingStudentTakeBacks)
                .HasForeignKey(d => d.StudentinfromtionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("accounting_student_t_studentinfromtion_id_78454cfe_fk_Departmen");
        });

        modelBuilder.Entity<AliMInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ali_M_invoices");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdP).HasColumnName("ID_P");
            entity.Property(e => e.Marhala).HasMaxLength(255);
            entity.Property(e => e.Qsm).HasMaxLength(255);
            entity.Property(e => e.SType)
                .HasMaxLength(255)
                .HasColumnName("S_Type");
            entity.Property(e => e.StId).HasColumnName("St_ID");
            entity.Property(e => e.StName)
                .HasMaxLength(255)
                .HasColumnName("St_Name");
            entity.Property(e => e.StudentinfromtionId).HasColumnName("studentinfromtion_id");
            entity.Property(e => e.TotalP).HasColumnName("Total_P");
            entity.Property(e => e.VDate)
                .HasMaxLength(255)
                .HasColumnName("V_Date");
            entity.Property(e => e.VoucherNumber).HasColumnName("voucher_number");
        });

        modelBuilder.Entity<AuditlogLogentry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auditlog_logentry_pkey");

            entity.ToTable("auditlog_logentry", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.Action, "auditlog_logentry_action_229afe39").HasFillFactor(99);

            entity.HasIndex(e => e.ActorId, "auditlog_logentry_actor_id_959271d2").HasFillFactor(99);

            entity.HasIndex(e => e.ContentTypeId, "auditlog_logentry_content_type_id_75830218").HasFillFactor(99);

            entity.HasIndex(e => e.ObjectId, "auditlog_logentry_object_id_09c2eee8").HasFillFactor(99);

            entity.HasIndex(e => e.ObjectPk, "auditlog_logentry_object_pk_6e3219c0").HasFillFactor(99);

            entity.HasIndex(e => e.ObjectPk, "auditlog_logentry_object_pk_6e3219c0_like").HasFillFactor(99);

            entity.HasIndex(e => e.Timestamp, "auditlog_logentry_timestamp_37867bb0").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasComment("TRIAL")
                .HasColumnName("action");
            entity.Property(e => e.ActorId)
                .HasComment("TRIAL")
                .HasColumnName("actor_id");
            entity.Property(e => e.AdditionalData)
                .HasComment("TRIAL")
                .HasColumnType("ntext")
                .HasColumnName("additional_data");
            entity.Property(e => e.Changes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("changes");
            entity.Property(e => e.ContentTypeId)
                .HasComment("TRIAL")
                .HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId)
                .HasComment("TRIAL")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectPk)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("object_pk");
            entity.Property(e => e.ObjectRepr)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("object_repr");
            entity.Property(e => e.RemoteAddr)
                .HasComment("TRIAL")
                .HasColumnType("ntext")
                .HasColumnName("remote_addr");
            entity.Property(e => e.SerializedData)
                .HasComment("TRIAL")
                .HasColumnType("ntext")
                .HasColumnName("serialized_data");
            entity.Property(e => e.Timestamp)
                .HasComment("TRIAL")
                .HasColumnName("timestamp");
            entity.Property(e => e.Trial123)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL123");

            entity.HasOne(d => d.Actor).WithMany(p => p.AuditlogLogentries)
                .HasForeignKey(d => d.ActorId)
                .HasConstraintName("auditlog_logentry_actor_id_959271d2_fk_useres_user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuditlogLogentries)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auditlog_logentry_content_type_id_75830218_fk_django_co");
        });

        modelBuilder.Entity<AuthGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_pkey");

            entity.ToTable("auth_group", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.Name, "auth_group_name_a6ea08ec_like").HasFillFactor(99);

            entity.HasIndex(e => e.Name, "auth_group_name_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial411)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL411");
        });

        modelBuilder.Entity<AuthGroupPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_group_permissions_pkey");

            entity.ToTable("auth_group_permissions", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.GroupId, "auth_group_permissions_group_id_b120cbf9").HasFillFactor(99);

            entity.HasIndex(e => new { e.GroupId, e.PermissionId }, "auth_group_permissions_group_id_permission_id_0cd325b0_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.PermissionId, "auth_group_permissions_permission_id_84c5c92e").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.GroupId)
                .HasComment("TRIAL")
                .HasColumnName("group_id");
            entity.Property(e => e.PermissionId)
                .HasComment("TRIAL")
                .HasColumnName("permission_id");
            entity.Property(e => e.Trial411)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL411");

            entity.HasOne(d => d.Group).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissions_group_id_b120cbf9_fk_auth_group_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.AuthGroupPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_group_permissio_permission_id_84c5c92e_fk_auth_perm");
        });

        modelBuilder.Entity<AuthPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("auth_permission_pkey");

            entity.ToTable("auth_permission", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.ContentTypeId, "auth_permission_content_type_id_2f476e4b").HasFillFactor(99);

            entity.HasIndex(e => new { e.ContentTypeId, e.Codename }, "auth_permission_content_type_id_codename_01ab375a_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Codename)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("codename");
            entity.Property(e => e.ContentTypeId)
                .HasComment("TRIAL")
                .HasColumnName("content_type_id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial411)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL411");

            entity.HasOne(d => d.ContentType).WithMany(p => p.AuthPermissions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("auth_permission_content_type_id_2f476e4b_fk_django_co");
        });

        modelBuilder.Entity<DepartmentsBook>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_books_pkey");

            entity.ToTable("Departments_books", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Departments_books_Department_id_76b43c53").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.IsChecked)
                .HasComment("TRIAL")
                .HasColumnName("is_checked");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.Shared)
                .HasComment("TRIAL")
                .HasColumnName("shared");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial888)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL888");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentsBooks)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_books_Department_id_76b43c53_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsDegresToWord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_degres_to_word_pkey");

            entity.ToTable("Departments_degres_to_word", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Num)
                .HasComment("TRIAL")
                .HasColumnName("num");
            entity.Property(e => e.Trial895)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL895");
            entity.Property(e => e.Word)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("word");
        });

        modelBuilder.Entity<DepartmentsDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_department_pkey");

            entity.ToTable("Departments_department", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CapsityPerTeacher)
                .HasComment("TRIAL")
                .HasColumnName("capsity_per_teacher");
            entity.Property(e => e.ConfessionBook)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("confession_book");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Image)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("image");
            entity.Property(e => e.Level)
                .HasComment("TRIAL")
                .HasColumnName("level");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.NameEn)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name_en");
            entity.Property(e => e.Number)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("number");
            entity.Property(e => e.RegCounterEving)
                .HasComment("TRIAL")
                .HasColumnName("reg_counter_eving");
            entity.Property(e => e.RegCounterMoring)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("reg_counter_moring");
            entity.Property(e => e.Short)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("short");
            entity.Property(e => e.Trial895)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL895");
            entity.Property(e => e.Type)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
        });

        modelBuilder.Entity<DepartmentsExamsSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_exams_schedules_pkey");

            entity.ToTable("Departments_exams_schedules", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Departments_exams_schedules_Department_id_f9a44f5a").HasFillFactor(99);

            entity.HasIndex(e => e.StageId, "Departments_exams_schedules_stage_id_b2ea3a67").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.StageId)
                .HasComment("TRIAL")
                .HasColumnName("stage_id");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial898)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL898");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentsExamsSchedules)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_exams_sc_Department_id_f9a44f5a_fk_Departmen");

            entity.HasOne(d => d.Stage).WithMany(p => p.DepartmentsExamsSchedules)
                .HasForeignKey(d => d.StageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_exams_sc_stage_id_b2ea3a67_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsLecturesSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_lectures_schedules_pkey");

            entity.ToTable("Departments_lectures_schedules", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Departments_lectures_schedules_Department_id_4c27584e").HasFillFactor(99);

            entity.HasIndex(e => e.StageId, "Departments_lectures_schedules_stage_id_69e76916").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.StageId)
                .HasComment("TRIAL")
                .HasColumnName("stage_id");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial898)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL898");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentsLecturesSchedules)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_lectures_Department_id_4c27584e_fk_Departmen");

            entity.HasOne(d => d.Stage).WithMany(p => p.DepartmentsLecturesSchedules)
                .HasForeignKey(d => d.StageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_lectures_stage_id_69e76916_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsMaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_material_pkey");

            entity.ToTable("Departments_material", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Departments_material_Department_id_01274434").HasFillFactor(99);

            entity.HasIndex(e => e.StageId, "Departments_material_stage_id_f40634a2").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "Departments_material_user_id_cd0f9f92").HasFillFactor(99);

            entity.HasIndex(e => e.YearId, "Departments_material_year_id_4d0b133d").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.EnName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("en_name");
            entity.Property(e => e.FinalPractical)
                .HasComment("TRIAL")
                .HasColumnName("final_practical");
            entity.Property(e => e.FinalTheoretical)
                .HasComment("TRIAL")
                .HasColumnName("final_theoretical");
            entity.Property(e => e.IsChecked)
                .HasComment("TRIAL")
                .HasColumnName("is_checked");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Order)
                .HasComment("TRIAL")
                .HasColumnName("order");
            entity.Property(e => e.PartHours)
                .HasComment("TRIAL")
                .HasColumnName("part_hours");
            entity.Property(e => e.Rate)
                .HasComment("TRIAL")
                .HasColumnName("rate");
            entity.Property(e => e.StageId)
                .HasComment("TRIAL")
                .HasColumnName("stage_id");
            entity.Property(e => e.TheryHours)
                .HasComment("TRIAL")
                .HasColumnName("thery_hours");
            entity.Property(e => e.Trial898)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL898");
            entity.Property(e => e.Type)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");
            entity.Property(e => e.Weight).HasComment("TRIAL");
            entity.Property(e => e.YearId)
                .HasComment("TRIAL")
                .HasColumnName("year_id");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentsMaterials)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_Department_id_01274434_fk_Departmen");

            entity.HasOne(d => d.Stage).WithMany(p => p.DepartmentsMaterials)
                .HasForeignKey(d => d.StageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_stage_id_f40634a2_fk_Departments_stage_id");

            entity.HasOne(d => d.User).WithMany(p => p.DepartmentsMaterials)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Departments_material_user_id_cd0f9f92_fk_useres_user_id");

            entity.HasOne(d => d.Year).WithMany(p => p.DepartmentsMaterials)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_year_id_4d0b133d_fk_Departments_year_id");
        });

        modelBuilder.Entity<DepartmentsMaterialCommentsAndRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_material_comments_and_rating_pkey");

            entity.ToTable("Departments_material_comments_and_rating", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Departments_material_comments_and_rating_Material_id_e34a0788").HasFillFactor(99);

            entity.HasIndex(e => e.StudentId, "Departments_material_comments_and_rating_Student_id_b4a41bce").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasComment("TRIAL")
                .HasColumnType("text");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.IsChecked)
                .HasComment("TRIAL")
                .HasColumnName("is_checked");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("Material_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Rate)
                .HasComment("TRIAL")
                .HasColumnName("rate");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Trial901)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL901");

            entity.HasOne(d => d.Material).WithMany(p => p.DepartmentsMaterialCommentsAndRatings)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_Material_id_e34a0788_fk_Departmen");

            entity.HasOne(d => d.Student).WithMany(p => p.DepartmentsMaterialCommentsAndRatings)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_Student_id_b4a41bce_fk_useres_us");
        });

        modelBuilder.Entity<DepartmentsMaterialLab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_material_labs_pkey");

            entity.ToTable("Departments_material_labs", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Departments_material_labs_material_id_89e773e9").HasFillFactor(99);

            entity.HasIndex(e => new { e.MaterialId, e.UserId }, "Departments_material_labs_material_id_user_id_31aa97c2_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "Departments_material_labs_user_id_e720c748").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("material_id");
            entity.Property(e => e.Trial901)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL901");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Material).WithMany(p => p.DepartmentsMaterialLabs)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_material_id_89e773e9_fk_Departmen");

            entity.HasOne(d => d.User).WithMany(p => p.DepartmentsMaterialLabs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_labs_user_id_e720c748_fk_useres_user_id");
        });

        modelBuilder.Entity<DepartmentsMaterialfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_materialfiles_pkey");

            entity.ToTable("Departments_materialfiles", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Departments_materialfiles_Material_id_3ad910fe").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DeanCheck)
                .HasComment("TRIAL")
                .HasColumnName("dean_check");
            entity.Property(e => e.EvaluationCheck)
                .HasComment("TRIAL")
                .HasColumnName("Evaluation_check");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.IsChecked)
                .HasComment("TRIAL")
                .HasColumnName("is_checked");
            entity.Property(e => e.Link)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("link");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("Material_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Note)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("note");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial905)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL905");

            entity.HasOne(d => d.Material).WithMany(p => p.DepartmentsMaterialfiles)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_Material_id_3ad910fe_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsMaterialfilesCommentsAndRating>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_materialfiles_comments_and_rating_pkey");

            entity.ToTable("Departments_materialfiles_comments_and_rating", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentId, "Departments_materialfiles__Student_id_cf0537f5").HasFillFactor(99);

            entity.HasIndex(e => e.FileId, "Departments_materialfiles_comments_and_rating_file_id_4c0fbfb5").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasComment("TRIAL")
                .HasColumnType("text");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.FileId)
                .HasComment("TRIAL")
                .HasColumnName("file_id");
            entity.Property(e => e.IsChecked)
                .HasComment("TRIAL")
                .HasColumnName("is_checked");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Rate)
                .HasComment("TRIAL")
                .HasColumnName("rate");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Trial905)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL905");

            entity.HasOne(d => d.File).WithMany(p => p.DepartmentsMaterialfilesCommentsAndRatings)
                .HasForeignKey(d => d.FileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_file_id_4c0fbfb5_fk_Departmen");

            entity.HasOne(d => d.Student).WithMany(p => p.DepartmentsMaterialfilesCommentsAndRatings)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_material_Student_id_cf0537f5_fk_useres_us");
        });

        modelBuilder.Entity<DepartmentsOrder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_orders_pkey");

            entity.ToTable("Departments_orders", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.YearId, "Departments_orders_year_id_6645c105").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Mitigation)
                .HasComment("TRIAL")
                .HasColumnName("mitigation");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.NumberOfDegrees)
                .HasComment("TRIAL")
                .HasColumnName("number_of_degrees");
            entity.Property(e => e.OnlySec)
                .HasComment("TRIAL")
                .HasColumnName("only_sec");
            entity.Property(e => e.Roletype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("roletype");
            entity.Property(e => e.StateChange)
                .HasComment("TRIAL")
                .HasColumnName("state_change");
            entity.Property(e => e.Trial905)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL905");
            entity.Property(e => e.YearId)
                .HasComment("TRIAL")
                .HasColumnName("year_id");

            entity.HasOne(d => d.Year).WithMany(p => p.DepartmentsOrders)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_orders_year_id_6645c105_fk_Departments_year_id");
        });

        modelBuilder.Entity<DepartmentsStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_stage_pkey");

            entity.ToTable("Departments_stage", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Stage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("stage");
            entity.Property(e => e.Trial908)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL908");
        });

        modelBuilder.Entity<DepartmentsStudentAlert>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_student_alerts_pkey");

            entity.ToTable("Departments_student_alerts", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Departments_student_alerts_Department_id_88d5bbe5").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.Description)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.Link)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("link");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial908)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL908");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentsStudentAlerts)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_student__Department_id_88d5bbe5_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsStudentIssue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_student_issues_pkey");

            entity.ToTable("Departments_student_issues", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentId, "Departments_student_issues_Student_id_0b3e19d8").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Description)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Replay)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("replay");
            entity.Property(e => e.Status)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Trial908)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL908");

            entity.HasOne(d => d.Student).WithMany(p => p.DepartmentsStudentIssues)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_student__Student_id_0b3e19d8_fk_useres_us");
        });

        modelBuilder.Entity<DepartmentsStudentTraining>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_student_training_pkey");

            entity.ToTable("Departments_student_training", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentinfromtionId, "Departments_student_training_studentinfromtion_id_c5a42578").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.InstitutionName)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("institution_name");
            entity.Property(e => e.MdName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("md_name");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.PrintIt)
                .HasComment("TRIAL")
                .HasColumnName("print_it");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Trial911)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL911");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.DepartmentsStudentTrainings)
                .HasForeignKey(d => d.StudentinfromtionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_student__studentinfromtion_id_c5a42578_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsStudentinfromtion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_studentinfromtion_pkey");

            entity.ToTable("Departments_studentinfromtion", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentId, "Departments_studentinfromtion_Student_id_3f97cce5").HasFillFactor(99);

            entity.HasIndex(e => e.StageId, "Departments_studentinfromtion_stage_id_eaffc915").HasFillFactor(99);

            entity.HasIndex(e => e.YearId, "Departments_studentinfromtion_year_id_d7b0dc37").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AccNote)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("acc_Note");
            entity.Property(e => e.Average)
                .HasComment("TRIAL")
                .HasColumnName("average");
            entity.Property(e => e.AverageFromExel)
                .HasComment("TRIAL")
                .HasColumnName("average_from_exel");
            entity.Property(e => e.Clearance)
                .HasComment("TRIAL")
                .HasColumnName("clearance");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepNote)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("dep_Note");
            entity.Property(e => e.DirectlyDate)
                .HasComment("TRIAL")
                .HasColumnName("directly_date");
            entity.Property(e => e.FailingYear)
                .HasComment("TRIAL")
                .HasColumnName("failing_year");
            entity.Property(e => e.Fee)
                .HasComment("TRIAL")
                .HasColumnName("fee");
            entity.Property(e => e.FeePrentage)
                .HasComment("TRIAL")
                .HasColumnName("fee_prentage");
            entity.Property(e => e.GroupNumber)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("group_number");
            entity.Property(e => e.HelpDagree)
                .HasComment("TRIAL")
                .HasColumnName("help_dagree");
            entity.Property(e => e.IdGroup)
                .HasComment("TRIAL")
                .HasColumnName("id_group");
            entity.Property(e => e.IdPrint)
                .HasComment("TRIAL")
                .HasColumnName("id_print");
            entity.Property(e => e.IsChacked)
                .HasComment("TRIAL")
                .HasColumnName("is_chacked");
            entity.Property(e => e.IsDirectly)
                .HasComment("TRIAL")
                .HasColumnName("is_directly");
            entity.Property(e => e.IsSuccess)
                .HasComment("TRIAL")
                .HasColumnName("is_success");
            entity.Property(e => e.Locked)
                .HasComment("TRIAL")
                .HasColumnName("locked");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text");
            entity.Property(e => e.NumberOfPayments)
                .HasComment("TRIAL")
                .HasColumnName("number_of_payments");
            entity.Property(e => e.Order)
                .HasComment("TRIAL")
                .HasColumnName("order");
            entity.Property(e => e.Paid)
                .HasComment("TRIAL")
                .HasColumnName("paid");
            entity.Property(e => e.Reduction)
                .HasComment("TRIAL")
                .HasColumnName("reduction");
            entity.Property(e => e.RerunYear)
                .HasComment("TRIAL")
                .HasColumnName("rerun_year");
            entity.Property(e => e.Resuit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.Roletype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("roletype");
            entity.Property(e => e.StageId)
                .HasComment("TRIAL")
                .HasColumnName("stage_id");
            entity.Property(e => e.State)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Total)
                .HasComment("TRIAL")
                .HasColumnName("total");
            entity.Property(e => e.Trial914)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL914");
            entity.Property(e => e.UnivOrder)
                .HasComment("TRIAL")
                .HasColumnName("univ_order");
            entity.Property(e => e.Withdrawal).HasComment("TRIAL");
            entity.Property(e => e.YearId)
                .HasComment("TRIAL")
                .HasColumnName("year_id");

            entity.HasOne(d => d.Stage).WithMany(p => p.DepartmentsStudentinfromtions)
                .HasForeignKey(d => d.StageId)
                .HasConstraintName("Departments_studenti_stage_id_eaffc915_fk_Departmen");

            entity.HasOne(d => d.Student).WithMany(p => p.DepartmentsStudentinfromtions)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_studenti_Student_id_3f97cce5_fk_useres_us");

            entity.HasOne(d => d.Year).WithMany(p => p.DepartmentsStudentinfromtions)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_studenti_year_id_d7b0dc37_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsStudentmaterial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_studentmaterials_pkey");

            entity.ToTable("Departments_studentmaterials", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Departments_studentmaterials_Material_id_0cd74d59").HasFillFactor(99);

            entity.HasIndex(e => e.StudentinfromtionId, "Departments_studentmaterials_studentinfromtion_id_dad8fb6f").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Appreciation)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Disabled)
                .HasComment("TRIAL")
                .HasColumnName("disabled");
            entity.Property(e => e.Dor1)
                .HasComment("TRIAL")
                .HasColumnName("dor1");
            entity.Property(e => e.Dor1Helped)
                .HasComment("TRIAL")
                .HasColumnName("dor1_helped");
            entity.Property(e => e.Dor2)
                .HasComment("TRIAL")
                .HasColumnName("dor2");
            entity.Property(e => e.Dor2Helped)
                .HasComment("TRIAL")
                .HasColumnName("dor2_helped");
            entity.Property(e => e.Dor3)
                .HasComment("TRIAL")
                .HasColumnName("dor3");
            entity.Property(e => e.Dor3Helped)
                .HasComment("TRIAL")
                .HasColumnName("dor3_helped");
            entity.Property(e => e.Dor4)
                .HasComment("TRIAL")
                .HasColumnName("dor4");
            entity.Property(e => e.FinalPractical)
                .HasComment("TRIAL")
                .HasColumnName("final_practical");
            entity.Property(e => e.FinalPractical2)
                .HasComment("TRIAL")
                .HasColumnName("final_practical2");
            entity.Property(e => e.FinalTheoretical)
                .HasComment("TRIAL")
                .HasColumnName("final_theoretical");
            entity.Property(e => e.FinalTheoretical2)
                .HasComment("TRIAL")
                .HasColumnName("final_theoretical2");
            entity.Property(e => e.FirstTotal)
                .HasComment("TRIAL")
                .HasColumnName("first_total");
            entity.Property(e => e.Fulfilled)
                .HasComment("TRIAL")
                .HasColumnName("fulfilled");
            entity.Property(e => e.HelpDgree)
                .HasComment("TRIAL")
                .HasColumnName("help_dgree");
            entity.Property(e => e.IsCarried)
                .HasComment("TRIAL")
                .HasColumnName("is_carried");
            entity.Property(e => e.IsCarry)
                .HasComment("TRIAL")
                .HasColumnName("is_carry");
            entity.Property(e => e.IsFail)
                .HasComment("TRIAL")
                .HasColumnName("is_fail");
            entity.Property(e => e.IsFailed)
                .HasComment("TRIAL")
                .HasColumnName("is_failed");
            entity.Property(e => e.IsMissing)
                .HasComment("TRIAL")
                .HasColumnName("is_missing");
            entity.Property(e => e.IsNotDor1)
                .HasComment("TRIAL")
                .HasColumnName("is_not_dor1");
            entity.Property(e => e.IsPresent)
                .HasComment("TRIAL")
                .HasColumnName("is_Present");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("Material_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Practical1)
                .HasComment("TRIAL")
                .HasColumnName("practical1");
            entity.Property(e => e.Practical2)
                .HasComment("TRIAL")
                .HasColumnName("practical2");
            entity.Property(e => e.Practical3)
                .HasComment("TRIAL")
                .HasColumnName("practical3");
            entity.Property(e => e.Quest)
                .HasComment("TRIAL")
                .HasColumnName("quest");
            entity.Property(e => e.SecondTotal)
                .HasComment("TRIAL")
                .HasColumnName("second_total");
            entity.Property(e => e.SickLeave)
                .HasComment("TRIAL")
                .HasColumnName("Sick_leave");
            entity.Property(e => e.StudentinfromtionId)
                .HasComment("TRIAL")
                .HasColumnName("studentinfromtion_id");
            entity.Property(e => e.Theoretical1)
                .HasComment("TRIAL")
                .HasColumnName("theoretical1");
            entity.Property(e => e.Theoretical2)
                .HasComment("TRIAL")
                .HasColumnName("theoretical2");
            entity.Property(e => e.Theoretical3)
                .HasComment("TRIAL")
                .HasColumnName("theoretical3");
            entity.Property(e => e.ThirdTotal)
                .HasComment("TRIAL")
                .HasColumnName("third_total");
            entity.Property(e => e.Total)
                .HasComment("TRIAL")
                .HasColumnName("total");
            entity.Property(e => e.Trial927)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL927");
            entity.Property(e => e.Writen1)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("writen1");
            entity.Property(e => e.Writen2)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("writen2");
            entity.Property(e => e.Writen3)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("writen3");

            entity.HasOne(d => d.Material).WithMany(p => p.DepartmentsStudentmaterials)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_studentm_Material_id_0cd74d59_fk_Departmen");

            entity.HasOne(d => d.Studentinfromtion).WithMany(p => p.DepartmentsStudentmaterials)
                .HasForeignKey(d => d.StudentinfromtionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Departments_studentm_studentinfromtion_id_dad8fb6f_fk_Departmen");
        });

        modelBuilder.Entity<DepartmentsUniversitySchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_university_schedules_pkey");

            entity.ToTable("Departments_university_schedules", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial983)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL983");
        });

        modelBuilder.Entity<DepartmentsYear>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Departments_year_pkey");

            entity.ToTable("Departments_year", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Hiding)
                .HasComment("TRIAL")
                .HasColumnName("hiding");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Prime)
                .HasComment("TRIAL")
                .HasColumnName("prime");
            entity.Property(e => e.Trial983)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL983");
            entity.Property(e => e.Year)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("year");
        });

        modelBuilder.Entity<DjangoAdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_admin_log_pkey");

            entity.ToTable("django_admin_log", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.ContentTypeId, "django_admin_log_content_type_id_c4bce8eb").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "django_admin_log_user_id_c564eba6").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.ActionFlag)
                .HasComment("TRIAL")
                .HasColumnName("action_flag");
            entity.Property(e => e.ActionTime)
                .HasComment("TRIAL")
                .HasColumnName("action_time");
            entity.Property(e => e.ChangeMessage)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("change_message");
            entity.Property(e => e.ContentTypeId)
                .HasComment("TRIAL")
                .HasColumnName("content_type_id");
            entity.Property(e => e.ObjectId)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("object_repr");
            entity.Property(e => e.Trial414)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL414");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.ContentType).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.ContentTypeId)
                .HasConstraintName("django_admin_log_content_type_id_c4bce8eb_fk_django_co");

            entity.HasOne(d => d.User).WithMany(p => p.DjangoAdminLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_admin_log_user_id_c564eba6_fk_useres_user_id");
        });

        modelBuilder.Entity<DjangoContentType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_content_type_pkey");

            entity.ToTable("django_content_type", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.AppLabel, e.Model }, "django_content_type_app_label_model_76bd3d3b_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AppLabel)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("app_label");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("model");
            entity.Property(e => e.Trial414)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL414");
        });

        modelBuilder.Entity<DjangoCronCronjoblock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_cron_cronjoblock_pkey");

            entity.ToTable("django_cron_cronjoblock", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.JobName, "django_cron_cronjoblock_job_name_fb6ce879_like").HasFillFactor(99);

            entity.HasIndex(e => e.JobName, "django_cron_cronjoblock_job_name_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.JobName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("job_name");
            entity.Property(e => e.Locked)
                .HasComment("TRIAL")
                .HasColumnName("locked");
            entity.Property(e => e.Trial414)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL414");
        });

        modelBuilder.Entity<DjangoCronCronjoblog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_cron_cronjoblog_pkey");

            entity.ToTable("django_cron_cronjoblog", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.Code, "django_cron_cronjoblog_code_48865653").HasFillFactor(99);

            entity.HasIndex(e => e.Code, "django_cron_cronjoblog_code_48865653_like").HasFillFactor(99);

            entity.HasIndex(e => new { e.Code, e.IsSuccess, e.RanAtTime }, "django_cron_cronjoblog_code_is_success_ran_at_time_84da9606_idx").HasFillFactor(99);

            entity.HasIndex(e => new { e.Code, e.StartTime }, "django_cron_cronjoblog_code_start_time_4fc78f9d_idx").HasFillFactor(99);

            entity.HasIndex(e => new { e.Code, e.StartTime, e.RanAtTime }, "django_cron_cronjoblog_code_start_time_ran_at_time_8b50b8fa_idx").HasFillFactor(99);

            entity.HasIndex(e => e.EndTime, "django_cron_cronjoblog_end_time_7918602a").HasFillFactor(99);

            entity.HasIndex(e => e.RanAtTime, "django_cron_cronjoblog_ran_at_time_7fed2751").HasFillFactor(99);

            entity.HasIndex(e => e.StartTime, "django_cron_cronjoblog_start_time_d68c0dd9").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("code");
            entity.Property(e => e.EndTime)
                .HasComment("TRIAL")
                .HasColumnName("end_time");
            entity.Property(e => e.IsSuccess)
                .HasComment("TRIAL")
                .HasColumnName("is_success");
            entity.Property(e => e.Message)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.RanAtTime)
                .HasComment("TRIAL")
                .HasColumnName("ran_at_time");
            entity.Property(e => e.StartTime)
                .HasComment("TRIAL")
                .HasColumnName("start_time");
            entity.Property(e => e.Trial417)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL417");
        });

        modelBuilder.Entity<DjangoMigration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_migrations_pkey");

            entity.ToTable("django_migrations", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.App)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("app");
            entity.Property(e => e.Applied)
                .HasComment("TRIAL")
                .HasColumnName("applied");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial417)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL417");
        });

        modelBuilder.Entity<DjangoPrivateChat2Dialogsmodel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_private_chat2_dialogsmodel_pkey");

            entity.ToTable("django_private_chat2_dialogsmodel", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.User1Id, e.User2Id }, "django_private_chat2_dia_user1_id_user2_id_e03ea1c6_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => new { e.User2Id, e.User1Id }, "django_private_chat2_dia_user2_id_user1_id_844ec043_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.User1Id, "django_private_chat2_dialogsmodel_user1_id_c125c342").HasFillFactor(99);

            entity.HasIndex(e => e.User2Id, "django_private_chat2_dialogsmodel_user2_id_8c449c3b").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasComment("TRIAL")
                .HasColumnName("created");
            entity.Property(e => e.Modified)
                .HasComment("TRIAL")
                .HasColumnName("modified");
            entity.Property(e => e.Trial421)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL421");
            entity.Property(e => e.User1Id)
                .HasComment("TRIAL")
                .HasColumnName("user1_id");
            entity.Property(e => e.User2Id)
                .HasComment("TRIAL")
                .HasColumnName("user2_id");

            entity.HasOne(d => d.User1).WithMany(p => p.DjangoPrivateChat2DialogsmodelUser1s)
                .HasForeignKey(d => d.User1Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_private_chat2_user1_id_c125c342_fk_useres_us");

            entity.HasOne(d => d.User2).WithMany(p => p.DjangoPrivateChat2DialogsmodelUser2s)
                .HasForeignKey(d => d.User2Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_private_chat2_user2_id_8c449c3b_fk_useres_us");
        });

        modelBuilder.Entity<DjangoPrivateChat2Messagemodel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_private_chat2_messagemodel_pkey");

            entity.ToTable("django_private_chat2_messagemodel", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.FileId, "django_private_chat2_messagemodel_file_id_12d34e0f").HasFillFactor(99);

            entity.HasIndex(e => e.RecipientId, "django_private_chat2_messagemodel_recipient_id_ee7ce9e4").HasFillFactor(99);

            entity.HasIndex(e => e.SenderId, "django_private_chat2_messagemodel_sender_id_3be378ad").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Created)
                .HasComment("TRIAL")
                .HasColumnName("created");
            entity.Property(e => e.FileId)
                .HasComment("TRIAL")
                .HasColumnName("file_id");
            entity.Property(e => e.IsRemoved)
                .HasComment("TRIAL")
                .HasColumnName("is_removed");
            entity.Property(e => e.Modified)
                .HasComment("TRIAL")
                .HasColumnName("modified");
            entity.Property(e => e.Read)
                .HasComment("TRIAL")
                .HasColumnName("read");
            entity.Property(e => e.RecipientId)
                .HasComment("TRIAL")
                .HasColumnName("recipient_id");
            entity.Property(e => e.SenderId)
                .HasComment("TRIAL")
                .HasColumnName("sender_id");
            entity.Property(e => e.Text)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Trial421)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL421");

            entity.HasOne(d => d.File).WithMany(p => p.DjangoPrivateChat2Messagemodels)
                .HasForeignKey(d => d.FileId)
                .HasConstraintName("django_private_chat2_file_id_12d34e0f_fk_django_pr");

            entity.HasOne(d => d.Recipient).WithMany(p => p.DjangoPrivateChat2MessagemodelRecipients)
                .HasForeignKey(d => d.RecipientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_private_chat2_recipient_id_ee7ce9e4_fk_useres_us");

            entity.HasOne(d => d.Sender).WithMany(p => p.DjangoPrivateChat2MessagemodelSenders)
                .HasForeignKey(d => d.SenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_private_chat2_sender_id_3be378ad_fk_useres_us");
        });

        modelBuilder.Entity<DjangoPrivateChat2Uploadedfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_private_chat2_uploadedfile_pkey");

            entity.ToTable("django_private_chat2_uploadedfile", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UploadedById, "django_private_chat2_uploadedfile_uploaded_by_id_fe955abd").HasFillFactor(99);

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.Trial421)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL421");
            entity.Property(e => e.UploadDate)
                .HasComment("TRIAL")
                .HasColumnName("upload_date");
            entity.Property(e => e.UploadedById)
                .HasComment("TRIAL")
                .HasColumnName("uploaded_by_id");

            entity.HasOne(d => d.UploadedBy).WithMany(p => p.DjangoPrivateChat2Uploadedfiles)
                .HasForeignKey(d => d.UploadedById)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("django_private_chat2_uploaded_by_id_fe955abd_fk_useres_us");
        });

        modelBuilder.Entity<DjangoSession>(entity =>
        {
            entity.HasKey(e => e.SessionKey).HasName("django_session_pkey");

            entity.ToTable("django_session", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.ExpireDate, "django_session_expire_date_a5c62663").HasFillFactor(99);

            entity.Property(e => e.SessionKey)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("session_key");
            entity.Property(e => e.ExpireDate)
                .HasComment("TRIAL")
                .HasColumnName("expire_date");
            entity.Property(e => e.SessionData)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("session_data");
            entity.Property(e => e.Trial421)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL421");
        });

        modelBuilder.Entity<DjangoSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("django_site_pkey");

            entity.ToTable("django_site", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_like").HasFillFactor(99);

            entity.HasIndex(e => e.Domain, "django_site_domain_a2e37b91_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Domain)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("domain");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial440)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL440");
        });

        modelBuilder.Entity<HucsiteFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_files_pkey");

            entity.ToTable("hucsite_files", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Photo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo");
            entity.Property(e => e.Trial440)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL440");
        });

        modelBuilder.Entity<HucsiteNews>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_news_pkey");

            entity.ToTable("hucsite_news", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.DefaultImg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("default_img");
            entity.Property(e => e.Details)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.MegLink)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("meg_link");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial443)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL443");
            entity.Property(e => e.Video)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("video");
        });

        modelBuilder.Entity<HucsiteNewsDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_news_Departments_pkey");

            entity.ToTable("hucsite_news_Departments", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "hucsite_news_Departments_department_id_52359394").HasFillFactor(99);

            entity.HasIndex(e => e.NewsId, "hucsite_news_Departments_news_id_b182d747").HasFillFactor(99);

            entity.HasIndex(e => new { e.NewsId, e.DepartmentId }, "hucsite_news_Departments_news_id_department_id_f6f80128_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.NewsId)
                .HasComment("TRIAL")
                .HasColumnName("news_id");
            entity.Property(e => e.Trial443)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL443");

            entity.HasOne(d => d.Department).WithMany(p => p.HucsiteNewsDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hucsite_news_Departm_department_id_52359394_fk_Departmen");

            entity.HasOne(d => d.News).WithMany(p => p.HucsiteNewsDepartments)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hucsite_news_Departments_news_id_b182d747_fk_hucsite_news_id");
        });

        modelBuilder.Entity<HucsiteNewsImg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_news_img_pkey");

            entity.ToTable("hucsite_news_img", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.NewId, "hucsite_news_img_new_id_c6ba9c99").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.NewId)
                .HasComment("TRIAL")
                .HasColumnName("new_id");
            entity.Property(e => e.Photo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo");
            entity.Property(e => e.Trial443)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL443");

            entity.HasOne(d => d.New).WithMany(p => p.HucsiteNewsImgs)
                .HasForeignKey(d => d.NewId)
                .HasConstraintName("hucsite_news_img_new_id_c6ba9c99_fk_hucsite_news_id");
        });

        modelBuilder.Entity<HucsiteNewsImg2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_news_img2_pkey");

            entity.ToTable("hucsite_news_img2", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.NewId, "hucsite_news_img2_new_id_9d0bd989").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.NewId)
                .HasComment("TRIAL")
                .HasColumnName("new_id");
            entity.Property(e => e.Photo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo");
            entity.Property(e => e.Trial447)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL447");

            entity.HasOne(d => d.New).WithMany(p => p.HucsiteNewsImg2s)
                .HasForeignKey(d => d.NewId)
                .HasConstraintName("hucsite_news_img2_new_id_9d0bd989_fk_hucsite_sdj_id");
        });

        modelBuilder.Entity<HucsiteNewsUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_news_user_pkey");

            entity.ToTable("hucsite_news_user", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.NewsId, "hucsite_news_user_news_id_2d420101").HasFillFactor(99);

            entity.HasIndex(e => new { e.NewsId, e.UserId }, "hucsite_news_user_news_id_user_id_9c811c1f_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "hucsite_news_user_user_id_cc103577").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.NewsId)
                .HasComment("TRIAL")
                .HasColumnName("news_id");
            entity.Property(e => e.Trial447)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL447");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.News).WithMany(p => p.HucsiteNewsUsers)
                .HasForeignKey(d => d.NewsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hucsite_news_user_news_id_2d420101_fk_hucsite_news_id");

            entity.HasOne(d => d.User).WithMany(p => p.HucsiteNewsUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("hucsite_news_user_user_id_cc103577_fk_useres_user_id");
        });

        modelBuilder.Entity<HucsitePhote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_photes_pkey");

            entity.ToTable("hucsite_photes", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Photo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial447)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL447");
        });

        modelBuilder.Entity<HucsitePublicLink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_public_links_pkey");

            entity.ToTable("hucsite_public_links", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Photo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial450)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL450");
        });

        modelBuilder.Entity<HucsiteSdj>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hucsite_sdj_pkey");

            entity.ToTable("hucsite_sdj", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.DefaultImg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("default_img");
            entity.Property(e => e.Details)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial450)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL450");
        });

        modelBuilder.Entity<ManagementsBooksDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_books_department_pkey");

            entity.ToTable("Managements_books_department", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Managements_books_department_Department_id_0ad264b2").HasFillFactor(99);

            entity.HasIndex(e => e.InsideInAndOutId, "Managements_books_department_inside_in_and_out_id_c8dbcce3").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.InsideInAndOutId)
                .HasComment("TRIAL")
                .HasColumnName("inside_in_and_out_id");
            entity.Property(e => e.ReadIt)
                .HasComment("TRIAL")
                .HasColumnName("read_it");
            entity.Property(e => e.Trial983)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL983");

            entity.HasOne(d => d.Department).WithMany(p => p.ManagementsBooksDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_books_de_Department_id_0ad264b2_fk_Departmen");

            entity.HasOne(d => d.InsideInAndOut).WithMany(p => p.ManagementsBooksDepartments)
                .HasForeignKey(d => d.InsideInAndOutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_books_de_inside_in_and_out_id_c8dbcce3_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsBooksTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_books_template_pkey");

            entity.ToTable("Managements_books_template", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Managements_books_template_department_id_5ade1797").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.BoyTemplate)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("boy_template");
            entity.Property(e => e.Conclusion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.GirlTemplate)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("girl_template");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("subject");
            entity.Property(e => e.Template)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("template");
            entity.Property(e => e.Trial993)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL993");

            entity.HasOne(d => d.Department).WithMany(p => p.ManagementsBooksTemplates)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("Managements_books_te_department_id_5ade1797_fk_Departmen");
        });

        modelBuilder.Entity<ManagementsColegeRecord>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_colege_record_pkey");

            entity.ToTable("Managements_colege_record", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Details)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.IssuerCount)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Issuer_count");
            entity.Property(e => e.IssuerDate)
                .HasComment("TRIAL")
                .HasColumnName("Issuer_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Species)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("species");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial993)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL993");
        });

        modelBuilder.Entity<ManagementsColegeRecordAnswerFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_colege_record_answer_files_pkey");

            entity.ToTable("Managements_colege_record_answer_files", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.RecordId, "Managements_colege_record_answer_files_record_id_ce9bdc46").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.RecordId)
                .HasComment("TRIAL")
                .HasColumnName("record_id");
            entity.Property(e => e.Trial993)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL993");

            entity.HasOne(d => d.Record).WithMany(p => p.ManagementsColegeRecordAnswerFiles)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("Managements_colege_r_record_id_ce9bdc46_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsColegeRecordDepartment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_colege_record_department_pkey");

            entity.ToTable("Managements_colege_record_department", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.InsideInAndOutId, "Managements_colege_record__inside_in_and_out_id_65540a25").HasFillFactor(99);

            entity.HasIndex(e => e.DepartmentId, "Managements_colege_record_department_Department_id_e928aee5").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.InsideInAndOutId)
                .HasComment("TRIAL")
                .HasColumnName("inside_in_and_out_id");
            entity.Property(e => e.ReadIt)
                .HasComment("TRIAL")
                .HasColumnName("read_it");
            entity.Property(e => e.Trial996)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL996");

            entity.HasOne(d => d.Department).WithMany(p => p.ManagementsColegeRecordDepartments)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_colege_r_Department_id_e928aee5_fk_Departmen");

            entity.HasOne(d => d.InsideInAndOut).WithMany(p => p.ManagementsColegeRecordDepartments)
                .HasForeignKey(d => d.InsideInAndOutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_colege_r_inside_in_and_out_id_65540a25_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsColegeRecordPrioritiesFile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_colege_record_priorities_files_pkey");

            entity.ToTable("Managements_colege_record_priorities_files", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.RecordId, "Managements_colege_record_priorities_files_record_id_c924a643").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.RecordId)
                .HasComment("TRIAL")
                .HasColumnName("record_id");
            entity.Property(e => e.Trial996)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL996");

            entity.HasOne(d => d.Record).WithMany(p => p.ManagementsColegeRecordPrioritiesFiles)
                .HasForeignKey(d => d.RecordId)
                .HasConstraintName("Managements_colege_r_record_id_c924a643_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsGraduationProject>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_graduation_project_pkey");

            entity.ToTable("Managements_graduation_project", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentId, "Managements_graduation_project_Student_id_aad8987b").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "Managements_graduation_project_user_id_0d663669").HasFillFactor(99);

            entity.HasIndex(e => e.YearOfTheGroupId, "Managements_graduation_project_year_of_the_group_id_ee7eba6f").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Trial996)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL996");
            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");
            entity.Property(e => e.YearOfTheGroupId)
                .HasComment("TRIAL")
                .HasColumnName("year_of_the_group_id");

            entity.HasOne(d => d.Student).WithMany(p => p.ManagementsGraduationProjectStudents)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_graduati_Student_id_aad8987b_fk_useres_us");

            entity.HasOne(d => d.User).WithMany(p => p.ManagementsGraduationProjectUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_graduati_user_id_0d663669_fk_useres_us");

            entity.HasOne(d => d.YearOfTheGroup).WithMany(p => p.ManagementsGraduationProjects)
                .HasForeignKey(d => d.YearOfTheGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_graduati_year_of_the_group_id_ee7eba6f_fk_Departmen");
        });

        modelBuilder.Entity<ManagementsGroupsCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_groups_count_pkey");

            entity.ToTable("Managements_groups_count", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "Managements_groups_count_Department_id_7ad98207").HasFillFactor(99);

            entity.HasIndex(e => e.StageId, "Managements_groups_count_Stage_id_10d5417c").HasFillFactor(99);

            entity.HasIndex(e => e.YearOfTheGroupId, "Managements_groups_count_year_of_the_group_id_69b05885").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.ClinicsCount)
                .HasComment("TRIAL")
                .HasColumnName("clinics_count");
            entity.Property(e => e.ComputersCount)
                .HasComment("TRIAL")
                .HasColumnName("computers_count");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("Department_id");
            entity.Property(e => e.Edu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("edu");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.PracticalCount)
                .HasComment("TRIAL")
                .HasColumnName("Practical_count");
            entity.Property(e => e.StageId)
                .HasComment("TRIAL")
                .HasColumnName("Stage_id");
            entity.Property(e => e.SystematicCount)
                .HasComment("TRIAL")
                .HasColumnName("systematic_count");
            entity.Property(e => e.TheoreticalCount)
                .HasComment("TRIAL")
                .HasColumnName("theoretical_count");
            entity.Property(e => e.Trial999)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL999");
            entity.Property(e => e.YearOfTheGroupId)
                .HasComment("TRIAL")
                .HasColumnName("year_of_the_group_id");

            entity.HasOne(d => d.Stage).WithMany(p => p.ManagementsGroupsCounts)
                .HasForeignKey(d => d.StageId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_groups_c_Stage_id_10d5417c_fk_Departmen");

            entity.HasOne(d => d.YearOfTheGroup).WithMany(p => p.ManagementsGroupsCounts)
                .HasForeignKey(d => d.YearOfTheGroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_groups_c_year_of_the_group_id_69b05885_fk_Departmen");
        });

        modelBuilder.Entity<ManagementsInsideInAndOut>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_inside_in_and_out_pkey");

            entity.ToTable("Managements_inside_in_and_out", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.BookTypeId, "Managements_inside_in_and_out_book_type_id_b37f2fff").HasFillFactor(99);

            entity.HasIndex(e => e.DepartmentId, "Managements_inside_in_and_out_department_id_a308c9b3").HasFillFactor(99);

            entity.HasIndex(e => e.SourceId, "Managements_inside_in_and_out_source_id_cf31a288").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("answer");
            entity.Property(e => e.Answered)
                .HasComment("TRIAL")
                .HasColumnName("answered");
            entity.Property(e => e.ArrivalCount)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("arrival_count");
            entity.Property(e => e.ArrivalDate)
                .HasComment("TRIAL")
                .HasColumnName("arrival_date");
            entity.Property(e => e.Book)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("book");
            entity.Property(e => e.BookTypeId)
                .HasComment("TRIAL")
                .HasColumnName("book_type_id");
            entity.Property(e => e.Conclusion)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.Details)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.InsideInAndOutId)
                .HasComment("TRIAL")
                .HasColumnName("inside_in_and_out_id");
            entity.Property(e => e.Issuer)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.IssuerCount)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Issuer_count");
            entity.Property(e => e.IssuerDate)
                .HasComment("TRIAL")
                .HasColumnName("Issuer_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.ReadIt)
                .HasComment("TRIAL")
                .HasColumnName("read_it");
            entity.Property(e => e.Signature)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.SourceId)
                .HasComment("TRIAL")
                .HasColumnName("source_id");
            entity.Property(e => e.Species)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("species");
            entity.Property(e => e.Subject)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("subject");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.TitleBook)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title_book");
            entity.Property(e => e.Trial999)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL999");

            entity.HasOne(d => d.BookType).WithMany(p => p.ManagementsInsideInAndOuts)
                .HasForeignKey(d => d.BookTypeId)
                .HasConstraintName("Managements_inside_i_book_type_id_b37f2fff_fk_Managemen");

            entity.HasOne(d => d.Department).WithMany(p => p.ManagementsInsideInAndOuts)
                .HasForeignKey(d => d.DepartmentId)
                .HasConstraintName("Managements_inside_i_department_id_a308c9b3_fk_Departmen");

            entity.HasOne(d => d.InsideInAndOut).WithMany(p => p.InverseInsideInAndOut)
                .HasForeignKey(d => d.InsideInAndOutId)
                .HasConstraintName("Managements_inside_i_inside_in_and_out_id_807a58d5_fk_Managemen");

            entity.HasOne(d => d.Source).WithMany(p => p.ManagementsInsideInAndOuts)
                .HasForeignKey(d => d.SourceId)
                .HasConstraintName("Managements_inside_i_source_id_cf31a288_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsInsideInAndOutUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_inside_in_and_out_user_pkey");

            entity.ToTable("Managements_inside_in_and_out_user", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.InsideInAndOutId, e.UserId }, "Managements_inside_in_an_inside_in_and_out_id_use_8ed58e3f_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.InsideInAndOutId, "Managements_inside_in_and__inside_in_and_out_id_4a7bb35b").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "Managements_inside_in_and_out_user_user_id_0bf12cc7").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.InsideInAndOutId)
                .HasComment("TRIAL")
                .HasColumnName("inside_in_and_out_id");
            entity.Property(e => e.Trial016)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL016");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.InsideInAndOut).WithMany(p => p.ManagementsInsideInAndOutUsers)
                .HasForeignKey(d => d.InsideInAndOutId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_inside_i_inside_in_and_out_id_4a7bb35b_fk_Managemen");

            entity.HasOne(d => d.User).WithMany(p => p.ManagementsInsideInAndOutUsers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_inside_i_user_id_0bf12cc7_fk_useres_us");
        });

        modelBuilder.Entity<ManagementsIssueCount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_issue_count_pkey");

            entity.ToTable("Managements_issue_count", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial019)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL019");
            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
        });

        modelBuilder.Entity<ManagementsIssueType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_issue_type_pkey");

            entity.ToTable("Managements_issue_type", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial019)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL019");
        });

        modelBuilder.Entity<ManagementsIssuer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_issuer_pkey");

            entity.ToTable("Managements_issuer", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial019)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL019");
        });

        modelBuilder.Entity<ManagementsKeyword>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_keywords_pkey");

            entity.ToTable("Managements_keywords", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DbName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("db_name");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial022)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL022");
        });

        modelBuilder.Entity<ManagementsLaboratorySpace>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_laboratory_spaces_pkey");

            entity.ToTable("Managements_laboratory_spaces", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Managements_laboratory_spaces_material_id_587bdc1b").HasFillFactor(99);

            entity.HasIndex(e => e.TypeId, "Managements_laboratory_spaces_type_id_c7d736fa").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("material_id");
            entity.Property(e => e.Space)
                .HasComment("TRIAL")
                .HasColumnName("space");
            entity.Property(e => e.Trial022)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL022");
            entity.Property(e => e.TypeId)
                .HasComment("TRIAL")
                .HasColumnName("type_id");

            entity.HasOne(d => d.Material).WithMany(p => p.ManagementsLaboratorySpaces)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_laborato_material_id_587bdc1b_fk_Departmen");

            entity.HasOne(d => d.Type).WithMany(p => p.ManagementsLaboratorySpaces)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_laborato_type_id_c7d736fa_fk_Managemen");
        });

        modelBuilder.Entity<ManagementsOffDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_off_days_pkey");

            entity.ToTable("Managements_off_days", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial022)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL022");
        });

        modelBuilder.Entity<ManagementsQuorumType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_quorum_types_pkey");

            entity.ToTable("Managements_quorum_types", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Trial025)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL025");
            entity.Property(e => e.Type)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");
        });

        modelBuilder.Entity<ManagementsResearch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_researchs_pkey");

            entity.ToTable("Managements_researchs", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "Managements_researchs_user_id_8779c058").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.Link)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("link");
            entity.Property(e => e.Name)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PulishName)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("pulish_name");
            entity.Property(e => e.SerierNumber)
                .HasComment("TRIAL")
                .HasColumnName("serier_number");
            entity.Property(e => e.Summary)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("summary");
            entity.Property(e => e.Trial025)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL025");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.ManagementsResearches)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("Managements_researchs_user_id_8779c058_fk_useres_user_id");
        });

        modelBuilder.Entity<ManagementsTeachingAssignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_teaching_assignments_pkey");

            entity.ToTable("Managements_teaching_assignments", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "Managements_teaching_assignments_material_id_7cdd3034").HasFillFactor(99);

            entity.HasIndex(e => e.TypeId, "Managements_teaching_assignments_type_id_65473661").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "Managements_teaching_assignments_user_id_1fe92ffb").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CountOfGroups)
                .HasComment("TRIAL")
                .HasColumnName("count_of_groups");
            entity.Property(e => e.Edu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("edu");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("material_id");
            entity.Property(e => e.Trial025)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL025");
            entity.Property(e => e.TypeId)
                .HasComment("TRIAL")
                .HasColumnName("type_id");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");

            entity.HasOne(d => d.Material).WithMany(p => p.ManagementsTeachingAssignments)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_teaching_material_id_7cdd3034_fk_Departmen");

            entity.HasOne(d => d.Type).WithMany(p => p.ManagementsTeachingAssignments)
                .HasForeignKey(d => d.TypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_teaching_type_id_65473661_fk_Managemen");

            entity.HasOne(d => d.User).WithMany(p => p.ManagementsTeachingAssignments)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_teaching_user_id_1fe92ffb_fk_useres_us");
        });

        modelBuilder.Entity<ManagementsVacationDay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Managements_vacation_days_pkey");

            entity.ToTable("Managements_vacation_days", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "Managements_vacation_days_user_id_76e9f9f8").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.DayNumbers)
                .HasComment("TRIAL")
                .HasColumnName("day_numbers");
            entity.Property(e => e.EveingVaction)
                .HasComment("TRIAL")
                .HasColumnName("eveing_vaction");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.MoringVaction)
                .HasComment("TRIAL")
                .HasColumnName("moring_vaction");
            entity.Property(e => e.Note)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.Trial029)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL029");
            entity.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.ManagementsVacationDays)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Managements_vacation_days_user_id_76e9f9f8_fk_useres_user_id");
        });

        modelBuilder.Entity<OmrSolverExamNumber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OMR_solver_exam_number_pkey");

            entity.ToTable("OMR_solver_exam_number", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "OMR_solver_exam_number_Material_id_d5577a3e").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ExeclQustions)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("execl_qustions");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("Material_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial029)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL029");

            entity.HasOne(d => d.Material).WithMany(p => p.OmrSolverExamNumbers)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OMR_solver_exam_numb_Material_id_d5577a3e_fk_Departmen");
        });

        modelBuilder.Entity<OmrSolverQustion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OMR_solver_qustions_pkey");

            entity.ToTable("OMR_solver_qustions", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.ExamNumberId, "OMR_solver_qustions_exam_number_id_fd5e7c0a").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.A)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.B)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.C)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.CurrectAnswer)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("currect_answer");
            entity.Property(e => e.D)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.E)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.ExamNumberId)
                .HasComment("TRIAL")
                .HasColumnName("exam_number_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Qustion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("qustion");
            entity.Property(e => e.Trial032)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL032");

            entity.HasOne(d => d.ExamNumber).WithMany(p => p.OmrSolverQustions)
                .HasForeignKey(d => d.ExamNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OMR_solver_qustions_exam_number_id_fd5e7c0a_fk_OMR_solve");
        });

        modelBuilder.Entity<OmrSolverStudentTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OMR_solver_student_test_pkey");

            entity.ToTable("OMR_solver_student_test", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.MaterialId, "OMR_solver_student_test_Material_id_3fd23d20").HasFillFactor(99);

            entity.HasIndex(e => e.ExamNumberId, "OMR_solver_student_test_exam_number_id_79ae9e7d").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Answers)
                .HasComment("TRIAL")
                .HasColumnType("ntext")
                .HasColumnName("answers");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Degree)
                .HasComment("TRIAL")
                .HasColumnName("degree");
            entity.Property(e => e.ExamNumberId)
                .HasComment("TRIAL")
                .HasColumnName("exam_number_id");
            entity.Property(e => e.MaterialId)
                .HasComment("TRIAL")
                .HasColumnName("Material_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PhotoAnswer)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("photo_answer");
            entity.Property(e => e.Trial032)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL032");

            entity.HasOne(d => d.ExamNumber).WithMany(p => p.OmrSolverStudentTests)
                .HasForeignKey(d => d.ExamNumberId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OMR_solver_student_t_exam_number_id_79ae9e7d_fk_OMR_solve");

            entity.HasOne(d => d.Material).WithMany(p => p.OmrSolverStudentTests)
                .HasForeignKey(d => d.MaterialId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("OMR_solver_student_t_Material_id_3fd23d20_fk_Departmen");
        });

        modelBuilder.Entity<RegistrationBugsandsuggest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_bugsandsuggests_pkey");

            entity.ToTable("Registration_bugsandsuggests", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentsId, "Registration_bugsandsuggests_students_id_795dc5a3").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Description)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.StudentsId)
                .HasComment("TRIAL")
                .HasColumnName("students_id");
            entity.Property(e => e.Trial032)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL032");

            entity.HasOne(d => d.Students).WithMany(p => p.RegistrationBugsandsuggests)
                .HasForeignKey(d => d.StudentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_bugsand_students_id_795dc5a3_fk_useres_us");
        });

        modelBuilder.Entity<RegistrationIdList>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_id_lists_pkey");

            entity.ToTable("Registration_id_lists", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepId, "Registration_id_lists_dep_id_eadc558b").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.DepId)
                .HasComment("TRIAL")
                .HasColumnName("dep_id");
            entity.Property(e => e.Group)
                .HasComment("TRIAL")
                .HasColumnName("group");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Trial035)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL035");

            entity.HasOne(d => d.Dep).WithMany(p => p.RegistrationIdLists)
                .HasForeignKey(d => d.DepId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_id_list_dep_id_eadc558b_fk_Departmen");
        });

        modelBuilder.Entity<RegistrationModelId>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_model_id_pkey");

            entity.ToTable("Registration_model_id", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.BackImg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("back_img");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.FrontImg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("front_img");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Trial035)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL035");
        });

        modelBuilder.Entity<RegistrationNamesTran>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_names_trans_pkey");

            entity.ToTable("Registration_names_trans", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.ArName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("ar_name");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.EnName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("en_name");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Trial035)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL035");
        });

        modelBuilder.Entity<RegistrationPreparatoryDocumentsStudentsReceipt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_preparatory_documents_students_receipt_pkey");

            entity.ToTable("Registration_preparatory_documents_students_receipt", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.StudentId, "Registration_preparatory_d_Student_id_be74b85f").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.StudentId)
                .HasComment("TRIAL")
                .HasColumnName("Student_id");
            entity.Property(e => e.Trial035)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL035");

            entity.HasOne(d => d.Student).WithMany(p => p.RegistrationPreparatoryDocumentsStudentsReceipts)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_prepara_Student_id_be74b85f_fk_useres_us");
        });

        modelBuilder.Entity<RegistrationRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_requests_pkey");

            entity.ToTable("Registration_requests", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.BookId, "Registration_requests_book_id_77683873").HasFillFactor(99);

            entity.HasIndex(e => e.StudentsId, "Registration_requests_students_id_39b2bd3f").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.BookId)
                .HasComment("TRIAL")
                .HasColumnName("book_id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.Isso)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("isso");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.Status)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("status");
            entity.Property(e => e.StudentsId)
                .HasComment("TRIAL")
                .HasColumnName("students_id");
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial038)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL038");
            entity.Property(e => e.Type)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("type");
            entity.Property(e => e.VoucherNumber)
                .HasComment("TRIAL")
                .HasColumnName("voucher_number");

            entity.HasOne(d => d.Book).WithMany(p => p.RegistrationRequests)
                .HasForeignKey(d => d.BookId)
                .HasConstraintName("Registration_request_book_id_77683873_fk_Managemen");

            entity.HasOne(d => d.Students).WithMany(p => p.RegistrationRequests)
                .HasForeignKey(d => d.StudentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_requests_students_id_39b2bd3f_fk_useres_user_id");
        });

        modelBuilder.Entity<RegistrationValidityRespond>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_validity_respond_pkey");

            entity.ToTable("Registration_validity_respond", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.Isso)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("isso");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title");
            entity.Property(e => e.Trial038)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL038");
        });

        modelBuilder.Entity<RegistrationValidityRespondStudent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Registration_validity_respond_students_pkey");

            entity.ToTable("Registration_validity_respond_students", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.ValidityRespondId, e.StudentsId }, "Registration_validity_re_validity_respond_id_stud_04d39489_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.ValidityRespondId, "Registration_validity_resp_validity_respond_id_649a4e64").HasFillFactor(99);

            entity.HasIndex(e => e.StudentsId, "Registration_validity_respond_students_students_id_ff14077c").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.StudentsId)
                .HasComment("TRIAL")
                .HasColumnName("students_id");
            entity.Property(e => e.Trial042)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL042");
            entity.Property(e => e.ValidityRespondId)
                .HasComment("TRIAL")
                .HasColumnName("validity_respond_id");

            entity.HasOne(d => d.Students).WithMany(p => p.RegistrationValidityRespondStudents)
                .HasForeignKey(d => d.StudentsId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_validit_students_id_ff14077c_fk_useres_us");

            entity.HasOne(d => d.ValidityRespond).WithMany(p => p.RegistrationValidityRespondStudents)
                .HasForeignKey(d => d.ValidityRespondId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Registration_validit_validity_respond_id_649a4e64_fk_Registrat");
        });

        modelBuilder.Entity<ReversionRevision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reversion_revision_pkey");

            entity.ToTable("reversion_revision", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DateCreated, "reversion_revision_date_created_96f7c20c").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "reversion_revision_user_id_17095f45").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Comment)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.DateCreated)
                .HasComment("TRIAL")
                .HasColumnName("date_created");
            entity.Property(e => e.Trial450)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL450");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.ReversionRevisions)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("reversion_revision_user_id_17095f45_fk_useres_user_id");
        });

        modelBuilder.Entity<ReversionVersion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("reversion_version_pkey");

            entity.ToTable("reversion_version", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.ContentTypeId, e.Db }, "reversion_v_content_f95daf_idx").HasFillFactor(99);

            entity.HasIndex(e => e.ContentTypeId, "reversion_version_content_type_id_7d0ff25c").HasFillFactor(99);

            entity.HasIndex(e => new { e.Db, e.ContentTypeId, e.ObjectId, e.RevisionId }, "reversion_version_db_content_type_id_objec_b2c54f65_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.RevisionId, "reversion_version_revision_id_af9f6a9d").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.ContentTypeId)
                .HasComment("TRIAL")
                .HasColumnName("content_type_id");
            entity.Property(e => e.Db)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("db");
            entity.Property(e => e.Format)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("format");
            entity.Property(e => e.ObjectId)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("object_id");
            entity.Property(e => e.ObjectRepr)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("object_repr");
            entity.Property(e => e.RevisionId)
                .HasComment("TRIAL")
                .HasColumnName("revision_id");
            entity.Property(e => e.SerializedData)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("serialized_data");
            entity.Property(e => e.Trial450)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL450");

            entity.HasOne(d => d.ContentType).WithMany(p => p.ReversionVersions)
                .HasForeignKey(d => d.ContentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reversion_version_content_type_id_7d0ff25c_fk_django_co");

            entity.HasOne(d => d.Revision).WithMany(p => p.ReversionVersions)
                .HasForeignKey(d => d.RevisionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("reversion_version_revision_id_af9f6a9d_fk_reversion_revision_id");
        });

        modelBuilder.Entity<SocialaccountSocialaccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("socialaccount_socialaccount_pkey");

            entity.ToTable("socialaccount_socialaccount", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.Provider, e.Uid }, "socialaccount_socialaccount_provider_uid_fc810c6e_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "socialaccount_socialaccount_user_id_8146e70c").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DateJoined)
                .HasComment("TRIAL")
                .HasColumnName("date_joined");
            entity.Property(e => e.ExtraData)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("extra_data");
            entity.Property(e => e.LastLogin)
                .HasComment("TRIAL")
                .HasColumnName("last_login");
            entity.Property(e => e.Provider)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("provider");
            entity.Property(e => e.Trial453)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL453");
            entity.Property(e => e.Uid)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("uid");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.SocialaccountSocialaccounts)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("socialaccount_socialaccount_user_id_8146e70c_fk_useres_user_id");
        });

        modelBuilder.Entity<SocialaccountSocialapp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("socialaccount_socialapp_pkey");

            entity.ToTable("socialaccount_socialapp", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("client_id");
            entity.Property(e => e.Key)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("key");
            entity.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Provider)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("provider");
            entity.Property(e => e.Secret)
                .HasMaxLength(191)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("secret");
            entity.Property(e => e.Trial460)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL460");
        });

        modelBuilder.Entity<SocialaccountSocialappSite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("socialaccount_socialapp_sites_pkey");

            entity.ToTable("socialaccount_socialapp_sites", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.SocialappId, e.SiteId }, "socialaccount_socialapp__socialapp_id_site_id_71a9a768_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.SiteId, "socialaccount_socialapp_sites_site_id_2579dee5").HasFillFactor(99);

            entity.HasIndex(e => e.SocialappId, "socialaccount_socialapp_sites_socialapp_id_97fb6e7d").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.SiteId)
                .HasComment("TRIAL")
                .HasColumnName("site_id");
            entity.Property(e => e.SocialappId)
                .HasComment("TRIAL")
                .HasColumnName("socialapp_id");
            entity.Property(e => e.Trial460)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL460");

            entity.HasOne(d => d.Site).WithMany(p => p.SocialaccountSocialappSites)
                .HasForeignKey(d => d.SiteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("socialaccount_social_site_id_2579dee5_fk_django_si");

            entity.HasOne(d => d.Socialapp).WithMany(p => p.SocialaccountSocialappSites)
                .HasForeignKey(d => d.SocialappId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("socialaccount_social_socialapp_id_97fb6e7d_fk_socialacc");
        });

        modelBuilder.Entity<SocialaccountSocialtoken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("socialaccount_socialtoken_pkey");

            entity.ToTable("socialaccount_socialtoken", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.AccountId, "socialaccount_socialtoken_account_id_951f210e").HasFillFactor(99);

            entity.HasIndex(e => e.AppId, "socialaccount_socialtoken_app_id_636a42d7").HasFillFactor(99);

            entity.HasIndex(e => new { e.AppId, e.AccountId }, "socialaccount_socialtoken_app_id_account_id_fca4e0ac_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AccountId)
                .HasComment("TRIAL")
                .HasColumnName("account_id");
            entity.Property(e => e.AppId)
                .HasComment("TRIAL")
                .HasColumnName("app_id");
            entity.Property(e => e.ExpiresAt)
                .HasComment("TRIAL")
                .HasColumnName("expires_at");
            entity.Property(e => e.Token)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("token");
            entity.Property(e => e.TokenSecret)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("token_secret");
            entity.Property(e => e.Trial460)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL460");

            entity.HasOne(d => d.Account).WithMany(p => p.SocialaccountSocialtokens)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("socialaccount_social_account_id_951f210e_fk_socialacc");

            entity.HasOne(d => d.App).WithMany(p => p.SocialaccountSocialtokens)
                .HasForeignKey(d => d.AppId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("socialaccount_social_app_id_636a42d7_fk_socialacc");
        });

        modelBuilder.Entity<UseresAdministrativeAuthority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_administrative_authority_pkey");

            entity.ToTable("useres_administrative_authority", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Icon)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial463)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL463");
            entity.Property(e => e.UrlName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("url_name");
        });

        modelBuilder.Entity<UseresAdministrativeAuthorityGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_administrative_authority_group_pkey");

            entity.ToTable("useres_administrative_authority_group", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.AdministrativeAuthorityId, e.GroupAuthorityId }, "useres_administrative_au_administrative_authority_214461e3_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.AdministrativeAuthorityId, "useres_administrative_auth_administrative_authority_i_d4e34610").HasFillFactor(99);

            entity.HasIndex(e => e.GroupAuthorityId, "useres_administrative_auth_group_authority_id_4d0678ef").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AdministrativeAuthorityId)
                .HasComment("TRIAL")
                .HasColumnName("administrative_authority_id");
            entity.Property(e => e.GroupAuthorityId)
                .HasComment("TRIAL")
                .HasColumnName("group_authority_id");
            entity.Property(e => e.Trial463)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL463");

            entity.HasOne(d => d.AdministrativeAuthority).WithMany(p => p.UseresAdministrativeAuthorityGroups)
                .HasForeignKey(d => d.AdministrativeAuthorityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_administrativ_administrative_autho_d4e34610_fk_useres_ad");

            entity.HasOne(d => d.GroupAuthority).WithMany(p => p.UseresAdministrativeAuthorityGroups)
                .HasForeignKey(d => d.GroupAuthorityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_administrativ_group_authority_id_4d0678ef_fk_useres_gr");
        });

        modelBuilder.Entity<UseresCertificate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_certificate_pkey");

            entity.ToTable("useres_certificate", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial463)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL463");
        });

        modelBuilder.Entity<UseresCollege>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_college_pkey");

            entity.ToTable("useres_college", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial463)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL463");
        });

        modelBuilder.Entity<UseresCountry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_country_pkey");

            entity.ToTable("useres_country", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial466)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL466");
        });

        modelBuilder.Entity<UseresGenField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_gen_field_pkey");

            entity.ToTable("useres_gen_field", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial466)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL466");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");
        });

        modelBuilder.Entity<UseresGivenAuthority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_given_authority_pkey");

            entity.ToTable("useres_given_authority", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepId, "useres_given_authority_dep_id_08819e0b").HasFillFactor(99);

            entity.HasIndex(e => e.GroupId, "useres_given_authority_group_id_7f6ec17f").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "useres_given_authority_user_id_d09c8901").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepId)
                .HasComment("TRIAL")
                .HasColumnName("dep_id");
            entity.Property(e => e.Discont)
                .HasComment("TRIAL")
                .HasColumnName("discont");
            entity.Property(e => e.GroupId)
                .HasComment("TRIAL")
                .HasColumnName("group_id");
            entity.Property(e => e.Trial466)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL466");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Dep).WithMany(p => p.UseresGivenAuthorities)
                .HasForeignKey(d => d.DepId)
                .HasConstraintName("useres_given_authori_dep_id_08819e0b_fk_Departmen");

            entity.HasOne(d => d.Group).WithMany(p => p.UseresGivenAuthorities)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_given_authori_group_id_7f6ec17f_fk_useres_gr");

            entity.HasOne(d => d.User).WithMany(p => p.UseresGivenAuthorities)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_given_authority_user_id_d09c8901_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresGroupAuthority>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_group_authority_pkey");

            entity.ToTable("useres_group_authority", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial469)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL469");
            entity.Property(e => e.Unique)
                .HasComment("TRIAL")
                .HasColumnName("unique");
            entity.Property(e => e.YearChanger)
                .HasComment("TRIAL")
                .HasColumnName("year_changer");
        });

        modelBuilder.Entity<UseresGroupAuthorityDep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_group_authority_dep_pkey");

            entity.ToTable("useres_group_authority_dep", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.GroupAuthorityId, e.DepartmentId }, "useres_group_authority_d_group_authority_id_depar_1a2c12d8_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.DepartmentId, "useres_group_authority_dep_department_id_69d9de51").HasFillFactor(99);

            entity.HasIndex(e => e.GroupAuthorityId, "useres_group_authority_dep_group_authority_id_c9ec096d").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.GroupAuthorityId)
                .HasComment("TRIAL")
                .HasColumnName("group_authority_id");
            entity.Property(e => e.Trial469)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL469");

            entity.HasOne(d => d.Department).WithMany(p => p.UseresGroupAuthorityDeps)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_group_authori_department_id_69d9de51_fk_Departmen");

            entity.HasOne(d => d.GroupAuthority).WithMany(p => p.UseresGroupAuthorityDeps)
                .HasForeignKey(d => d.GroupAuthorityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_group_authori_group_authority_id_c9ec096d_fk_useres_gr");
        });

        modelBuilder.Entity<UseresHireType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_hire_type_pkey");

            entity.ToTable("useres_hire_type", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial469)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL469");
        });

        modelBuilder.Entity<UseresInationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_inationality_pkey");

            entity.ToTable("useres_inationality", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial469)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL469");
        });

        modelBuilder.Entity<UseresNationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_nationality_pkey");

            entity.ToTable("useres_nationality", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial473)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL473");
        });

        modelBuilder.Entity<UseresPostionType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_postion_type_pkey");

            entity.ToTable("useres_postion_type", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial473)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL473");
        });

        modelBuilder.Entity<UseresPreviHire>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_previ_hire_pkey");

            entity.ToTable("useres_previ_hire", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial473)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL473");
        });

        modelBuilder.Entity<UseresReligion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_religion_pkey");

            entity.ToTable("useres_religion", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial476)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL476");
        });

        modelBuilder.Entity<UseresSpifField>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_spif_field_pkey");

            entity.ToTable("useres_spif_field", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.GroupId, "useres_spif_field_group_id_4d4a7a75").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.GroupId)
                .HasComment("TRIAL")
                .HasColumnName("group_id");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial476)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL476");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");

            entity.HasOne(d => d.Group).WithMany(p => p.UseresSpifFields)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("useres_spif_field_group_id_4d4a7a75_fk_accountin");
        });

        modelBuilder.Entity<UseresStudentDocument>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_student_document_pkey");

            entity.ToTable("useres_student_document", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "useres_student_document_user_id_3b7f1432").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.File)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("file");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.PageCount)
                .HasComment("TRIAL")
                .HasColumnName("page_count");
            entity.Property(e => e.Thumbnail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("thumbnail");
            entity.Property(e => e.Trial476)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL476");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UseresStudentDocuments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("useres_student_document_user_id_3b7f1432_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresThirdPartUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_third_part_users_pkey");

            entity.ToTable("useres_third_part_users", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.UserId, "useres_third_part_users_user_id_f5ebc976").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.Commitment)
                .HasComment("TRIAL")
                .HasColumnName("commitment");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Note)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("note");
            entity.Property(e => e.Trial479)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL479");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UseresThirdPartUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("useres_third_part_users_user_id_f5ebc976_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresTitel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_titel_pkey");

            entity.ToTable("useres_titel", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial479)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL479");
            entity.Property(e => e.Value)
                .HasComment("TRIAL")
                .HasColumnName("value");
        });

        modelBuilder.Entity<UseresType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_type_pkey");

            entity.ToTable("useres_type", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial479)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL479");
        });

        modelBuilder.Entity<UseresUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_user_pkey");

            entity.ToTable("useres_user", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.BachelorsId, "useres_user_Bachelors_id_caf7bcfe").HasFillFactor(99);

            entity.HasIndex(e => e.MasterId, "useres_user_Master_id_bc03697d").HasFillFactor(99);

            entity.HasIndex(e => e.NationalityCountryId, "useres_user_Nationality_country_id_7a91049a").HasFillFactor(99);

            entity.HasIndex(e => e.PhDId, "useres_user_PhD_id_d32d12d7").HasFillFactor(99);

            entity.HasIndex(e => e.CertificateId, "useres_user_certificate_id_c2856a06").HasFillFactor(99);

            entity.HasIndex(e => e.CountryId, "useres_user_country_id_d3b4c704").HasFillFactor(99);

            entity.HasIndex(e => e.DepId, "useres_user_dep_id_2169d0b8").HasFillFactor(99);

            entity.HasIndex(e => e.EndYearId, "useres_user_end_year_id_82d6cdaa").HasFillFactor(99);

            entity.HasIndex(e => e.GenFieldId, "useres_user_gen_field_id_1b43a5a1").HasFillFactor(99);

            entity.HasIndex(e => e.HireTypeId, "useres_user_hire_type_id_e073845c").HasFillFactor(99);

            entity.HasIndex(e => e.InationalityId, "useres_user_inationality_id_37cef5ea").HasFillFactor(99);

            entity.HasIndex(e => e.NationalityId, "useres_user_nationality_id_5f024d28").HasFillFactor(99);

            entity.HasIndex(e => e.PostionTypeId, "useres_user_postion_TYPE_id_cc4dc19b").HasFillFactor(99);

            entity.HasIndex(e => e.PreviHireId, "useres_user_previ_hire_id_29a589c1").HasFillFactor(99);

            entity.HasIndex(e => e.ReligionId, "useres_user_religion_id_de07f550").HasFillFactor(99);

            entity.HasIndex(e => e.SpifFieldId, "useres_user_spif_field_id_4129a0ac").HasFillFactor(99);

            entity.HasIndex(e => e.StartYearId, "useres_user_start_year_id_c37c8473").HasFillFactor(99);

            entity.HasIndex(e => e.TitelId, "useres_user_titel_id_a1a7c946").HasFillFactor(99);

            entity.HasIndex(e => e.TypeId, "useres_user_type_id_9c07c6ed").HasFillFactor(99);

            entity.HasIndex(e => e.Username, "useres_user_username_f84081cb_like").HasFillFactor(99);

            entity.HasIndex(e => e.Username, "useres_user_username_key")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.WayId, "useres_user_way_id_66951a94").HasFillFactor(99);

            entity.HasIndex(e => e.WindowId, "useres_user_window_id_fb26f457").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.AddById)
                .HasComment("TRIAL")
                .HasColumnName("add_by_id");
            entity.Property(e => e.Adress)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.AppliactionNote)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("appliaction_note");
            entity.Property(e => e.AppliactionType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Appliaction_type");
            entity.Property(e => e.ApplicationPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Application_photo");
            entity.Property(e => e.Area)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("area");
            entity.Property(e => e.AssociationReceiptFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Association_receipt_file");
            entity.Property(e => e.AssociationReceiptRecord)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Association_receipt_record");
            entity.Property(e => e.BachelorsId)
                .HasComment("TRIAL")
                .HasColumnName("Bachelors_id");
            entity.Property(e => e.BirthYear)
                .HasComment("TRIAL")
                .HasColumnName("birth_year");
            entity.Property(e => e.BrithDate)
                .HasComment("TRIAL")
                .HasColumnName("brith_date");
            entity.Property(e => e.CarryJob)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("carry_job");
            entity.Property(e => e.CarryName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("carry_name");
            entity.Property(e => e.CarryPhone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("carry_phone");
            entity.Property(e => e.CarryRt)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("carry_rt");
            entity.Property(e => e.CertificateId)
                .HasComment("TRIAL")
                .HasColumnName("certificate_id");
            entity.Property(e => e.Channel)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("channel");
            entity.Property(e => e.CheckedAndLocked)
                .HasComment("TRIAL")
                .HasColumnName("checked_and_locked");
            entity.Property(e => e.CitIdNumber)
                .HasComment("TRIAL")
                .HasColumnName("cit_id_number");
            entity.Property(e => e.CitIdNumberDate)
                .HasComment("TRIAL")
                .HasColumnName("cit_id_number_date");
            entity.Property(e => e.CitIdNumberEndDate)
                .HasComment("TRIAL")
                .HasColumnName("cit_id_number_end_date");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("code");
            entity.Property(e => e.Commitment)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("commitment");
            entity.Property(e => e.Contract)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("contract");
            entity.Property(e => e.ContractAgreement)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("contract_agreement");
            entity.Property(e => e.CountryId)
                .HasComment("TRIAL")
                .HasColumnName("country_id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.Cv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("cv");
            entity.Property(e => e.DadPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("dad_photo");
            entity.Property(e => e.Dar)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("dar");
            entity.Property(e => e.Date)
                .HasComment("TRIAL")
                .HasColumnName("date");
            entity.Property(e => e.Date2)
                .HasComment("TRIAL")
                .HasColumnName("date2");
            entity.Property(e => e.DepId)
                .HasComment("TRIAL")
                .HasColumnName("dep_id");
            entity.Property(e => e.DirectDate)
                .HasComment("TRIAL")
                .HasColumnName("direct_date");
            entity.Property(e => e.DocumentsCheck)
                .HasComment("TRIAL")
                .HasColumnName("documents_check");
            entity.Property(e => e.Dorea)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL");
            entity.Property(e => e.Edu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("edu");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("email");
            entity.Property(e => e.EmptyDays)
                .HasComment("TRIAL")
                .HasColumnName("empty_days");
            entity.Property(e => e.EnFullName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("en_full_name");
            entity.Property(e => e.EndYearId)
                .HasComment("TRIAL")
                .HasColumnName("end_year_id");
            entity.Property(e => e.EndorsementAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("endorsement_address");
            entity.Property(e => e.EvningTime)
                .HasComment("TRIAL")
                .HasColumnName("evning_time");
            entity.Property(e => e.ExamNumbers)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("exam_numbers");
            entity.Property(e => e.FakePasswordEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("fake_password_en");
            entity.Property(e => e.FilldeForm)
                .HasComment("TRIAL")
                .HasColumnName("fillde_form");
            entity.Property(e => e.FingerprintId)
                .HasComment("TRIAL")
                .HasColumnName("fingerprint_id");
            entity.Property(e => e.FingerprintLoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Fingerprint_loc");
            entity.Property(e => e.FingerprintNotReq)
                .HasComment("TRIAL")
                .HasColumnName("fingerprint_not_req");
            entity.Property(e => e.FirstInClass)
                .HasComment("TRIAL")
                .HasColumnName("first_in_class");
            entity.Property(e => e.FirstInClassUniversyAvgInWords)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("first_in_class_universy_avg_in_words");
            entity.Property(e => e.FirstName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("first_name");
            entity.Property(e => e.FrinshTotel)
                .HasComment("TRIAL")
                .HasColumnName("frinsh_totel");
            entity.Property(e => e.FullName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("full_name");
            entity.Property(e => e.FullNameEn)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("full_name_en");
            entity.Property(e => e.GenField)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("gen_field");
            entity.Property(e => e.GenFieldId)
                .HasComment("TRIAL")
                .HasColumnName("gen_field_id");
            entity.Property(e => e.Gev)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("gev");
            entity.Property(e => e.GrdNumber)
                .HasComment("TRIAL")
                .HasColumnName("grd_number");
            entity.Property(e => e.GrdNumberDate)
                .HasComment("TRIAL")
                .HasColumnName("grd_number_date");
            entity.Property(e => e.GridNumberDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("grid_number_date");
            entity.Property(e => e.GridOrderDate)
                .HasComment("TRIAL")
                .HasColumnName("grid_order_date");
            entity.Property(e => e.GridOrderNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("grid_order_number");
            entity.Property(e => e.GridTotal)
                .HasComment("TRIAL")
                .HasColumnName("grid_total");
            entity.Property(e => e.HireTypeId)
                .HasComment("TRIAL")
                .HasColumnName("hire_type_id");
            entity.Property(e => e.HiringDate)
                .HasComment("TRIAL")
                .HasColumnName("hiring_date");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("id_number");
            entity.Property(e => e.IdPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("id_photo");
            entity.Property(e => e.InationalityId)
                .HasComment("TRIAL")
                .HasColumnName("inationality_id");
            entity.Property(e => e.IsActive)
                .HasComment("TRIAL")
                .HasColumnName("is_active");
            entity.Property(e => e.IsDors)
                .HasComment("TRIAL")
                .HasColumnName("is_dors");
            entity.Property(e => e.IsForword)
                .HasComment("TRIAL")
                .HasColumnName("is_forword");
            entity.Property(e => e.IsSigned)
                .HasComment("TRIAL")
                .HasColumnName("is_signed");
            entity.Property(e => e.IsStaff)
                .HasComment("TRIAL")
                .HasColumnName("is_staff");
            entity.Property(e => e.IsSuperuser)
                .HasComment("TRIAL")
                .HasColumnName("is_superuser");
            entity.Property(e => e.IsWidhdrow)
                .HasComment("TRIAL")
                .HasColumnName("is_widhdrow");
            entity.Property(e => e.LastCertificateDate)
                .HasComment("TRIAL")
                .HasColumnName("last_Certificate_date");
            entity.Property(e => e.LastLogin)
                .HasComment("TRIAL")
                .HasColumnName("last_login");
            entity.Property(e => e.LastName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("last_name");
            entity.Property(e => e.LivePhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("live_photo");
            entity.Property(e => e.MainStatus)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("main_status");
            entity.Property(e => e.MasterId)
                .HasComment("TRIAL")
                .HasColumnName("Master_id");
            entity.Property(e => e.MdName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("md_name");
            entity.Property(e => e.MedicalExamination)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Medical_examination");
            entity.Property(e => e.MiddleSchoolGraduationYear)
                .HasComment("TRIAL")
                .HasColumnName("middle_school_graduation_year");
            entity.Property(e => e.MinistryInfo)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Ministry_info");
            entity.Property(e => e.MinistrySigned)
                .HasComment("TRIAL")
                .HasColumnName("Ministry_signed");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.MoringTime)
                .HasComment("TRIAL")
                .HasColumnName("moring_time");
            entity.Property(e => e.MotherName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("mother_name");
            entity.Property(e => e.MotherNameEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("mother_name_en");
            entity.Property(e => e.NationalityCountryId)
                .HasComment("TRIAL")
                .HasColumnName("Nationality_country_id");
            entity.Property(e => e.NationalityId)
                .HasComment("TRIAL")
                .HasColumnName("nationality_id");
            entity.Property(e => e.Notes)
                .HasComment("TRIAL")
                .HasColumnType("text")
                .HasColumnName("notes");
            entity.Property(e => e.NumberOfClass)
                .HasComment("TRIAL")
                .HasColumnName("number_of_class");
            entity.Property(e => e.OldAccounts)
                .HasComment("TRIAL")
                .HasColumnName("old_accounts");
            entity.Property(e => e.Others)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("others");
            entity.Property(e => e.OuthPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("outh_photo");
            entity.Property(e => e.Passport)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("passport");
            entity.Property(e => e.PassportNumber)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("passport_number");
            entity.Property(e => e.PassportNumberDate)
                .HasComment("TRIAL")
                .HasColumnName("passport_number_date");
            entity.Property(e => e.PassportNumberEndDate)
                .HasComment("TRIAL")
                .HasColumnName("passport_number_end_date");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("password");
            entity.Property(e => e.PersonalFile)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("personal_file");
            entity.Property(e => e.PersonalPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("personal_photo");
            entity.Property(e => e.PhDId)
                .HasComment("TRIAL")
                .HasColumnName("PhD_id");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("phone_number");
            entity.Property(e => e.PlaceOfBrith)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("place_of_brith");
            entity.Property(e => e.Postion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("postion");
            entity.Property(e => e.PostionTypeId)
                .HasComment("TRIAL")
                .HasColumnName("postion_TYPE_id");
            entity.Property(e => e.PrepDocument)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("prep_document");
            entity.Property(e => e.Pres)
                .HasComment("TRIAL")
                .HasColumnName("pres");
            entity.Property(e => e.PreviHireId)
                .HasComment("TRIAL")
                .HasColumnName("previ_hire_id");
            entity.Property(e => e.RecordNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("record_number");
            entity.Property(e => e.RecordNumberDate)
                .HasComment("TRIAL")
                .HasColumnName("record_number_date");
            entity.Property(e => e.RegistrationPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("Registration_photo");
            entity.Property(e => e.ReligionId)
                .HasComment("TRIAL")
                .HasColumnName("religion_id");
            entity.Property(e => e.ResignationDate)
                .HasComment("TRIAL")
                .HasColumnName("resignation_date");
            entity.Property(e => e.Rnumber)
                .HasComment("TRIAL")
                .HasColumnName("rnumber");
            entity.Property(e => e.Role)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("role");
            entity.Property(e => e.Roletype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("roletype");
            entity.Property(e => e.SchooName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("schoo_name");
            entity.Property(e => e.SecPhoto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("sec_photo");
            entity.Property(e => e.SecectNumbers)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("secect_numbers");
            entity.Property(e => e.SecondName)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("second_name");
            entity.Property(e => e.Sequence)
                .HasComment("TRIAL")
                .HasColumnName("sequence");
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("sex");
            entity.Property(e => e.SginUpCode)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("sgin_up_code");
            entity.Property(e => e.Specfic)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("specfic");
            entity.Property(e => e.SpifField)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("spif_field");
            entity.Property(e => e.SpifFieldId)
                .HasComment("TRIAL")
                .HasColumnName("spif_field_id");
            entity.Property(e => e.StartYearId)
                .HasComment("TRIAL")
                .HasColumnName("start_year_id");
            entity.Property(e => e.Store)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("store");
            entity.Property(e => e.StudentStatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("student_status");
            entity.Property(e => e.SummerTraining)
                .HasComment("TRIAL")
                .HasColumnName("summer_training");
            entity.Property(e => e.SuperiorPhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("superior_phone_number");
            entity.Property(e => e.TitelId)
                .HasComment("TRIAL")
                .HasColumnName("titel_id");
            entity.Property(e => e.TitleOrder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("title_order");
            entity.Property(e => e.Totel)
                .HasComment("TRIAL")
                .HasColumnName("totel");
            entity.Property(e => e.Trial479)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL479");
            entity.Property(e => e.TypeId)
                .HasComment("TRIAL")
                .HasColumnName("type_id");
            entity.Property(e => e.UnivPassword)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("univ_password");
            entity.Property(e => e.Univenumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("univenumber");
            entity.Property(e => e.UniversyAvg)
                .HasComment("TRIAL")
                .HasColumnName("universy_avg");
            entity.Property(e => e.UniversyAvgInWords)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("universy_avg_in_words");
            entity.Property(e => e.UniversyCirtifat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("universy_cirtifat");
            entity.Property(e => e.UniversyOrder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("universy_order");
            entity.Property(e => e.Username)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("username");
            entity.Property(e => e.WaitById)
                .HasComment("TRIAL")
                .HasColumnName("wait_by_id");
            entity.Property(e => e.WayId)
                .HasComment("TRIAL")
                .HasColumnName("way_id");
            entity.Property(e => e.WindowId)
                .HasComment("TRIAL")
                .HasColumnName("window_id");
            entity.Property(e => e.WorkOrder)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("work_order");
            entity.Property(e => e.Zqaq)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("zqaq");

            entity.HasOne(d => d.Bachelors).WithMany(p => p.UseresUserBachelors)
                .HasForeignKey(d => d.BachelorsId)
                .HasConstraintName("useres_user_Bachelors_id_caf7bcfe_fk_useres_college_id");

            entity.HasOne(d => d.Certificate).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.CertificateId)
                .HasConstraintName("useres_user_certificate_id_c2856a06_fk_useres_certificate_id");

            entity.HasOne(d => d.Country).WithMany(p => p.UseresUserCountries)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("useres_user_country_id_d3b4c704_fk_useres_country_id");

            entity.HasOne(d => d.Dep).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.DepId)
                .HasConstraintName("useres_user_dep_id_2169d0b8_fk_Departments_department_id");

            entity.HasOne(d => d.EndYear).WithMany(p => p.UseresUserEndYears)
                .HasForeignKey(d => d.EndYearId)
                .HasConstraintName("useres_user_end_year_id_82d6cdaa_fk_Departments_year_id");

            entity.HasOne(d => d.GenFieldNavigation).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.GenFieldId)
                .HasConstraintName("useres_user_gen_field_id_1b43a5a1_fk_useres_gen_field_id");

            entity.HasOne(d => d.HireType).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.HireTypeId)
                .HasConstraintName("useres_user_hire_type_id_e073845c_fk_useres_hire_type_id");

            entity.HasOne(d => d.Inationality).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.InationalityId)
                .HasConstraintName("useres_user_inationality_id_37cef5ea_fk_useres_inationality_id");

            entity.HasOne(d => d.Master).WithMany(p => p.UseresUserMasters)
                .HasForeignKey(d => d.MasterId)
                .HasConstraintName("useres_user_Master_id_bc03697d_fk_useres_college_id");

            entity.HasOne(d => d.NationalityCountry).WithMany(p => p.UseresUserNationalityCountries)
                .HasForeignKey(d => d.NationalityCountryId)
                .HasConstraintName("useres_user_Nationality_country__7a91049a_fk_useres_co");

            entity.HasOne(d => d.Nationality).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.NationalityId)
                .HasConstraintName("useres_user_nationality_id_5f024d28_fk_useres_nationality_id");

            entity.HasOne(d => d.PhD).WithMany(p => p.UseresUserPhDs)
                .HasForeignKey(d => d.PhDId)
                .HasConstraintName("useres_user_PhD_id_d32d12d7_fk_useres_college_id");

            entity.HasOne(d => d.PostionType).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.PostionTypeId)
                .HasConstraintName("useres_user_postion_TYPE_id_cc4dc19b_fk_useres_postion_type_id");

            entity.HasOne(d => d.PreviHire).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.PreviHireId)
                .HasConstraintName("useres_user_previ_hire_id_29a589c1_fk_useres_previ_hire_id");

            entity.HasOne(d => d.Religion).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.ReligionId)
                .HasConstraintName("useres_user_religion_id_de07f550_fk_useres_religion_id");

            entity.HasOne(d => d.SpifFieldNavigation).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.SpifFieldId)
                .HasConstraintName("useres_user_spif_field_id_4129a0ac_fk_useres_spif_field_id");

            entity.HasOne(d => d.StartYear).WithMany(p => p.UseresUserStartYears)
                .HasForeignKey(d => d.StartYearId)
                .HasConstraintName("useres_user_start_year_id_c37c8473_fk_Departments_year_id");

            entity.HasOne(d => d.Titel).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.TitelId)
                .HasConstraintName("useres_user_titel_id_a1a7c946_fk_useres_titel_id");

            entity.HasOne(d => d.Type).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("useres_user_type_id_9c07c6ed_fk_useres_type_id");

            entity.HasOne(d => d.Way).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.WayId)
                .HasConstraintName("useres_user_way_id_66951a94_fk_useres_way_id");

            entity.HasOne(d => d.Window).WithMany(p => p.UseresUsers)
                .HasForeignKey(d => d.WindowId)
                .HasConstraintName("useres_user_window_id_fb26f457_fk_useres_window_id");
        });

        modelBuilder.Entity<UseresUserDep>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_user_deps_pkey");

            entity.ToTable("useres_user_deps", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.DepartmentId, "useres_user_deps_department_id_58511f22").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "useres_user_deps_user_id_44ed5ea0").HasFillFactor(99);

            entity.HasIndex(e => new { e.UserId, e.DepartmentId }, "useres_user_deps_user_id_department_id_5da27d47_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.DepartmentId)
                .HasComment("TRIAL")
                .HasColumnName("department_id");
            entity.Property(e => e.Trial502)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL502");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Department).WithMany(p => p.UseresUserDeps)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_deps_department_id_58511f22_fk_Departmen");

            entity.HasOne(d => d.User).WithMany(p => p.UseresUserDeps)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_deps_user_id_44ed5ea0_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresUserGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_user_groups_pkey");

            entity.ToTable("useres_user_groups", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => e.GroupId, "useres_user_groups_group_id_9c48b7b4").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "useres_user_groups_user_id_1d6af7d6").HasFillFactor(99);

            entity.HasIndex(e => new { e.UserId, e.GroupId }, "useres_user_groups_user_id_group_id_f2051912_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.GroupId)
                .HasComment("TRIAL")
                .HasColumnName("group_id");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL505");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Group).WithMany(p => p.UseresUserGroups)
                .HasForeignKey(d => d.GroupId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_groups_group_id_9c48b7b4_fk_auth_group_id");

            entity.HasOne(d => d.User).WithMany(p => p.UseresUserGroups)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_groups_user_id_1d6af7d6_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresUserUserPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_user_user_permissions_pkey");

            entity.ToTable("useres_user_user_permissions", tb => tb.HasComment("TRIAL"));

            entity.HasIndex(e => new { e.UserId, e.PermissionId }, "useres_user_user_permiss_user_id_permission_id_4722e220_uniq")
                .IsUnique()
                .HasFillFactor(99);

            entity.HasIndex(e => e.PermissionId, "useres_user_user_permissions_permission_id_ab97187e").HasFillFactor(99);

            entity.HasIndex(e => e.UserId, "useres_user_user_permissions_user_id_15076b5b").HasFillFactor(99);

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.PermissionId)
                .HasComment("TRIAL")
                .HasColumnName("permission_id");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL505");
            entity.Property(e => e.UserId)
                .HasComment("TRIAL")
                .HasColumnName("user_id");

            entity.HasOne(d => d.Permission).WithMany(p => p.UseresUserUserPermissions)
                .HasForeignKey(d => d.PermissionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_user_per_permission_id_ab97187e_fk_auth_perm");

            entity.HasOne(d => d.User).WithMany(p => p.UseresUserUserPermissions)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("useres_user_user_permissions_user_id_15076b5b_fk_useres_user_id");
        });

        modelBuilder.Entity<UseresWay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_way_pkey");

            entity.ToTable("useres_way", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL505");
        });

        modelBuilder.Entity<UseresWindow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("useres_window_pkey");

            entity.ToTable("useres_window", tb => tb.HasComment("TRIAL"));

            entity.Property(e => e.Id)
                .HasComment("TRIAL")
                .HasColumnName("id");
            entity.Property(e => e.CreatedDate)
                .HasComment("TRIAL")
                .HasColumnName("created_date");
            entity.Property(e => e.ModifiedDate)
                .HasComment("TRIAL")
                .HasColumnName("modified_date");
            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasComment("TRIAL")
                .HasColumnName("name");
            entity.Property(e => e.Trial505)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("TRIAL")
                .HasColumnName("TRIAL505");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
