using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingStudentTakeBack
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int VoucherNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Value { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly Date { get; set; }

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
    public string? Trial123 { get; set; }

    public virtual DepartmentsStudentinfromtion Studentinfromtion { get; set; } = null!;
}
