using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoCronCronjoblog
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Code { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset StartTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset EndTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsSuccess { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Message { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public TimeOnly? RanAtTime { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial417 { get; set; }
}
