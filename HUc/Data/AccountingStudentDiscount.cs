using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingStudentDiscount
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
    public int? Value { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DiscountId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Notes { get; set; }

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
    public string? Trial081 { get; set; }

    public virtual AccountingDiscount Discount { get; set; } = null!;

    public virtual DepartmentsStudentinfromtion Studentinfromtion { get; set; } = null!;
}
