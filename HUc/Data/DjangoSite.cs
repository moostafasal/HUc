using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoSite
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Domain { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial440 { get; set; }

    public virtual ICollection<SocialaccountSocialappSite> SocialaccountSocialappSites { get; set; } = new List<SocialaccountSocialappSite>();
}
