using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsColegeRecord
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? CreatedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? ModifiedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Species { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string IssuerCount { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? IssuerDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Book { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial993 { get; set; }

    public virtual ICollection<ManagementsColegeRecordAnswerFile> ManagementsColegeRecordAnswerFiles { get; set; } = new List<ManagementsColegeRecordAnswerFile>();

    public virtual ICollection<ManagementsColegeRecordDepartment> ManagementsColegeRecordDepartments { get; set; } = new List<ManagementsColegeRecordDepartment>();

    public virtual ICollection<ManagementsColegeRecordPrioritiesFile> ManagementsColegeRecordPrioritiesFiles { get; set; } = new List<ManagementsColegeRecordPrioritiesFile>();
}
