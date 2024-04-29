using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountEmailaddress
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Email { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Verified { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Primary { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial042 { get; set; }

    public virtual ICollection<AccountEmailconfirmation> AccountEmailconfirmations { get; set; } = new List<AccountEmailconfirmation>();

    public virtual UseresUser User { get; set; } = null!;
}
