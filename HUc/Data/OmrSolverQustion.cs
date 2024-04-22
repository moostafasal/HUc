using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class OmrSolverQustion
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
    public string Qustion { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string A { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string B { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string C { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string D { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string E { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string CurrectAnswer { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ExamNumberId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial032 { get; set; }

    public virtual OmrSolverExamNumber ExamNumber { get; set; } = null!;
}
