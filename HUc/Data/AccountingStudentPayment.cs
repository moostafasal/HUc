using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingStudentPayment
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Notes { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Payment { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Identity { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Protest { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? SupportBook { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Other { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? NonCurrentActivity { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Predecessor { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Deduction { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int VoucherNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Support { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? IdentityNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? OtherNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PaymentNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ProtestNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SupportNotes { get; set; }

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
    public int? Insurances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? InsurancesNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SupportBookNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Penalty { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? PenaltyNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Training { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? TrainingNotes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Checked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial087 { get; set; }

    public virtual DepartmentsStudentinfromtion? Studentinfromtion { get; set; }
}
