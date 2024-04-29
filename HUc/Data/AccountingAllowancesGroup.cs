using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountingAllowancesGroup
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
    public string? Specialization { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Phd { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Mc { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Hd { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial045 { get; set; }

    public virtual ICollection<UseresSpifField> UseresSpifFields { get; set; } = new List<UseresSpifField>();
}
