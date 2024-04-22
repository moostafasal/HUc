using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AccountEmailconfirmation
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset Created { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? Sent { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Key { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int EmailAddressId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial045 { get; set; }

    public virtual AccountEmailaddress EmailAddress { get; set; } = null!;
}
