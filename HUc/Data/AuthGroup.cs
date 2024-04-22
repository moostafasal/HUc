using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AuthGroup
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial411 { get; set; }

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; } = new List<AuthGroupPermission>();

    public virtual ICollection<UseresUserGroup> UseresUserGroups { get; set; } = new List<UseresUserGroup>();
}
