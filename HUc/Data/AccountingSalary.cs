using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingSalary
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
    public int? CertificateAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? SurnameAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PositonAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? OtherAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? BaseAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TotalAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? EntitlementAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TitleHours { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? ActualTitleHours { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? MissingDays { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? StudentsCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TeachersCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TeachingEffort { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? OtherDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? LivingCost { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? TitleHoursDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DaysToWork { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? AccountNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? MissingDaysDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? NameedAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Teachingload { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DirectlyDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? ResearchAllowances { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? ResearchDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? LoansDeductions { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial081 { get; set; }

    public virtual UseresUser User { get; set; } = null!;
}
