using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationBugsandsuggest
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
    public string Description { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentsId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial032 { get; set; }

    public virtual UseresUser Students { get; set; } = null!;
}
