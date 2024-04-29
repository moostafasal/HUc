using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoAdminLog
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset ActionTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ObjectId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ObjectRepr { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public short ActionFlag { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ChangeMessage { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? ContentTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial414 { get; set; }

    public virtual DjangoContentType? ContentType { get; set; }

    public virtual UseresUser User { get; set; } = null!;
}
