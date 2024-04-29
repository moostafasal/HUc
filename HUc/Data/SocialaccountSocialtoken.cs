using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class SocialaccountSocialtoken
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Token { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string TokenSecret { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int AccountId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int AppId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial460 { get; set; }

    public virtual SocialaccountSocialaccount Account { get; set; } = null!;

    public virtual SocialaccountSocialapp App { get; set; } = null!;
}
