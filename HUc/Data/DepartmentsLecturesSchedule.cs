using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsLecturesSchedule
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
    public string File { get; set; } = null!;

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
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StageId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial898 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;

    public virtual DepartmentsStage Stage { get; set; } = null!;
}
