using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingDiscount
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Rate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int YearId { get; set; }

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
    public bool? CountAsPayment { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial048 { get; set; }

    public virtual ICollection<AccountingStudentDiscount> AccountingStudentDiscounts { get; set; } = new List<AccountingStudentDiscount>();

    public virtual DepartmentsYear Year { get; set; } = null!;
}
