using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresGroupAuthority
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Unique { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool YearChanger { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial469 { get; set; }

    public virtual ICollection<UseresAdministrativeAuthorityGroup> UseresAdministrativeAuthorityGroups { get; set; } = new List<UseresAdministrativeAuthorityGroup>();

    public virtual ICollection<UseresGivenAuthority> UseresGivenAuthorities { get; set; } = new List<UseresGivenAuthority>();

    public virtual ICollection<UseresGroupAuthorityDep> UseresGroupAuthorityDeps { get; set; } = new List<UseresGroupAuthorityDep>();
}
