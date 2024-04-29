using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsDepartment
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Level { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Image { get; set; }

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
    public string NameEn { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? CapsityPerTeacher { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ConfessionBook { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Number { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Short { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? RegCounterEving { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? RegCounterMoring { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial895 { get; set; }

    public virtual ICollection<AccountingAnnualInstallment> AccountingAnnualInstallments { get; set; } = new List<AccountingAnnualInstallment>();

    public virtual ICollection<DepartmentsBook> DepartmentsBooks { get; set; } = new List<DepartmentsBook>();

    public virtual ICollection<DepartmentsExamsSchedule> DepartmentsExamsSchedules { get; set; } = new List<DepartmentsExamsSchedule>();

    public virtual ICollection<DepartmentsLecturesSchedule> DepartmentsLecturesSchedules { get; set; } = new List<DepartmentsLecturesSchedule>();

    public virtual ICollection<DepartmentsMaterial> DepartmentsMaterials { get; set; } = new List<DepartmentsMaterial>();

    public virtual ICollection<DepartmentsStudentAlert> DepartmentsStudentAlerts { get; set; } = new List<DepartmentsStudentAlert>();

    public virtual ICollection<HucsiteNewsDepartment> HucsiteNewsDepartments { get; set; } = new List<HucsiteNewsDepartment>();

    public virtual ICollection<ManagementsBooksDepartment> ManagementsBooksDepartments { get; set; } = new List<ManagementsBooksDepartment>();

    public virtual ICollection<ManagementsBooksTemplate> ManagementsBooksTemplates { get; set; } = new List<ManagementsBooksTemplate>();

    public virtual ICollection<ManagementsColegeRecordDepartment> ManagementsColegeRecordDepartments { get; set; } = new List<ManagementsColegeRecordDepartment>();

    public virtual ICollection<ManagementsInsideInAndOut> ManagementsInsideInAndOuts { get; set; } = new List<ManagementsInsideInAndOut>();

    public virtual ICollection<RegistrationIdList> RegistrationIdLists { get; set; } = new List<RegistrationIdList>();

    public virtual ICollection<UseresGivenAuthority> UseresGivenAuthorities { get; set; } = new List<UseresGivenAuthority>();

    public virtual ICollection<UseresGroupAuthorityDep> UseresGroupAuthorityDeps { get; set; } = new List<UseresGroupAuthorityDep>();

    public virtual ICollection<UseresUserDep> UseresUserDeps { get; set; } = new List<UseresUserDep>();

    public virtual ICollection<UseresUser> UseresUsers { get; set; } = new List<UseresUser>();
}
