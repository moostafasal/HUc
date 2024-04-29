using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsYear
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Year { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? Prime { get; set; }

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
    public bool? Hiding { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial983 { get; set; }

    public virtual ICollection<AccountingAnnualInstallment> AccountingAnnualInstallments { get; set; } = new List<AccountingAnnualInstallment>();

    public virtual ICollection<AccountingDiscount> AccountingDiscounts { get; set; } = new List<AccountingDiscount>();

    public virtual ICollection<DepartmentsMaterial> DepartmentsMaterials { get; set; } = new List<DepartmentsMaterial>();

    public virtual ICollection<DepartmentsOrder> DepartmentsOrders { get; set; } = new List<DepartmentsOrder>();

    public virtual ICollection<DepartmentsStudentinfromtion> DepartmentsStudentinfromtions { get; set; } = new List<DepartmentsStudentinfromtion>();

    public virtual ICollection<ManagementsGraduationProject> ManagementsGraduationProjects { get; set; } = new List<ManagementsGraduationProject>();

    public virtual ICollection<ManagementsGroupsCount> ManagementsGroupsCounts { get; set; } = new List<ManagementsGroupsCount>();

    public virtual ICollection<UseresUser> UseresUserEndYears { get; set; } = new List<UseresUser>();

    public virtual ICollection<UseresUser> UseresUserStartYears { get; set; } = new List<UseresUser>();
}
