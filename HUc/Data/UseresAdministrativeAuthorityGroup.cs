using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresAdministrativeAuthorityGroup
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int AdministrativeAuthorityId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long GroupAuthorityId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial463 { get; set; }

    public virtual UseresAdministrativeAuthority AdministrativeAuthority { get; set; } = null!;

    public virtual UseresGroupAuthority GroupAuthority { get; set; } = null!;
}
