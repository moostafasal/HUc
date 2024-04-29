using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoSession
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public string SessionKey { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string SessionData { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset ExpireDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial421 { get; set; }
}
