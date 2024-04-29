using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class OmrSolverExamNumber
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
    public string ExeclQustions { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial029 { get; set; }

    public virtual DepartmentsMaterial Material { get; set; } = null!;

    public virtual ICollection<OmrSolverQustion> OmrSolverQustions { get; set; } = new List<OmrSolverQustion>();

    public virtual ICollection<OmrSolverStudentTest> OmrSolverStudentTests { get; set; } = new List<OmrSolverStudentTest>();
}
