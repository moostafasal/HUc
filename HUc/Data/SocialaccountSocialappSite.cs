using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class SocialaccountSocialappSite
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int SocialappId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int SiteId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial460 { get; set; }

    public virtual DjangoSite Site { get; set; } = null!;

    public virtual SocialaccountSocialapp Socialapp { get; set; } = null!;
}
