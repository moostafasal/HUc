using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresThirdPartUser
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
    public string Note { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Commitment { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial479 { get; set; }

    public virtual UseresUser? User { get; set; }
}
