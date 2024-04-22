using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ReversionVersion
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ObjectId { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Format { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string SerializedData { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string ObjectRepr { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ContentTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int RevisionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Db { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial450 { get; set; }

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual ReversionRevision Revision { get; set; } = null!;
}
