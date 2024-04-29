using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsGroupsCount
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
    public int TheoreticalCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int PracticalCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int SystematicCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ClinicsCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ComputersCount { get; set; }

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
    public int YearOfTheGroupId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Edu { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial999 { get; set; }

    public virtual DepartmentsStage Stage { get; set; } = null!;

    public virtual DepartmentsYear YearOfTheGroup { get; set; } = null!;
}
