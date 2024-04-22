using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsTeachingAssignment
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Value { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long TypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Edu { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? CountOfGroups { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial025 { get; set; }

    public virtual DepartmentsMaterial Material { get; set; } = null!;

    public virtual ManagementsQuorumType Type { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;
}
