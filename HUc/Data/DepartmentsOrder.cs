using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsOrder
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Roletype { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int NumberOfDegrees { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? OnlySec { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? StateChange { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? Mitigation { get; set; }

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
    public string? Trial905 { get; set; }

    public virtual DepartmentsYear Year { get; set; } = null!;
}
