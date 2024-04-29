using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsBooksTemplate
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Template { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Subject { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Conclusion { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? BoyTemplate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? GirlTemplate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial993 { get; set; }

    public virtual DepartmentsDepartment? Department { get; set; }
}
