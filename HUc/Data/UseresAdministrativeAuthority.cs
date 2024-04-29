using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresAdministrativeAuthority
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
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Icon { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string UrlName { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial463 { get; set; }

    public virtual ICollection<UseresAdministrativeAuthorityGroup> UseresAdministrativeAuthorityGroups { get; set; } = new List<UseresAdministrativeAuthorityGroup>();
}
