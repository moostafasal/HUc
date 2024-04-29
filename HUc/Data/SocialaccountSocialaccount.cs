using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class SocialaccountSocialaccount
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
    public string Uid { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset LastLogin { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset DateJoined { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ExtraData { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial453 { get; set; }

    public virtual ICollection<SocialaccountSocialtoken> SocialaccountSocialtokens { get; set; } = new List<SocialaccountSocialtoken>();

    public virtual UseresUser User { get; set; } = null!;
}
