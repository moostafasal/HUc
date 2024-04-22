using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoPrivateChat2Messagemodel
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset Created { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset Modified { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsRemoved { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Text { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Read { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public Guid? FileId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long RecipientId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long SenderId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial421 { get; set; }

    public virtual DjangoPrivateChat2Uploadedfile? File { get; set; }

    public virtual UseresUser Recipient { get; set; } = null!;

    public virtual UseresUser Sender { get; set; } = null!;
}
