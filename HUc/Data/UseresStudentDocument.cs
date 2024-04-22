using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresStudentDocument
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
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string File { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Thumbnail { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial476 { get; set; }

    public virtual UseresUser? User { get; set; }
}
