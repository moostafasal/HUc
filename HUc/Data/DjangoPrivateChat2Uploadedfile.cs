using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoPrivateChat2Uploadedfile
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string File { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset UploadDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UploadedById { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial421 { get; set; }

    public virtual ICollection<DjangoPrivateChat2Messagemodel> DjangoPrivateChat2Messagemodels { get; set; } = new List<DjangoPrivateChat2Messagemodel>();

    public virtual UseresUser UploadedBy { get; set; } = null!;
}
