using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingFingerprintDay
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
    public DateOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool EveingFingerPrint { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool MoringFingerPrint { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial048 { get; set; }

    public virtual ICollection<AccountingFingerprintHistory> AccountingFingerprintHistories { get; set; } = new List<AccountingFingerprintHistory>();

    public virtual UseresUser User { get; set; } = null!;
}
