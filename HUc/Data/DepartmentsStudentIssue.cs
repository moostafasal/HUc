using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStudentIssue
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
    public string Description { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Replay { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial908 { get; set; }

    public virtual UseresUser Student { get; set; } = null!;
}
