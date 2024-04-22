using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingPenalty
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

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
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? Value { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial074 { get; set; }

    public virtual DepartmentsStudentinfromtion Studentinfromtion { get; set; } = null!;
}
