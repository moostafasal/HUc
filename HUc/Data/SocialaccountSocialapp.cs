using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class SocialaccountSocialapp
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Provider { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ClientId { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Secret { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial460 { get; set; }

    public virtual ICollection<SocialaccountSocialappSite> SocialaccountSocialappSites { get; set; } = new List<SocialaccountSocialappSite>();

    public virtual ICollection<SocialaccountSocialtoken> SocialaccountSocialtokens { get; set; } = new List<SocialaccountSocialtoken>();
}
