using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsGraduationProject
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int YearOfTheGroupId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial996 { get; set; }

    public virtual UseresUser Student { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;

    public virtual DepartmentsYear YearOfTheGroup { get; set; } = null!;
}
