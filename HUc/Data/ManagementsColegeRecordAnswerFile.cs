using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsColegeRecordAnswerFile
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Book { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? RecordId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial993 { get; set; }

    public virtual ManagementsColegeRecord? Record { get; set; }
}
