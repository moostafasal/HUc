using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStudentinfromtion
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? Average { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? HelpDagree { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Roletype { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Resuit { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsSuccess { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Fee { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Reduction { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? StageId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int YearId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? AverageFromExel { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Order { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsChacked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Paid { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? FailingYear { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? RerunYear { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int FeePrentage { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? Clearance { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AccNote { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? DepNote { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Locked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Withdrawal { get; set; }

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
    public string? GroupNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsDirectly { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? DirectlyDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IdPrint { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? UnivOrder { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? IdGroup { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int NumberOfPayments { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial914 { get; set; }

    public virtual ICollection<AccountingPenalty> AccountingPenalties { get; set; } = new List<AccountingPenalty>();

    public virtual ICollection<AccountingStudentDiscount> AccountingStudentDiscounts { get; set; } = new List<AccountingStudentDiscount>();

    public virtual ICollection<AccountingStudentPayment> AccountingStudentPayments { get; set; } = new List<AccountingStudentPayment>();

    public virtual ICollection<AccountingStudentTakeBack> AccountingStudentTakeBacks { get; set; } = new List<AccountingStudentTakeBack>();

    public virtual ICollection<DepartmentsStudentTraining> DepartmentsStudentTrainings { get; set; } = new List<DepartmentsStudentTraining>();

    public virtual ICollection<DepartmentsStudentmaterial> DepartmentsStudentmaterials { get; set; } = new List<DepartmentsStudentmaterial>();

    public virtual ICollection<OmrSolverStudentTest> OmrSolverStudentTests { get; set; } = new List<OmrSolverStudentTest>();

    public virtual DepartmentsStage? Stage { get; set; }

    public virtual UseresUser Student { get; set; } = null!;

    public virtual DepartmentsYear Year { get; set; } = null!;
}
