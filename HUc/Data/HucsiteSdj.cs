using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class HucsiteSdj
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string DefaultImg { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Details { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Book { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial450 { get; set; }

    public virtual ICollection<HucsiteNewsImg2> HucsiteNewsImg2s { get; set; } = new List<HucsiteNewsImg2>();
}
