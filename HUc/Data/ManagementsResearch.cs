using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsResearch
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string PulishName { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int SerierNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Summary { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial025 { get; set; }

    public virtual UseresUser? User { get; set; }
}
