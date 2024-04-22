using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AuthGroupPermission
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int GroupId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int PermissionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial411 { get; set; }

    public virtual AuthGroup Group { get; set; } = null!;

    public virtual AuthPermission Permission { get; set; } = null!;
}
