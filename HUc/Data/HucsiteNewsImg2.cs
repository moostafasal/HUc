using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class HucsiteNewsImg2
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Photo { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? NewId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial447 { get; set; }

    public virtual HucsiteSdj? New { get; set; }
}
