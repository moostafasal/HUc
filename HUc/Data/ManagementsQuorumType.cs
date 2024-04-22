using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsQuorumType
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial025 { get; set; }

    public virtual ICollection<ManagementsLaboratorySpace> ManagementsLaboratorySpaces { get; set; } = new List<ManagementsLaboratorySpace>();

    public virtual ICollection<ManagementsTeachingAssignment> ManagementsTeachingAssignments { get; set; } = new List<ManagementsTeachingAssignment>();
}
