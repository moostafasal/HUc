using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AuditlogLogentry
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ObjectPk { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? ObjectId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ObjectRepr { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public short Action { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Changes { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset Timestamp { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? ActorId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ContentTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? RemoteAddr { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? AdditionalData { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? SerializedData { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial123 { get; set; }

    public virtual UseresUser? Actor { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;
}
