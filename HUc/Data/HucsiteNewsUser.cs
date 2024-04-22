using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class HucsiteNewsUser
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int NewsId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial447 { get; set; }

    public virtual HucsiteNews News { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;
}
