using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ReversionRevision
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset DateCreated { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Comment { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial450 { get; set; }

    public virtual ICollection<ReversionVersion> ReversionVersions { get; set; } = new List<ReversionVersion>();

    public virtual UseresUser? User { get; set; }
}
