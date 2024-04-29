using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresUserGroup
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int GroupId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial505 { get; set; }

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;
}
