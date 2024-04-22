using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoPrivateChat2Dialogsmodel
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
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long User1Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long User2Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial421 { get; set; }

    public virtual UseresUser User1 { get; set; } = null!;

    public virtual UseresUser User2 { get; set; } = null!;
}
