using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class OmrSolverStudentTest
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
    public int Degree { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string PhotoAnswer { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Answers { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ExamNumberId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial032 { get; set; }

    public virtual OmrSolverExamNumber ExamNumber { get; set; } = null!;

    public virtual DepartmentsStudentinfromtion Material { get; set; } = null!;
}
