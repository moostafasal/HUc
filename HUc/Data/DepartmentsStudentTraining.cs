using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStudentTraining
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
    public string? MdName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string InstitutionName { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool PrintIt { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial911 { get; set; }

    public virtual DepartmentsStudentinfromtion Studentinfromtion { get; set; } = null!;
}
