using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsInsideInAndOutUser
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int InsideInAndOutId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial016 { get; set; }

    public virtual ManagementsInsideInAndOut InsideInAndOut { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;
}
