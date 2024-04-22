using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStudentAlert
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
    public string Title { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Description { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? File { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial908 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;
}
