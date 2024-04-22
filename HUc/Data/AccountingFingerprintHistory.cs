using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingFingerprintHistory
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
    public TimeOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int FingerprintDayId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial058 { get; set; }

    public virtual AccountingFingerprintDay FingerprintDay { get; set; } = null!;
}
