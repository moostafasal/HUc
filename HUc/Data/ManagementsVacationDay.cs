using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsVacationDay
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
    public string? Type { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool MoringVaction { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool EveingVaction { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DayNumbers { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial029 { get; set; }

    public virtual UseresUser User { get; set; } = null!;
}
