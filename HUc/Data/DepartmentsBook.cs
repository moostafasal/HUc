using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsBook
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
    public bool IsChecked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Shared { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string File { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Thumbnail { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial888 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;
}
