using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationModelId
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
    public string FrontImg { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string BackImg { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial035 { get; set; }
}
